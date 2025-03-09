using System.Globalization;
using System.Linq;
using System.IO;

namespace trabaio
{
    public partial class Home : Form
    {
        private System.Windows.Forms.Timer timer;

        public Home()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // 500ms de atraso
            timer.Tick += new EventHandler(OnTextChangedDelayed);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Configurações para as grid views de clientes e produtos
            clientesGridView.Columns.Add("Nome", "Nomes");
            clientesGridView.Columns.Add("Email", "Email");
            clientesGridView.Columns.Add("Nascimento", "Data Nascimento");
            clientesGridView.Columns.Add("CPF", "CPF");
            clientesGridView.Columns.Add("Cidade", "Cidade");
            clientesGridView.Columns.Add("Endereco", "Endereço");
            clientesGridView.Columns.Add("Estado", "Estado");

            produtosGrid.Columns.Add("Nome", "Produtos");
            produtosGrid.Columns.Add("Filial", "Filial");
            produtosGrid.Columns.Add("Quantidade", "Quantidade");
            produtosGrid.Columns.Add("PrecoUnitario", "Preço Unitário");
            produtosGrid.Columns.Add("PrecoTotal", "Preço Total");

            vendaGrid.Columns.Add("Cliente", "Cliente");
            vendaGrid.Columns.Add("Produto", "Produto");
            vendaGrid.Columns.Add("Quantidade", "Quantidade");
            vendaGrid.Columns.Add("PrecoUnitario", "Preço Unitário");
            vendaGrid.Columns.Add("PrecoTotal", "Preço Total");

            alterdados_panel.Hide();
            AjustarVisibilidadePorCargo();

            LoadClientes();
            LoadProdutos();
        }

        private void AjustarVisibilidadePorCargo()
        {
            if (Cargos.cargo == "Gerente")
            {
                Clientes.TabPages.Remove(gerenciarCliente);
                solicitarEstoque_btn.Visible = true;
            }
            else
            {
                solicitarEstoque_btn.Visible = true;
                produto_save.Visible = true;

                clientesGridView.Visible = true;
                alterdados_panel.Visible = true;
                alter_btn.Visible = true;
                delete_cliente.Visible = true;
            }
        }

        private void cliente_save_Click(object sender, EventArgs e)
        {
            string nome = nomeCliente_txt.Text;
            string email = email_txt.Text;
            string nascimento = nascimento_txt.Value.ToShortDateString();
            string cpf = cpf_txt.Text;
            string endereco = endereco_txt.Text;
            string cidade = cidade_txt.Text;
            string estado = estado_box.Text;

            bool cpfExiste = clientesGridView.Rows.Cast<DataGridViewRow>()
                .Any(row => row.Cells["CPF"].Value?.ToString() == cpf);

            if (cpfExiste)
            {
                MessageBox.Show("O CPF já está cadastrado!");
            }
            else
            {
                clientesGridView.Rows.Add(nome, email, nascimento, cpf, cidade, endereco, estado);
                MessageBox.Show("Cliente cadastrado com sucesso!");

                nomeCliente_txt.Clear();
                email_txt.Clear();
                cpf_txt.Clear();
                endereco_txt.Clear();
                cidade_txt.Clear();
            }
        }

        private void clientesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = clientesGridView.Rows[e.RowIndex];
                clientesGridView.Tag = e.RowIndex;

