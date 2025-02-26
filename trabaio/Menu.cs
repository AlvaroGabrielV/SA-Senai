namespace trabaio;

public partial class Menu : Form
{
    public Menu()
    {
        InitializeComponent();
    }

    private void button_login_Click(object sender, EventArgs e)
    {
        if (user_txt.Text == "Caio" && pass_txt.Text == "1234")
        {
            Home inicial = new Home();
            inicial.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Informações de login incorretos");
        }
    }

    private void Menu_Load(object sender, EventArgs e)
    {
        
    }

}