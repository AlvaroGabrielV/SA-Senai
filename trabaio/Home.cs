using System.Globalization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace trabaio;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
    }

    private void Home_Load(object sender, EventArgs e)
    {
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

            // Limpa os campos após a adição
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

            // Armazena o índice da linha selecionada para edição posterior
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

        // Corrige a conversão do preço
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

        DataGridViewRow selectedRow = produtosGrid.SelectedRows[0];
        string produtoNome = selectedRow.Cells["Nome"].Value.ToString();
        string filialAtual = selectedRow.Cells["Filial"].Value.ToString();
        int quantidadeAtual = Convert.ToInt32(selectedRow.Cells["Quantidade"].Value);

        // Verifica se há outra filial com o mesmo produto em estoque
        foreach (DataGridViewRow row in produtosGrid.Rows)
        {
            if (row.Cells["Nome"].Value.ToString() == produtoNome && row.Cells["Filial"].Value.ToString() != filialAtual)
            {
                int quantidadeDisponivel = Convert.ToInt32(row.Cells["Quantidade"].Value);
                if (quantidadeDisponivel > 0)
                {
                    int quantidadeSolicitada = Math.Min(quantidadeDisponivel, 10); // Solicita até 10 unidades por vez
                    row.Cells["Quantidade"].Value = quantidadeDisponivel - quantidadeSolicitada;
                    selectedRow.Cells["Quantidade"].Value = quantidadeAtual + quantidadeSolicitada;
                    MessageBox.Show($"{quantidadeSolicitada} unidades do produto '{produtoNome}' foram transferidas para a filial '{filialAtual}'.", "Transferência de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        MessageBox.Show("Nenhuma filial possui estoque disponível para este produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
