using System.ComponentModel;

namespace trabaio;

partial class Home
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Home));
        Clientes = new TabControl();
        cadastrarCliente = new TabPage();
        label11 = new Label();
        email_txt = new TextBox();
        cpf_txt = new MaskedTextBox();
        nascimento_txt = new DateTimePicker();
        estado_box = new ComboBox();
        label6 = new Label();
        label5 = new Label();
        cidade_txt = new TextBox();
        label4 = new Label();
        cliente_save = new Button();
        label3 = new Label();
        datadenascimento = new Label();
        endereco_txt = new TextBox();
        nome_txt = new Label();
        nomeCliente_txt = new TextBox();
        pictureBox4 = new PictureBox();
        cadastrarProduto = new TabPage();
        solicitarEstoque_btn = new Button();
        delete_produto_btn = new Button();
        produtosGrid = new DataGridView();
        filial_box = new ComboBox();
        quantidade_Int = new NumericUpDown();
        produto_save = new Button();
        label10 = new Label();
        preco_txt = new TextBox();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        produtoNome_txt = new TextBox();
        pictureBox3 = new PictureBox();
        gerenciarCliente = new TabPage();
        alterdados_panel = new Panel();
        cpf_txt1 = new MaskedTextBox();
        editSave_btn = new Button();
        altercpf_label = new Label();
        nascimento_txt1 = new DateTimePicker();
        estado_txt1 = new ComboBox();
        altercidade_label = new Label();
        cidade_txt1 = new TextBox();
        alterestado_label = new Label();
        alteremail_label = new Label();
        email_txt1 = new TextBox();
        alternascimento_label = new Label();
        alterendereco_label = new Label();
        endereco_txt1 = new TextBox();
        alternome_label = new Label();
        alteruser_txt = new TextBox();
        pictureBox2 = new PictureBox();
        clientesGridView = new DataGridView();
        delete_cliente = new Button();
        alter_btn = new Button();
        gerenciarEstoque = new TabPage();
        createVenda_btn = new Button();
        vendaGrid = new DataGridView();
        produtoVenda_box = new ComboBox();
        filialVenda_box = new ComboBox();
        label15 = new Label();
        precototallbl = new Label();
        label13 = new Label();
        label12 = new Label();
        label2 = new Label();
        label1 = new Label();
        clientevenda = new ComboBox();
        button1 = new Button();
        pictureBox1 = new PictureBox();
        quantidadeVenda_Int = new NumericUpDown();
        Clientes.SuspendLayout();
        cadastrarCliente.SuspendLayout();
        ((ISupportInitialize)pictureBox4).BeginInit();
        cadastrarProduto.SuspendLayout();
        ((ISupportInitialize)produtosGrid).BeginInit();
        ((ISupportInitialize)quantidade_Int).BeginInit();
        ((ISupportInitialize)pictureBox3).BeginInit();
        gerenciarCliente.SuspendLayout();
        alterdados_panel.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)clientesGridView).BeginInit();
        gerenciarEstoque.SuspendLayout();
        ((ISupportInitialize)vendaGrid).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)quantidadeVenda_Int).BeginInit();
        SuspendLayout();
        // 
        // Clientes
        // 
        Clientes.Controls.Add(cadastrarCliente);
        Clientes.Controls.Add(cadastrarProduto);
        Clientes.Controls.Add(gerenciarCliente);
        Clientes.Controls.Add(gerenciarEstoque);
        Clientes.Dock = DockStyle.Fill;
        Clientes.Location = new Point(0, 0);
        Clientes.Margin = new Padding(4, 3, 4, 3);
        Clientes.Name = "Clientes";
        Clientes.SelectedIndex = 0;
        Clientes.Size = new Size(1035, 596);
        Clientes.TabIndex = 0;
        // 
        // cadastrarCliente
        // 
        cadastrarCliente.BackgroundImage = Properties.Resources.planodefundohome;
        cadastrarCliente.BackgroundImageLayout = ImageLayout.Zoom;
        cadastrarCliente.Controls.Add(label11);
        cadastrarCliente.Controls.Add(email_txt);
        cadastrarCliente.Controls.Add(cpf_txt);
        cadastrarCliente.Controls.Add(nascimento_txt);
        cadastrarCliente.Controls.Add(estado_box);
        cadastrarCliente.Controls.Add(label6);
        cadastrarCliente.Controls.Add(label5);
        cadastrarCliente.Controls.Add(cidade_txt);
        cadastrarCliente.Controls.Add(label4);
        cadastrarCliente.Controls.Add(cliente_save);
        cadastrarCliente.Controls.Add(label3);
        cadastrarCliente.Controls.Add(datadenascimento);
        cadastrarCliente.Controls.Add(endereco_txt);
        cadastrarCliente.Controls.Add(nome_txt);
        cadastrarCliente.Controls.Add(nomeCliente_txt);
        cadastrarCliente.Controls.Add(pictureBox4);
        cadastrarCliente.Location = new Point(4, 24);
        cadastrarCliente.Margin = new Padding(4, 3, 4, 3);
        cadastrarCliente.Name = "cadastrarCliente";
        cadastrarCliente.Padding = new Padding(6);
        cadastrarCliente.RightToLeft = RightToLeft.No;
        cadastrarCliente.Size = new Size(1027, 568);
        cadastrarCliente.TabIndex = 0;
        cadastrarCliente.Text = "Cadastrar Cliente";
        cadastrarCliente.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label11.Location = new Point(60, 192);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(88, 26);
        label11.TabIndex = 17;
        label11.Text = "Email";
        label11.TextAlign = ContentAlignment.BottomLeft;
        // 
        // email_txt
        // 
        email_txt.Location = new Point(60, 220);
        email_txt.Margin = new Padding(4, 3, 4, 3);
        email_txt.Name = "email_txt";
        email_txt.Size = new Size(266, 23);
        email_txt.TabIndex = 16;
        // 
        // cpf_txt
        // 
        cpf_txt.Culture = new System.Globalization.CultureInfo("en-US");
        cpf_txt.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        cpf_txt.ImeMode = ImeMode.NoControl;
        cpf_txt.InsertKeyMode = InsertKeyMode.Overwrite;
        cpf_txt.Location = new Point(60, 397);
        cpf_txt.Margin = new Padding(4, 3, 4, 3);
        cpf_txt.Mask = "000.000.000-00";
        cpf_txt.Name = "cpf_txt";
        cpf_txt.ResetOnPrompt = false;
        cpf_txt.RightToLeft = RightToLeft.No;
        cpf_txt.Size = new Size(264, 23);
        cpf_txt.TabIndex = 15;
        cpf_txt.TextMaskFormat = MaskFormat.IncludePrompt;
        // 
        // nascimento_txt
        // 
        nascimento_txt.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        nascimento_txt.Format = DateTimePickerFormat.Short;
        nascimento_txt.Location = new Point(60, 317);
        nascimento_txt.Margin = new Padding(4, 3, 4, 3);
        nascimento_txt.Name = "nascimento_txt";
        nascimento_txt.Size = new Size(265, 23);
        nascimento_txt.TabIndex = 14;
        // 
        // estado_box
        // 
        estado_box.DropDownStyle = ComboBoxStyle.DropDownList;
        estado_box.FormattingEnabled = true;
        estado_box.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins", "Distrito Federal" });
        estado_box.Location = new Point(701, 398);
        estado_box.Margin = new Padding(4, 3, 4, 3);
        estado_box.Name = "estado_box";
        estado_box.Size = new Size(265, 23);
        estado_box.TabIndex = 13;
        // 
        // label6
        // 
        label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(701, 369);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(88, 26);
        label6.TabIndex = 12;
        label6.Text = "Estado";
        label6.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label5
        // 
        label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(701, 213);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(88, 26);
        label5.TabIndex = 10;
        label5.Text = "Cidade";
        label5.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cidade_txt
        // 
        cidade_txt.Location = new Point(701, 242);
        cidade_txt.Margin = new Padding(4, 3, 4, 3);
        cidade_txt.Name = "cidade_txt";
        cidade_txt.Size = new Size(266, 23);
        cidade_txt.TabIndex = 9;
        // 
        // label4
        // 
        label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(701, 81);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 26);
        label4.TabIndex = 8;
        label4.Text = "Endereço";
        label4.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cliente_save
        // 
        cliente_save.Anchor = AnchorStyles.Bottom;
        cliente_save.Location = new Point(417, 456);
        cliente_save.Margin = new Padding(4, 3, 4, 3);
        cliente_save.Name = "cliente_save";
        cliente_save.Size = new Size(190, 54);
        cliente_save.TabIndex = 7;
        cliente_save.Text = "Salvar";
        cliente_save.UseVisualStyleBackColor = true;
        cliente_save.Click += cliente_save_Click;
        // 
        // label3
        // 
        label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(60, 366);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(88, 26);
        label3.TabIndex = 6;
        label3.Text = "CPF";
        label3.TextAlign = ContentAlignment.BottomLeft;
        // 
        // datadenascimento
        // 
        datadenascimento.AutoEllipsis = true;
        datadenascimento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        datadenascimento.Location = new Point(60, 288);
        datadenascimento.Margin = new Padding(4, 0, 4, 0);
        datadenascimento.Name = "datadenascimento";
        datadenascimento.Size = new Size(162, 26);
        datadenascimento.TabIndex = 5;
        datadenascimento.Text = "Data de Nascimento";
        datadenascimento.TextAlign = ContentAlignment.BottomLeft;
        // 
        // endereco_txt
        // 
        endereco_txt.Location = new Point(701, 110);
        endereco_txt.Margin = new Padding(4, 3, 4, 3);
        endereco_txt.Name = "endereco_txt";
        endereco_txt.Size = new Size(266, 23);
        endereco_txt.TabIndex = 4;
        // 
        // nome_txt
        // 
        nome_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        nome_txt.Location = new Point(60, 82);
        nome_txt.Margin = new Padding(4, 0, 4, 0);
        nome_txt.Name = "nome_txt";
        nome_txt.Size = new Size(88, 26);
        nome_txt.TabIndex = 3;
        nome_txt.Text = "Nome";
        nome_txt.TextAlign = ContentAlignment.BottomLeft;
        // 
        // nomeCliente_txt
        // 
        nomeCliente_txt.Location = new Point(60, 110);
        nomeCliente_txt.Margin = new Padding(4, 3, 4, 3);
        nomeCliente_txt.Name = "nomeCliente_txt";
        nomeCliente_txt.Size = new Size(266, 23);
        nomeCliente_txt.TabIndex = 0;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.logosemfundo;
        pictureBox4.Location = new Point(332, 110);
        pictureBox4.Margin = new Padding(4, 3, 4, 3);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(397, 300);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 20;
        pictureBox4.TabStop = false;
        // 
        // cadastrarProduto
        // 
        cadastrarProduto.BackgroundImage = Properties.Resources.Sem_nome__1920_x_1080_px_;
        cadastrarProduto.BackgroundImageLayout = ImageLayout.Stretch;
        cadastrarProduto.Controls.Add(solicitarEstoque_btn);
        cadastrarProduto.Controls.Add(delete_produto_btn);
        cadastrarProduto.Controls.Add(produtosGrid);
        cadastrarProduto.Controls.Add(filial_box);
        cadastrarProduto.Controls.Add(quantidade_Int);
        cadastrarProduto.Controls.Add(produto_save);
        cadastrarProduto.Controls.Add(label10);
        cadastrarProduto.Controls.Add(preco_txt);
        cadastrarProduto.Controls.Add(label9);
        cadastrarProduto.Controls.Add(label8);
        cadastrarProduto.Controls.Add(label7);
        cadastrarProduto.Controls.Add(produtoNome_txt);
        cadastrarProduto.Controls.Add(pictureBox3);
        cadastrarProduto.Location = new Point(4, 24);
        cadastrarProduto.Margin = new Padding(4, 3, 4, 3);
        cadastrarProduto.Name = "cadastrarProduto";
        cadastrarProduto.Padding = new Padding(4, 3, 4, 3);
        cadastrarProduto.Size = new Size(1027, 568);
        cadastrarProduto.TabIndex = 1;
        cadastrarProduto.Text = "Cadastrar Produto";
        cadastrarProduto.UseVisualStyleBackColor = true;
        // 
        // solicitarEstoque_btn
        // 
        solicitarEstoque_btn.Location = new Point(603, 583);
        solicitarEstoque_btn.Margin = new Padding(4, 3, 4, 3);
        solicitarEstoque_btn.Name = "solicitarEstoque_btn";
        solicitarEstoque_btn.Size = new Size(161, 61);
        solicitarEstoque_btn.TabIndex = 18;
        solicitarEstoque_btn.Text = "Solicitar Estoque";
        solicitarEstoque_btn.UseVisualStyleBackColor = true;
        solicitarEstoque_btn.Click += solicitarEstoque_btn_Click;
        // 
        // delete_produto_btn
        // 
        delete_produto_btn.Anchor = AnchorStyles.Bottom;
        delete_produto_btn.Location = new Point(273, 495);
        delete_produto_btn.Margin = new Padding(4, 3, 4, 3);
        delete_produto_btn.Name = "delete_produto_btn";
        delete_produto_btn.Size = new Size(172, 45);
        delete_produto_btn.TabIndex = 17;
        delete_produto_btn.Text = "Apagar";
        delete_produto_btn.UseVisualStyleBackColor = true;
        delete_produto_btn.Click += delete_produto_btn_Click;
        // 
        // produtosGrid
        // 
        produtosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        produtosGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        produtosGrid.BackgroundColor = Color.FromArgb(255, 224, 192);
        produtosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        produtosGrid.GridColor = Color.FromArgb(0, 0, 64);
        produtosGrid.Location = new Point(8, 6);
        produtosGrid.Margin = new Padding(4, 3, 4, 3);
        produtosGrid.Name = "produtosGrid";
        produtosGrid.ReadOnly = true;
        produtosGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        produtosGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        produtosGrid.Size = new Size(1012, 319);
        produtosGrid.TabIndex = 15;
        // 
        // filial_box
        // 
        filial_box.DropDownStyle = ComboBoxStyle.DropDownList;
        filial_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        filial_box.FormattingEnabled = true;
        filial_box.Items.AddRange(new object[] { "Filial - Belo Horizonte", "Filial - Juiz de Fora", "Filial - São Paulo", "Filial - Rio de Janeiro", "Filial - Santa Catarina" });
        filial_box.Location = new Point(6, 422);
        filial_box.Margin = new Padding(4, 3, 4, 3);
        filial_box.Name = "filial_box";
        filial_box.Size = new Size(222, 33);
        filial_box.TabIndex = 14;
        // 
        // quantidade_Int
        // 
        quantidade_Int.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        quantidade_Int.Location = new Point(281, 366);
        quantidade_Int.Margin = new Padding(4, 3, 4, 3);
        quantidade_Int.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        quantidade_Int.Name = "quantidade_Int";
        quantidade_Int.Size = new Size(186, 29);
        quantidade_Int.TabIndex = 13;
        quantidade_Int.TextAlign = HorizontalAlignment.Center;
        // 
        // produto_save
        // 
        produto_save.Anchor = AnchorStyles.Bottom;
        produto_save.Location = new Point(33, 495);
        produto_save.Margin = new Padding(4, 3, 4, 3);
        produto_save.Name = "produto_save";
        produto_save.Size = new Size(172, 45);
        produto_save.TabIndex = 12;
        produto_save.Text = "Salvar";
        produto_save.UseVisualStyleBackColor = true;
        produto_save.Click += produto_save_Click;
        // 
        // label10
        // 
        label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label10.Location = new Point(281, 406);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(164, 19);
        label10.TabIndex = 11;
        label10.Text = "Preço Unitario";
        label10.TextAlign = ContentAlignment.BottomLeft;
        // 
        // preco_txt
        // 
        preco_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        preco_txt.Location = new Point(281, 424);
        preco_txt.Margin = new Padding(4, 3, 4, 3);
        preco_txt.Name = "preco_txt";
        preco_txt.Size = new Size(185, 33);
        preco_txt.TabIndex = 10;
        // 
        // label9
        // 
        label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label9.Location = new Point(281, 325);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(119, 38);
        label9.TabIndex = 9;
        label9.Text = "Quantidade";
        label9.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label8
        // 
        label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label8.Location = new Point(6, 394);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(88, 26);
        label8.TabIndex = 7;
        label8.Text = "Filial";
        label8.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label7
        // 
        label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.Location = new Point(6, 334);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(160, 26);
        label7.TabIndex = 5;
        label7.Text = "Nome do produto";
        label7.TextAlign = ContentAlignment.BottomLeft;
        // 
        // produtoNome_txt
        // 
        produtoNome_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        produtoNome_txt.Location = new Point(6, 362);
        produtoNome_txt.Margin = new Padding(4, 3, 4, 3);
        produtoNome_txt.Name = "produtoNome_txt";
        produtoNome_txt.Size = new Size(222, 33);
        produtoNome_txt.TabIndex = 4;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.logosemfundo;
        pictureBox3.Location = new Point(570, 314);
        pictureBox3.Margin = new Padding(4, 3, 4, 3);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(411, 263);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 19;
        pictureBox3.TabStop = false;
        // 
        // gerenciarCliente
        // 
        gerenciarCliente.BackgroundImage = Properties.Resources.bakcgroudclin;
        gerenciarCliente.BackgroundImageLayout = ImageLayout.Zoom;
        gerenciarCliente.Controls.Add(alterdados_panel);
        gerenciarCliente.Controls.Add(clientesGridView);
        gerenciarCliente.Controls.Add(delete_cliente);
        gerenciarCliente.Controls.Add(alter_btn);
        gerenciarCliente.Location = new Point(4, 24);
        gerenciarCliente.Margin = new Padding(4, 3, 4, 3);
        gerenciarCliente.Name = "gerenciarCliente";
        gerenciarCliente.Padding = new Padding(4, 3, 4, 3);
        gerenciarCliente.Size = new Size(1027, 568);
        gerenciarCliente.TabIndex = 2;
        gerenciarCliente.Text = "Gerenciar Clientes";
        gerenciarCliente.UseVisualStyleBackColor = true;
        // 
        // alterdados_panel
        // 
        alterdados_panel.BackgroundImageLayout = ImageLayout.Stretch;
        alterdados_panel.Controls.Add(cpf_txt1);
        alterdados_panel.Controls.Add(editSave_btn);
        alterdados_panel.Controls.Add(altercpf_label);
        alterdados_panel.Controls.Add(nascimento_txt1);
        alterdados_panel.Controls.Add(estado_txt1);
        alterdados_panel.Controls.Add(altercidade_label);
        alterdados_panel.Controls.Add(cidade_txt1);
        alterdados_panel.Controls.Add(alterestado_label);
        alterdados_panel.Controls.Add(alteremail_label);
        alterdados_panel.Controls.Add(email_txt1);
        alterdados_panel.Controls.Add(alternascimento_label);
        alterdados_panel.Controls.Add(alterendereco_label);
        alterdados_panel.Controls.Add(endereco_txt1);
        alterdados_panel.Controls.Add(alternome_label);
        alterdados_panel.Controls.Add(alteruser_txt);
        alterdados_panel.Controls.Add(pictureBox2);
        alterdados_panel.Location = new Point(0, 307);
        alterdados_panel.Margin = new Padding(4, 3, 4, 3);
        alterdados_panel.Name = "alterdados_panel";
        alterdados_panel.Size = new Size(1119, 238);
        alterdados_panel.TabIndex = 23;
        // 
        // cpf_txt1
        // 
        cpf_txt1.Culture = new System.Globalization.CultureInfo("en-US");
        cpf_txt1.Location = new Point(416, 110);
        cpf_txt1.Margin = new Padding(4, 3, 4, 3);
        cpf_txt1.Mask = "000.000.000-00";
        cpf_txt1.Name = "cpf_txt1";
        cpf_txt1.Size = new Size(228, 23);
        cpf_txt1.TabIndex = 20;
        // 
        // editSave_btn
        // 
        editSave_btn.Location = new Point(410, 144);
        editSave_btn.Margin = new Padding(4, 3, 4, 3);
        editSave_btn.Name = "editSave_btn";
        editSave_btn.Size = new Size(233, 51);
        editSave_btn.TabIndex = 19;
        editSave_btn.Text = "SALVAR";
        editSave_btn.UseVisualStyleBackColor = true;
        // 
        // altercpf_label
        // 
        altercpf_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        altercpf_label.ImageAlign = ContentAlignment.BottomLeft;
        altercpf_label.Location = new Point(416, 85);
        altercpf_label.Margin = new Padding(4, 0, 4, 0);
        altercpf_label.Name = "altercpf_label";
        altercpf_label.Size = new Size(102, 25);
        altercpf_label.TabIndex = 18;
        altercpf_label.Text = "CPF";
        altercpf_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // nascimento_txt1
        // 
        nascimento_txt1.Format = DateTimePickerFormat.Short;
        nascimento_txt1.Location = new Point(6, 170);
        nascimento_txt1.Margin = new Padding(4, 3, 4, 3);
        nascimento_txt1.Name = "nascimento_txt1";
        nascimento_txt1.Size = new Size(232, 23);
        nascimento_txt1.TabIndex = 15;
        // 
        // estado_txt1
        // 
        estado_txt1.DropDownStyle = ComboBoxStyle.DropDownList;
        estado_txt1.FormattingEnabled = true;
        estado_txt1.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins", "Distrito Federal" });
        estado_txt1.Location = new Point(743, 154);
        estado_txt1.Margin = new Padding(4, 3, 4, 3);
        estado_txt1.Name = "estado_txt1";
        estado_txt1.Size = new Size(256, 23);
        estado_txt1.TabIndex = 14;
        // 
        // altercidade_label
        // 
        altercidade_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        altercidade_label.ImageAlign = ContentAlignment.BottomLeft;
        altercidade_label.Location = new Point(743, 73);
        altercidade_label.Margin = new Padding(4, 0, 4, 0);
        altercidade_label.Name = "altercidade_label";
        altercidade_label.Size = new Size(102, 25);
        altercidade_label.TabIndex = 12;
        altercidade_label.Text = "CIDADE";
        altercidade_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cidade_txt1
        // 
        cidade_txt1.Location = new Point(743, 99);
        cidade_txt1.Margin = new Padding(4, 3, 4, 3);
        cidade_txt1.Name = "cidade_txt1";
        cidade_txt1.Size = new Size(256, 23);
        cidade_txt1.TabIndex = 11;
        // 
        // alterestado_label
        // 
        alterestado_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alterestado_label.ImageAlign = ContentAlignment.BottomLeft;
        alterestado_label.Location = new Point(743, 126);
        alterestado_label.Margin = new Padding(4, 0, 4, 0);
        alterestado_label.Name = "alterestado_label";
        alterestado_label.Size = new Size(102, 25);
        alterestado_label.TabIndex = 10;
        alterestado_label.Text = "ESTADO";
        alterestado_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // alteremail_label
        // 
        alteremail_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alteremail_label.ImageAlign = ContentAlignment.BottomLeft;
        alteremail_label.Location = new Point(6, 73);
        alteremail_label.Margin = new Padding(4, 0, 4, 0);
        alteremail_label.Name = "alteremail_label";
        alteremail_label.Size = new Size(59, 25);
        alteremail_label.TabIndex = 8;
        alteremail_label.Text = "EMAIL";
        alteremail_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // email_txt1
        // 
        email_txt1.Location = new Point(6, 99);
        email_txt1.Margin = new Padding(4, 3, 4, 3);
        email_txt1.Name = "email_txt1";
        email_txt1.Size = new Size(232, 23);
        email_txt1.TabIndex = 7;
        // 
        // alternascimento_label
        // 
        alternascimento_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alternascimento_label.ImageAlign = ContentAlignment.BottomLeft;
        alternascimento_label.Location = new Point(6, 142);
        alternascimento_label.Margin = new Padding(4, 0, 4, 0);
        alternascimento_label.Name = "alternascimento_label";
        alternascimento_label.Size = new Size(210, 25);
        alternascimento_label.TabIndex = 6;
        alternascimento_label.Text = "DATA DE NASCIMENTO";
        alternascimento_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // alterendereco_label
        // 
        alterendereco_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alterendereco_label.ImageAlign = ContentAlignment.BottomLeft;
        alterendereco_label.Location = new Point(743, 14);
        alterendereco_label.Margin = new Padding(4, 0, 4, 0);
        alterendereco_label.Name = "alterendereco_label";
        alterendereco_label.Size = new Size(212, 25);
        alterendereco_label.TabIndex = 4;
        alterendereco_label.Text = "ENDEREÇO";
        alterendereco_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // endereco_txt1
        // 
        endereco_txt1.Location = new Point(743, 40);
        endereco_txt1.Margin = new Padding(4, 3, 4, 3);
        endereco_txt1.Name = "endereco_txt1";
        endereco_txt1.Size = new Size(256, 23);
        endereco_txt1.TabIndex = 3;
        // 
        // alternome_label
        // 
        alternome_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alternome_label.ImageAlign = ContentAlignment.BottomLeft;
        alternome_label.Location = new Point(6, 14);
        alternome_label.Margin = new Padding(4, 0, 4, 0);
        alternome_label.Name = "alternome_label";
        alternome_label.Size = new Size(102, 25);
        alternome_label.TabIndex = 2;
        alternome_label.Text = "NOME";
        alternome_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // alteruser_txt
        // 
        alteruser_txt.Location = new Point(6, 40);
        alteruser_txt.Margin = new Padding(4, 3, 4, 3);
        alteruser_txt.Name = "alteruser_txt";
        alteruser_txt.Size = new Size(232, 23);
        alteruser_txt.TabIndex = 1;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.logosemfundo;
        pictureBox2.Location = new Point(372, -34);
        pictureBox2.Margin = new Padding(4, 3, 4, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(257, 152);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 21;
        pictureBox2.TabStop = false;
        // 
        // clientesGridView
        // 
        clientesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        clientesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        clientesGridView.BackgroundColor = Color.FromArgb(255, 224, 192);
        clientesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        clientesGridView.GridColor = Color.FromArgb(0, 0, 64);
        clientesGridView.Location = new Point(8, 6);
        clientesGridView.Margin = new Padding(4, 3, 4, 3);
        clientesGridView.Name = "clientesGridView";
        clientesGridView.ReadOnly = true;
        clientesGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        clientesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        clientesGridView.Size = new Size(1001, 291);
        clientesGridView.TabIndex = 0;
        clientesGridView.CellClick += clientesGridView_CellClick;
        // 
        // delete_cliente
        // 
        delete_cliente.Location = new Point(688, 303);
        delete_cliente.Margin = new Padding(4, 3, 4, 3);
        delete_cliente.Name = "delete_cliente";
        delete_cliente.Size = new Size(230, 53);
        delete_cliente.TabIndex = 22;
        delete_cliente.Text = "APAGAR CLIENTE";
        delete_cliente.UseVisualStyleBackColor = true;
        delete_cliente.Click += delete_cliente_Click;
        // 
        // alter_btn
        // 
        alter_btn.Location = new Point(225, 303);
        alter_btn.Margin = new Padding(4, 3, 4, 3);
        alter_btn.Name = "alter_btn";
        alter_btn.Size = new Size(230, 53);
        alter_btn.TabIndex = 21;
        alter_btn.Text = "ALTERAR DADOS";
        alter_btn.UseVisualStyleBackColor = true;
        alter_btn.Click += alter_btn_Click;
        // 
        // gerenciarEstoque
        // 
        gerenciarEstoque.BackgroundImage = Properties.Resources.bakcgroudclin;
        gerenciarEstoque.Controls.Add(quantidadeVenda_Int);
        gerenciarEstoque.Controls.Add(createVenda_btn);
        gerenciarEstoque.Controls.Add(vendaGrid);
        gerenciarEstoque.Controls.Add(produtoVenda_box);
        gerenciarEstoque.Controls.Add(filialVenda_box);
        gerenciarEstoque.Controls.Add(label15);
        gerenciarEstoque.Controls.Add(precototallbl);
        gerenciarEstoque.Controls.Add(label13);
        gerenciarEstoque.Controls.Add(label12);
        gerenciarEstoque.Controls.Add(label2);
        gerenciarEstoque.Controls.Add(label1);
        gerenciarEstoque.Controls.Add(clientevenda);
        gerenciarEstoque.Controls.Add(button1);
        gerenciarEstoque.Controls.Add(pictureBox1);
        gerenciarEstoque.Location = new Point(4, 24);
        gerenciarEstoque.Margin = new Padding(4, 3, 4, 3);
        gerenciarEstoque.Name = "gerenciarEstoque";
        gerenciarEstoque.Padding = new Padding(4, 3, 4, 3);
        gerenciarEstoque.Size = new Size(1027, 568);
        gerenciarEstoque.TabIndex = 3;
        gerenciarEstoque.Text = "Gerenciar Vendas";
        gerenciarEstoque.UseVisualStyleBackColor = true;
        // 
        // createVenda_btn
        // 
        createVenda_btn.Location = new Point(836, 397);
        createVenda_btn.Margin = new Padding(2);
        createVenda_btn.Name = "createVenda_btn";
        createVenda_btn.Size = new Size(166, 56);
        createVenda_btn.TabIndex = 18;
        createVenda_btn.Text = "Criar Venda";
        createVenda_btn.UseVisualStyleBackColor = true;
        createVenda_btn.Click += adicionarVenda_Click;
        // 
        // vendaGrid
        // 
        vendaGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        vendaGrid.BackgroundColor = Color.FromArgb(255, 192, 128);
        vendaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        vendaGrid.Location = new Point(16, 19);
        vendaGrid.Margin = new Padding(2);
        vendaGrid.Name = "vendaGrid";
        vendaGrid.RowHeadersWidth = 62;
        vendaGrid.Size = new Size(1004, 308);
        vendaGrid.StandardTab = true;
        vendaGrid.TabIndex = 17;
        // 
        // produtoVenda_box
        // 
        produtoVenda_box.Font = new Font("Segoe UI", 12F);
        produtoVenda_box.FormattingEnabled = true;
        produtoVenda_box.Location = new Point(36, 456);
        produtoVenda_box.Margin = new Padding(2);
        produtoVenda_box.Name = "produtoVenda_box";
        produtoVenda_box.Size = new Size(222, 29);
        produtoVenda_box.TabIndex = 16;
        produtoVenda_box.TextChanged += produtoVenda_box_TextChanged;
        // 
        // filialVenda_box
        // 
        filialVenda_box.Font = new Font("Segoe UI", 12F);
        filialVenda_box.FormattingEnabled = true;
        filialVenda_box.Items.AddRange(new object[] { "Filial - Belo Horizonte", "Filial - Juiz de Fora", "Filial - São Paulo", "Filial - Rio de Janeiro", "Filial - Santa Catarina" });
        filialVenda_box.Location = new Point(311, 456);
        filialVenda_box.Margin = new Padding(2);
        filialVenda_box.Name = "filialVenda_box";
        filialVenda_box.Size = new Size(222, 29);
        filialVenda_box.TabIndex = 15;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label15.Location = new Point(663, 368);
        label15.Margin = new Padding(2, 0, 2, 0);
        label15.Name = "label15";
        label15.Size = new Size(65, 32);
        label15.TabIndex = 13;
        label15.Text = "Total";
        // 
        // precototallbl
        // 
        precototallbl.AutoSize = true;
        precototallbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        precototallbl.Location = new Point(663, 427);
        precototallbl.Margin = new Padding(2, 0, 2, 0);
        precototallbl.Name = "precototallbl";
        precototallbl.Size = new Size(27, 32);
        precototallbl.TabIndex = 12;
        precototallbl.Text = "0";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label13.Location = new Point(36, 431);
        label13.Margin = new Padding(2, 0, 2, 0);
        label13.Name = "label13";
        label13.Size = new Size(80, 25);
        label13.TabIndex = 11;
        label13.Text = "Produto";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label12.Location = new Point(311, 431);
        label12.Margin = new Padding(2, 0, 2, 0);
        label12.Name = "label12";
        label12.Size = new Size(51, 25);
        label12.TabIndex = 10;
        label12.Text = "Filial";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(311, 346);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(111, 25);
        label2.TabIndex = 9;
        label2.Text = "Quantidade";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(36, 346);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(71, 25);
        label1.TabIndex = 8;
        label1.Text = "Cliente";
        // 
        // clientevenda
        // 
        clientevenda.Font = new Font("Segoe UI", 12F);
        clientevenda.FormattingEnabled = true;
        clientevenda.Location = new Point(36, 370);
        clientevenda.Margin = new Padding(2);
        clientevenda.Name = "clientevenda";
        clientevenda.Size = new Size(222, 29);
        clientevenda.TabIndex = 4;
        clientevenda.Text = "Nome";
        clientevenda.TextChanged += clientevenda_TextChanged;
        clientevenda.Click += clientevenda_Click;
        // 
        // button1
        // 
        button1.Location = new Point(98, 598);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(214, 47);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logosemfundo;
        pictureBox1.Location = new Point(1072, -35);
        pictureBox1.Margin = new Padding(4, 3, 4, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(163, 179);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 19;
        pictureBox1.TabStop = false;
        // 
        // quantidadeVenda_Int
        // 
        quantidadeVenda_Int.BorderStyle = BorderStyle.FixedSingle;
        quantidadeVenda_Int.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        quantidadeVenda_Int.Location = new Point(311, 370);
        quantidadeVenda_Int.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        quantidadeVenda_Int.Name = "quantidadeVenda_Int";
        quantidadeVenda_Int.Size = new Size(128, 29);
        quantidadeVenda_Int.TabIndex = 20;
        quantidadeVenda_Int.TextAlign = HorizontalAlignment.Center;
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(1035, 596);
        Controls.Add(Clientes);
        DoubleBuffered = true;
        ForeColor = SystemColors.ControlText;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Location = new Point(15, 15);
        Margin = new Padding(4, 3, 4, 3);
        MinimumSize = new Size(960, 451);
        Name = "Home";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Raven Stock";
        Load += Home_Load;
        Clientes.ResumeLayout(false);
        cadastrarCliente.ResumeLayout(false);
        cadastrarCliente.PerformLayout();
        ((ISupportInitialize)pictureBox4).EndInit();
        cadastrarProduto.ResumeLayout(false);
        cadastrarProduto.PerformLayout();
        ((ISupportInitialize)produtosGrid).EndInit();
        ((ISupportInitialize)quantidade_Int).EndInit();
        ((ISupportInitialize)pictureBox3).EndInit();
        gerenciarCliente.ResumeLayout(false);
        alterdados_panel.ResumeLayout(false);
        alterdados_panel.PerformLayout();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)clientesGridView).EndInit();
        gerenciarEstoque.ResumeLayout(false);
        gerenciarEstoque.PerformLayout();
        ((ISupportInitialize)vendaGrid).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)quantidadeVenda_Int).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label datadenascimento;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.DataGridView produtosGrid;

    private System.Windows.Forms.ComboBox filial_box;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TabPage gerenciarEstoque;

    private System.Windows.Forms.MaskedTextBox cpf_txt1;

    private System.Windows.Forms.Label altercpf_label;

    private System.Windows.Forms.Button editSave_btn;

    private System.Windows.Forms.DateTimePicker nascimento_txt1;

    private System.Windows.Forms.Label alterendereco_label;
    private System.Windows.Forms.TextBox endereco_txt1;
    private System.Windows.Forms.Label alternascimento_label;
    private System.Windows.Forms.Label alteremail_label;
    private System.Windows.Forms.TextBox email_txt1;
    private System.Windows.Forms.Label alterestado_label;
    private System.Windows.Forms.Label altercidade_label;
    private System.Windows.Forms.TextBox cidade_txt1;
    private System.Windows.Forms.ComboBox estado_txt1;

    private System.Windows.Forms.TextBox alteruser_txt;
    private System.Windows.Forms.Label alternome_label;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox email_txt;

    private System.Windows.Forms.DataGridView clientesGridView;

    private System.Windows.Forms.NumericUpDown quantidade_Int;

    private System.Windows.Forms.MaskedTextBox cpf_txt;

    private System.Windows.Forms.DateTimePicker nascimento_txt;

    private System.Windows.Forms.Button produto_save;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox produtoNome_txt;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox preco_txt;

    private System.Windows.Forms.ComboBox estado_box;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox cidade_txt;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox endereco_txt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button cliente_save;

    private System.Windows.Forms.TextBox nomeCliente_txt;
    private System.Windows.Forms.Label nome_txt;

    private System.Windows.Forms.TabPage gerenciarCliente;

    private System.Windows.Forms.TabControl Clientes;
    private System.Windows.Forms.TabPage cadastrarCliente;
    private System.Windows.Forms.TabPage cadastrarProduto;


    #endregion

    private Button alter_btn;
    private Button delete_cliente;
    private Panel alterdados_panel;
    private PictureBox pictureBox2;
    private Button delete_produto_btn;
    private Button solicitarEstoque_btn;
    private DataGridView dataGridView1;
    private Label label13;
    private Label label12;
    private Label label2;
    private Label label1;
    private ComboBox comboBox4;
    private ComboBox comboBox3;
    private ComboBox comboBox2;
    private ComboBox clientevenda;
    private Label label15;
    private Label precototallbl;
    private DataGridView vendaGrid;
    private ComboBox produtoVenda_box;
    private ComboBox filialVenda_box;
    private ComboBox quantidade_Box;
    private Button createVenda_btn;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private NumericUpDown numericUpDown1;
    private NumericUpDown quantidadeVenda_Int;
}