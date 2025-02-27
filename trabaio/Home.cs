using System.Globalization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace trabaio
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

            alterdados_panel.Hide();

            LoadClientes();
            LoadProdutos();
        }

        // Método para salvar cliente
        private void cliente_save_Click(object sender, EventArgs e)
        {
            string nome = nomeCliente_txt.Text;
            string email = email_txt.Text;
            string nascimento = nascimento_txt.Value.ToShortDateString();
            string cpf = cpf_txt.Text;
            string endereco = endereco_txt.Text;
            string cidade = cidade_txt.Text;
            string estado = estado_box.Text;

            // Verifica se o CPF já está cadastrado
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

                // Limpa os campos de entrada
                nomeCliente_txt.Clear();
                email_txt.Clear();
                cpf_txt.Clear();
                endereco_txt.Clear();
                cidade_txt.Clear();
            }
        }

        // Método para selecionar cliente e preencher os campos de edição
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

        // Método para salvar as alterações no cliente
        private void editSave_btn_Click(object sender, EventArgs e)
        {
            if (clientesGridView.Tag != null)
            {
                int rowIndex = (int)clientesGridView.Tag;

                // Atualiza os dados do cliente
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

        // Método para salvar produto
        private void produto_save_Click(object sender, EventArgs e)
        {
            var nomeproduto = produtoNome_txt.Text;
            var filial = filial_box.Text;
            var quantidade_prod = quantidade_Int.Value;

            // Corrige a conversão do preço
            if (!decimal.TryParse(preco_txt.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("pt-BR"), out decimal precoUnitario))
            {
                MessageBox.Show("Valor inválido para preço.");
                return;
            }

            var precoTotal = quantidade_prod * precoUnitario;

            // Adiciona produto à grid
            produtosGrid.Rows.Add(nomeproduto, filial, quantidade_prod, $"R$ {precoUnitario:F2}", $"R$ {precoTotal:F2}");
        }

        // Método para mostrar o painel de edição de cliente
        private void alter_btn_Click(object sender, EventArgs e)
        {
            alter_btn.Hide();
            delete_cliente.Hide();
            alterdados_panel.Show();
        }

        // Método para excluir cliente
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

        // Método para excluir produto
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

        // Método para solicitar estoque de produto
        private void solicitarEstoque_btn_Click(object sender, EventArgs e)
        {
            if (produtosGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para solicitar estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = produtosGrid.SelectedRows[0];
            string produtoNome = selectedRow.Cells["Nome"].Value.ToString();
            string filialAtual = selectedRow.Cells["Filial"].Value.ToString();
            int quantidadeAtual = Convert.ToInt32(selectedRow.Cells["Quantidade"].Value);

            // Definindo as distâncias entre as filiais em quilômetros
            Dictionary<string, int> distanciasFiliais = new Dictionary<string, int>
            {
                { "Belo Horizonte", 0 },
                { "Juiz de Fora", 200 },
                { "São Paulo", 500 },
                { "Rio de Janeiro", 300 },
                { "Santa Catarina", 1000 }
            };

            // Filtrando as filiais com o mesmo produto e quantidade disponível
            List<DataGridViewRow> filiaisComProduto = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in produtosGrid.Rows)
            {
                if (row.Cells["Nome"].Value.ToString() == produtoNome && Convert.ToInt32(row.Cells["Quantidade"].Value) > 0)
                {
                    filiaisComProduto.Add(row);
                }
            }

            if (filiaisComProduto.Count == 0)
            {
                MessageBox.Show("Nenhuma filial possui estoque disponível para este produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtra as filiais disponíveis, excluindo a filial atual
            var filiaisDisponiveis = filiaisComProduto
                .Where(row => row.Cells["Filial"].Value.ToString() != filialAtual)
                .OrderBy(row => distanciasFiliais[row.Cells["Filial"].Value.ToString()])
                .ToList();

            if (filiaisDisponiveis.Count > 0)
            {
                // Pega a filial mais próxima com estoque disponível
                DataGridViewRow filialMaisProxima = filiaisDisponiveis.First();
                string filialMaisProximaNome = filialMaisProxima.Cells["Filial"].Value.ToString();
                int quantidadeDisponivel = Convert.ToInt32(filialMaisProxima.Cells["Quantidade"].Value);

                int quantidadeSolicitada = Math.Min(quantidadeDisponivel, 10); // Solicita até 10 unidades por vez

                // Atualiza as quantidades
                filialMaisProxima.Cells["Quantidade"].Value = quantidadeDisponivel - quantidadeSolicitada;
                selectedRow.Cells["Quantidade"].Value = quantidadeAtual + quantidadeSolicitada;

                MessageBox.Show($"{quantidadeSolicitada} unidades do produto '{produtoNome}' foram transferidas da filial '{filialMaisProximaNome}' para a filial '{filialAtual}'.", "Transferência de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma filial com estoque disponível para este produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Carregar clientes a partir do arquivo CSV
        private void LoadClientes()
        {
            try
            {
                string caminhoClientes = @"C:\Users\Aluno_Manha\source\repos\SA-Senai\trabaio\Dados\clientes.csv";
                if (File.Exists(caminhoClientes))
                {
                    var linhas = File.ReadAllLines(caminhoClientes);

                    foreach (var linha in linhas)
                    {
                        var dados = linha.Split(',');

                        // Ignorar a primeira linha que contém os cabeçalhos
                        if (dados[0] == "Nome") continue;

                        // Adicionar cliente à grid
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

        // Carregar produtos a partir do arquivo CSV
        private void LoadProdutos()
        {
            try
            {
                string caminhoProdutos = @"C:\Users\Aluno_Manha\source\repos\SA-Senai\trabaio\Dados\produtos.csv";
                if (File.Exists(caminhoProdutos))
                {
                    var linhas = File.ReadAllLines(caminhoProdutos);

                    foreach (var linha in linhas)
                    {
                        var dados = linha.Split(',');

                        // Ignorar a primeira linha que contém os cabeçalhos
                        if (dados[0] == "Nome") continue;

                        // Calcular o preço total
                        decimal precoUnitario = Convert.ToDecimal(dados[3]);
                        decimal precoTotal = precoUnitario * Convert.ToInt32(dados[2]);

                        // Adicionar produto à grid
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
    }
}
