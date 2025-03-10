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
            timer = new System.Windows.Forms.Timer
            {
                Interval = 500 // 500ms de atraso
            };
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Configurações para as grid views de clientes e produtos
            ConfigurarGridClientes();
            ConfigurarGridProdutos();
            ConfigurarGridVendas();

            alterdados_panel.Hide();
            AjustarVisibilidadePorCargo();

            LoadClientes();
            LoadProdutos();
        }

        private void ConfigurarGridClientes()
        {
            clientesGridView.Columns.Add("Nome", "Nomes");
            clientesGridView.Columns.Add("Email", "Email");
            clientesGridView.Columns.Add("Nascimento", "Data Nascimento");
            clientesGridView.Columns.Add("CPF", "CPF");
            clientesGridView.Columns.Add("Cidade", "Cidade");
            clientesGridView.Columns.Add("Endereco", "Endereço");
            clientesGridView.Columns.Add("Estado", "Estado");
        }

        private void ConfigurarGridProdutos()
        {
            produtosGrid.Columns.Add("Nome", "Produtos");
            produtosGrid.Columns.Add("Filial", "Filial");
            produtosGrid.Columns.Add("Quantidade", "Quantidade");
            produtosGrid.Columns.Add("PrecoUnitario", "Preço Unitário");
            produtosGrid.Columns.Add("PrecoTotal", "Preço Total");
        }

        private void ConfigurarGridVendas()
        {
            vendaGrid.Columns.Add("Cliente", "Cliente");
            vendaGrid.Columns.Add("Produto", "Produto");
            vendaGrid.Columns.Add("Quantidade", "Quantidade");
            vendaGrid.Columns.Add("PrecoUnitario", "Preço Unitário");
            vendaGrid.Columns.Add("PrecoTotal", "Preço Total");
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
                alter_btn.Visible = true;  // Manter visibilidade do alter_btn
                delete_cliente.Visible = true;
            }
        }

        private void cliente_save_Click(object sender, EventArgs e)
        {
            string cpf = cpf_txt.Text;

            if (CpfExiste(cpf))
            {
                MessageBox.Show("O CPF já está cadastrado!");
                return;
            }

            AdicionarCliente();
        }

        private bool CpfExiste(string cpf)
        {
            return clientesGridView.Rows.Cast<DataGridViewRow>()
                .Any(row => row.Cells["CPF"].Value?.ToString() == cpf);
        }

        private void AdicionarCliente()
        {
            string nome = nomeCliente_txt.Text;
            string email = email_txt.Text;
            string nascimento = nascimento_txt.Value.ToShortDateString();
            string cpf = cpf_txt.Text;
            string endereco = endereco_txt.Text;
            string cidade = cidade_txt.Text;
            string estado = estado_box.Text;

            clientesGridView.Rows.Add(nome, email, nascimento, cpf, cidade, endereco, estado);
            MessageBox.Show("Cliente cadastrado com sucesso!");

            LimparCamposCliente();
        }

        private void LimparCamposCliente()
        {
            nomeCliente_txt.Clear();
            email_txt.Clear();
            cpf_txt.Clear();
            endereco_txt.Clear();
            cidade_txt.Clear();
        }

        private void clientesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PreencherCamposAlteracaoCliente(e.RowIndex);
            }
        }

        private void PreencherCamposAlteracaoCliente(int rowIndex)
        {
            var linhaSelecionada = clientesGridView.Rows[rowIndex];

            alteruser_txt.Text = linhaSelecionada.Cells["Nome"].Value?.ToString() ?? "";
            email_txt1.Text = linhaSelecionada.Cells["Email"].Value?.ToString() ?? "";
            nascimento_txt1.Text = linhaSelecionada.Cells["Nascimento"].Value?.ToString() ?? "";
            cpf_txt1.Text = linhaSelecionada.Cells["CPF"].Value?.ToString() ?? "";
            cidade_txt1.Text = linhaSelecionada.Cells["Cidade"].Value?.ToString() ?? "";
            endereco_txt1.Text = linhaSelecionada.Cells["Endereco"].Value?.ToString() ?? "";
            estado_txt1.Text = linhaSelecionada.Cells["Estado"].Value?.ToString() ?? "";
            clientesGridView.Tag = rowIndex;
        }

        private void editSave_btn_Click(object sender, EventArgs e)
        {
            if (clientesGridView.Tag != null)
            {
                AtualizarCliente((int)clientesGridView.Tag);
            }
        }

        private void AtualizarCliente(int rowIndex)
        {
            clientesGridView.Rows[rowIndex].Cells["Nome"].Value = alteruser_txt.Text;
            clientesGridView.Rows[rowIndex].Cells["Email"].Value = email_txt1.Text;
            clientesGridView.Rows[rowIndex].Cells["Nascimento"].Value = nascimento_txt1.Text;
            clientesGridView.Rows[rowIndex].Cells["CPF"].Value = cpf_txt1.Text;
            clientesGridView.Rows[rowIndex].Cells["Cidade"].Value = cidade_txt1.Text;
            clientesGridView.Rows[rowIndex].Cells["Endereco"].Value = endereco_txt1.Text;
            clientesGridView.Rows[rowIndex].Cells["Estado"].Value = estado_txt1.Text;

            MessageBox.Show("Dados atualizados com sucesso!");
            alterdados_panel.Visible = false;
            alter_btn.Show();  // Manter o botão de alteração visível
            delete_cliente.Show();
        }

        private void alter_btn_Click(object sender, EventArgs e)
        {
            alter_btn.Hide();
            delete_cliente.Hide();
            alterdados_panel.Show();
        }

        private void produto_save_Click(object sender, EventArgs e)
        {
            AdicionarProduto();
        }

        private void AdicionarProduto()
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

        private void delete_cliente_Click(object sender, EventArgs e)
        {
            ExcluirSelecionados(clientesGridView);
        }

        private void delete_produto_btn_Click(object sender, EventArgs e)
        {
            ExcluirSelecionados(produtosGrid);
        }

        private void ExcluirSelecionados(DataGridView grid)
        {
            if (grid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        grid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static class ProximidadeFiliais
        {
            public static readonly Dictionary<string, Dictionary<string, int>> Proximidade = new Dictionary<string, Dictionary<string, int>>()
            {
                { "Rio de Janeiro", new Dictionary<string, int> { { "Juiz de Fora", 1 }, { "São Paulo", 2 }, { "Belo Horizonte", 1 }, { "Santa Catarina", 3 } } },
                { "Juiz de Fora", new Dictionary<string, int> { { "Rio de Janeiro", 1 }, { "São Paulo", 2 }, { "Belo Horizonte", 1 }, { "Santa Catarina", 3 } } },
                { "São Paulo", new Dictionary<string, int> { { "Juiz de Fora", 2 }, { "Rio de Janeiro", 2 }, { "Belo Horizonte", 2 }, { "Santa Catarina", 2 } } },
                { "Belo Horizonte", new Dictionary<string, int> { { "Juiz de Fora", 1 }, { "Rio de Janeiro", 1 }, { "São Paulo", 2 }, { "Santa Catarina", 2 } } },
                { "Santa Catarina", new Dictionary<string, int> { { "Juiz de Fora", 3 }, { "Rio de Janeiro", 3 }, { "São Paulo", 2 }, { "Belo Horizonte", 2 } } }
            };

            public static string FilialMaisProxima(string cidadeOrigem)
            {
                if (!Proximidade.ContainsKey(cidadeOrigem))
                {
                    return null;
                }

                var cidadesProximas = Proximidade[cidadeOrigem];
                return cidadesProximas.OrderBy(x => x.Value).FirstOrDefault().Key;
            }
        }

        private void solicitarEstoque_btn_Click(object sender, EventArgs e)
        {
            if (produtosGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para solicitar estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var produtoSelecionado = produtosGrid.SelectedRows[0];
            var nomeProdutoSelecionado = produtoSelecionado.Cells["Nome"].Value?.ToString();
            var filialSelecionada = produtoSelecionado.Cells["Filial"].Value?.ToString();
            var quantidadeDisponivelSelecionada = Convert.ToInt32(produtoSelecionado.Cells["Quantidade"].Value);

            if (quantidadeDisponivelSelecionada > 0)
            {
                MessageBox.Show("O estoque da filial selecionada já está disponível. Não é necessário solicitar mais estoque.");
                return;
            }

            bool estoqueDisponivelEmOutraFilial = false;
            int quantidadeDisponivelEmOutraFilial = 0;
            string filialMaisProxima = string.Empty;

            Console.WriteLine("Iniciando busca por estoque em outras filiais...");

            foreach (DataGridViewRow row in produtosGrid.Rows)
            {
                if (row.Cells["Nome"].Value?.ToString() == nomeProdutoSelecionado && row.Cells["Filial"].Value?.ToString() == filialSelecionada)
                {
                    continue;  // Ignora a linha que é da filial atual
                }

                // Verificando se a filial tem estoque e se não é a filial selecionada
                string cidadeFilialAtual = row.Cells["Filial"].Value?.ToString();
                int quantidadeAtual = Convert.ToInt32(row.Cells["Quantidade"].Value);

                if (row.Cells["Nome"].Value?.ToString() == nomeProdutoSelecionado && quantidadeAtual > 0)
                {
                    string filialProxima = ProximidadeFiliais.FilialMaisProxima(filialSelecionada);

                    Console.WriteLine($"Filial mais próxima de {filialSelecionada} é {filialProxima}");

                    // Garantir que a comparação seja feita corretamente, considerando se as cidades são iguais
                    if (cidadeFilialAtual != filialSelecionada && cidadeFilialAtual == filialProxima)
                    {
                        estoqueDisponivelEmOutraFilial = true;
                        quantidadeDisponivelEmOutraFilial = quantidadeAtual;
                        filialMaisProxima = cidadeFilialAtual;
                        break;  // Encontrou uma filial com estoque, então sai do loop
                    }
                }
            }

            if (!estoqueDisponivelEmOutraFilial)
            {
                MessageBox.Show("Não há estoque disponível em outras filiais para este produto.");
                return;
            }

            QuantidadeEstoqueForm quantidadeForm = new QuantidadeEstoqueForm(quantidadeDisponivelEmOutraFilial, filialMaisProxima);
            DialogResult result = quantidadeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int quantidadeSolicitada = quantidadeForm.QuantidadeSolicitada;

                if (quantidadeSolicitada > quantidadeDisponivelEmOutraFilial)
                {
                    MessageBox.Show($"Não há estoque suficiente. Estoque disponível: {quantidadeDisponivelEmOutraFilial}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                produtoSelecionado.Cells["Quantidade"].Value = quantidadeSolicitada;
                produtoSelecionado.Cells["Filial"].Value = filialSelecionada;

                // Atualizando a quantidade de estoque na filial que possui o produto
                foreach (DataGridViewRow row in produtosGrid.Rows)
                {
                    if (row.Cells["Nome"].Value?.ToString() == nomeProdutoSelecionado &&
                        row.Cells["Filial"].Value?.ToString() == filialMaisProxima)
                    {
                        row.Cells["Quantidade"].Value = Convert.ToInt32(row.Cells["Quantidade"].Value) - quantidadeSolicitada;
                        break;
                    }
                }

                MessageBox.Show($"Estoque solicitado com sucesso! {quantidadeSolicitada} unidades transferidas da filial {filialMaisProxima}.");
            }
        }

        private void LoadClientes()
        {
            CarregarDados("clientes.csv", clientesGridView);
        }

        private void LoadProdutos()
        {
            CarregarDados("produtos.csv", produtosGrid);
        }

        private void CarregarDados(string arquivo, DataGridView grid)
        {
            try
            {
                string caminho = Path.Combine(Directory.GetCurrentDirectory(), "Dados", arquivo);
                if (File.Exists(caminho))
                {
                    var linhas = File.ReadAllLines(caminho);
                    foreach (var linha in linhas)
                    {
                        var dados = linha.Split(',');
                        if (dados[0] == "Nome") continue;
                        grid.Rows.Add(dados);
                    }
                }
                else
                {
                    MessageBox.Show($"Arquivo de {arquivo} não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
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
            FiltrarCombos();
        }

        private void FiltrarCombos()
        {
            FiltrarCombo(clientevenda, clientesGridView, "Nome");
            FiltrarCombo(produtoVenda_box, produtosGrid, "Nome");
        }

        private void FiltrarCombo(ComboBox combo, DataGridView grid, string columnName)
        {
            string textoFiltro = combo.Text;
            combo.Items.Clear();
            foreach (DataGridViewRow row in grid.Rows)
            {
                string item = row.Cells[columnName].Value?.ToString() ?? string.Empty;
                if (item.Contains(textoFiltro, StringComparison.InvariantCultureIgnoreCase))
                {
                    combo.Items.Add(item);
                }
            }
        }

        private void clientevenda_Click(object sender, EventArgs e)
        {
            clientevenda.Text = clientevenda.Text.Replace("Nome", "");
        }

        private void adicionarVenda_Click(object sender, EventArgs e)
        {
            var nomeCliente = clientevenda.Text;
            var nomeProduto = produtoVenda_box.Text;

            if (string.IsNullOrEmpty(nomeCliente) || string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Selecione um cliente e um produto antes de adicionar a venda.");
                return;
            }

            var produto = produtosGrid.Rows.Cast<DataGridViewRow>()
                                .FirstOrDefault(r => r.Cells["Nome"].Value?.ToString() == nomeProduto);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado.");
                return;
            }

            var quantidadeDisponivel = Convert.ToInt32(produto.Cells["Quantidade"].Value);
            var quantidadeVendida = quantidadeVenda_Int.Value;

            if (quantidadeVendida > quantidadeDisponivel)
            {
                MessageBox.Show($"Quantidade solicitada excede a quantidade disponível. Estoque disponível: {quantidadeDisponivel}.");
                return;
            }

            produto.Cells["Quantidade"].Value = quantidadeDisponivel - quantidadeVendida;

            var precoUnitario = Convert.ToDecimal(produto.Cells["PrecoUnitario"].Value.ToString().Replace("R$", "").Trim());
            var precoTotal = precoUnitario * quantidadeVendida;
            precototallbl.Text = $"R$ {precoTotal:F2}";

            vendaGrid.Rows.Add(nomeCliente, nomeProduto, quantidadeVendida, $"R$ {precoUnitario:F2}", $"R$ {precoTotal:F2}");

            MessageBox.Show("Venda adicionada com sucesso!");

            clientevenda.SelectedIndex = -1;
            produtoVenda_box.SelectedIndex = -1;
            quantidadeVenda_Int.Value = 1;
        }
    }
}
