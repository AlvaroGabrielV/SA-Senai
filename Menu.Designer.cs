using System.ComponentModel;

namespace trabaio;

partial class Menu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
        user_txt = new TextBox();
        pass_txt = new TextBox();
        label2 = new Label();
        label3 = new Label();
        button_login = new Button();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // user_txt
        // 
        user_txt.Location = new Point(752, 159);
        user_txt.Margin = new Padding(3, 37, 3, 37);
        user_txt.Name = "user_txt";
        user_txt.Size = new Size(303, 26);
        user_txt.TabIndex = 0;
        // 
        // pass_txt
        // 
        pass_txt.Location = new Point(752, 259);
        pass_txt.Margin = new Padding(3, 37, 3, 37);
        pass_txt.Name = "pass_txt";
        pass_txt.Size = new Size(303, 26);
        pass_txt.TabIndex = 1;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Location = new Point(752, 117);
        label2.Name = "label2";
        label2.RightToLeft = RightToLeft.No;
        label2.Size = new Size(369, 43);
        label2.TabIndex = 2;
        label2.Text = "USUARIO";
        label2.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Location = new Point(752, 231);
        label3.Name = "label3";
        label3.RightToLeft = RightToLeft.No;
        label3.Size = new Size(383, 30);
        label3.TabIndex = 3;
        label3.Text = "SENHA";
        label3.TextAlign = ContentAlignment.BottomLeft;
        // 
        // button_login
        // 
        button_login.BackColor = Color.SandyBrown;
        button_login.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
        button_login.FlatAppearance.BorderSize = 5;
        button_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
        button_login.Location = new Point(806, 369);
        button_login.Margin = new Padding(3, 16, 3, 16);
        button_login.Name = "button_login";
        button_login.Size = new Size(168, 73);
        button_login.TabIndex = 4;
        button_login.Text = "ENTRAR";
        button_login.UseVisualStyleBackColor = false;
        button_login.Click += button_login_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        pictureBox1.Image = Properties.Resources.logosemfundo;
        pictureBox1.Location = new Point(-93, 25);
        pictureBox1.Margin = new Padding(3, 16, 3, 16);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(830, 446);
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Transparent;
        pictureBox2.Image = Properties.Resources.perfil_de_usuario;
        pictureBox2.Location = new Point(690, 138);
        pictureBox2.Margin = new Padding(3, 16, 3, 16);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(56, 56);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 6;
        pictureBox2.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = Color.Transparent;
        pictureBox3.Image = Properties.Resources.trancar;
        pictureBox3.Location = new Point(690, 231);
        pictureBox3.Margin = new Padding(3, 16, 3, 16);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(56, 63);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 7;
        pictureBox3.TabStop = false;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.planodefundohome;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1130, 520);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(button_login);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(pass_txt);
        Controls.Add(user_txt);
        DoubleBuffered = true;
        Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Menu";
        RightToLeft = RightToLeft.No;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Raven Stock";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button button_login;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox user_txt;
    private System.Windows.Forms.TextBox pass_txt;

    #endregion
}