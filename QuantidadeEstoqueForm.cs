using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabaio
{
    public partial class QuantidadeEstoqueForm : Form
    {
        public int QuantidadeSolicitada { get; private set; }
        private string filialOrigem;

        public QuantidadeEstoqueForm(int quantidadeDisponivel, string filialOrigem)
        {
            InitializeComponent();

            // Exibe a quantidade disponível na filial
            quantidadeLabel.Text = $"Quantidade disponível: {quantidadeDisponivel}";
            filialLabel.Text = $"Filial de origem: {filialOrigem}";

            // Define o valor máximo no NumericUpDown com a quantidade disponível
            quantidadeNumericUpDown.Maximum = quantidadeDisponivel;
            this.filialOrigem = filialOrigem;
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            // Captura a quantidade solicitada
            QuantidadeSolicitada = (int)quantidadeNumericUpDown.Value;

            // Fecha o formulário após a confirmação
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            // Fecha o formulário sem realizar a solicitação
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }


}
