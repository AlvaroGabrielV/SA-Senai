using System.Windows.Forms;

namespace trabaio
    {
    public class Cargos
    {
        public static string cargo = "Gerente"; // Essa variável armazena o cargo do usuário logado
    }

    public partial class Menu : Form
    {
        public Menu()
        {
                InitializeComponent();
        }

            private void button_login_Click(object sender, EventArgs e)
            {
                if (user_txt.Text == "Gerente" && pass_txt.Text == "2222")
                {
                    Cargos.cargo = "Gerente"; // Define o cargo do usuário logado

                    Home inicial = new Home();
                    inicial.Show();
                    this.Hide();
                }
                else if (user_txt.Text == "Administrador" && pass_txt.Text == "1234")
                {
                    Cargos.cargo = "Administrador"; // Define o cargo do usuário logado
                    Home inicial = new Home();
                    inicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Informações de login incorretas");
                }
            }

            private void Menu_Load(object sender, EventArgs e)
            {
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
            }
        }
    }