                alteruser_txt.Text = linhaSelecionada.Cells["Nome"].Value?.ToString() ?? "";
                email_txt1.Text = linhaSelecionada.Cells["Email"].Value?.ToString() ?? "";
                nascimento_txt1.Text = linhaSelecionada.Cells["Nascimento"].Value?.ToString() ?? "";
                cpf_txt1.Text = linhaSelecionada.Cells["CPF"].Value?.ToString() ?? "";
                cidade_txt1.Text = linhaSelecionada.Cells["Cidade"].Value?.ToString() ?? "";
                endereco_txt1.Text = linhaSelecionada.Cells["Endereco"].Value?.ToString() ?? "";
                estado_txt1.Text = linhaSelecionada.Cells["Estado"].Value?.ToString() ?? "";
            }
        }

        private void editSave_btn_Click(object sender, EventArgs e)
        {
            if (clientesGridView.Tag != null)
            {
                int rowIndex = (int)clientesGridView.Tag;

                clientesGridView.Rows[rowIndex].Cells["Nome"].Value = alteruser_txt.Text;
                clientesGridView.Rows[rowIndex].Cells["Email"].Value = email_txt1.Text;
                clientesGridView.Rows[rowIndex].Cells["Nascimento"].Value = nascimento_txt1.Text;
                clientesGridView.Rows[rowIndex].Cells["CPF"].Value = cpf_txt1.Text;
                clientesGridView.Rows[rowIndex].Cells["Cidade"].Value = cidade_txt1.Text;
                clientesGridView.Rows[rowIndex].Cells["Endereco"].Value = endereco_txt1.Text;
                clientesGridView.Rows[rowIndex].Cells["Estado"].Value = estado_txt1.Text;

                MessageBox.Show("Dados atualizados com sucesso!");

                alterdados_panel.Visible = false;
                alter_btn.Show();
                delete_cliente.Show();
            }
        }

        private void produto_save_Click(object sender, EventArgs e)
        {
            var nomeproduto = produtoNome_txt.Text;
            var filial = filial_box.Text;
            var quantidade_prod = quantidade_Int.Value;

            if (!decimal.TryParse(preco_txt.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("pt-BR"), out decimal precoUnitario))
            {
                MessageBox.Show("Valor inválido para preço.");
                return;
            }

            var precoTotal = quantidade_prod * precoUnitario;

            produtosGrid.Rows.Add(nomeproduto, filial, quantidade_prod, $"R$ {precoUnitario:F2}", $"R$ {precoTotal:F2}");
        }

        private void alter_btn_Click(object sender, EventArgs e)
        {
            alter_btn.Hide();
            delete_cliente.Hide();
            alterdados_panel.Show();
        }

        private void delete_cliente_Click(object sender, EventArgs e)
        {
            if (clientesGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in clientesGridView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        clientesGridView.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_produto_btn_Click(object sender, EventArgs e)
        {
            if (produtosGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in produtosGrid.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        produtosGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void solicitarEstoque_btn_Click(object sender, EventArgs e)
        {
            if (produtosGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para solicitar estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lógica de solicitação de estoque
        }

        private void LoadClientes()
        {
            try
            {
                string caminhoClientes = Path.Combine(Directory.GetCurrentDirectory(), "Dados", "clientes.csv");
                if (File.Exists(caminhoClientes))
                {
                    var linhas = File.ReadAllLines(caminhoClientes);
                    foreach (var linha in linhas)
                    {
                        var dados = linha.Split(',');

                        if (dados[0] == "Nome") continue;

                        clientesGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6]);
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de clientes não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void LoadProdutos()
        {
            try
            {
                string caminhoProdutos = Path.Combine(Directory.GetCurrentDirectory(), "Dados", "produtos.csv");
                if (File.Exists(caminhoProdutos))
                {
                    var linhas = File.ReadAllLines(caminhoProdutos);

                    foreach (var linha in linhas)
                    {
                        var dados = linha.Split(',');

                        if (dados[0] == "Nome") continue;

                        decimal precoUnitario = Convert.ToDecimal(dados[3]);
                        decimal precoTotal = precoUnitario * Convert.ToInt32(dados[2]);

                        produtosGrid.Rows.Add(dados[0], dados[1], dados[2], $"R$ {precoUnitario:F2}", $"R$ {precoTotal:F2}");
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de produtos não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void clientevenda_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void produtoVenda_box_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void OnTextChangedDelayed(object sender, EventArgs e)
        {
            timer.Stop();

            // Filtra a ComboBox de clientes
            string textoFiltroCliente = clientevenda.Text;
            clientevenda.Items.Clear();
            foreach (DataGridViewRow row in clientesGridView.Rows)
            {
                string nomeCliente = row.Cells["Nome"].Value?.ToString() ?? string.Empty;
                if (nomeCliente.Contains(textoFiltroCliente, StringComparison.InvariantCultureIgnoreCase))
                {
                    clientevenda.Items.Add(nomeCliente);
                }
            }

            // Filtra a ComboBox de produtos
            string textoFiltroProduto = produtoVenda_box.Text;
            produtoVenda_box.Items.Clear();
            foreach (DataGridViewRow row in produtosGrid.Rows)
            {
                string nomeProduto = row.Cells["Nome"].Value?.ToString() ?? string.Empty;
                if (nomeProduto.Contains(textoFiltroProduto, StringComparison.InvariantCultureIgnoreCase))
                {
                    produtoVenda_box.Items.Add(nomeProduto);
                }
            }
        }

        private void clientevenda_Click(object sender, EventArgs e)
        {
            clientevenda.Text.Replace("Nome", "");
        }

        // Novo método para adicionar a venda
        private void adicionarVenda_Click(object sender, EventArgs e)
        {
            var nomeCliente = clientevenda.Text;
            var nomeProduto = produtoVenda_box.Text;

            // Encontrar o preço do produto selecionado
            var produto = produtosGrid.Rows.Cast<DataGridViewRow>()
                            .FirstOrDefault(r => r.Cells["Nome"].Value?.ToString() == nomeProduto);

            if (produto != null)
            {
                var precoUnitario = Convert.ToDecimal(produto.Cells["PrecoUnitario"].Value.ToString().Replace("R$", "").Trim());
                var quantidade = quantidadeVenda_Int.Value;

                var precoTotal = precoUnitario * quantidade;
                precototallbl.Text = $"R$ {precoTotal:F2}";

                // Adiciona os dados no grid de vendas
                vendaGrid.Rows.Add(nomeCliente, nomeProduto, quantidade, $"R$ {precoUnitario:F2}", $"R$ {precoTotal:F2}");
            }
        }
    }
}
