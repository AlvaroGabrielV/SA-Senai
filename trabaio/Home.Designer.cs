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
        pictureBox1 = new PictureBox();
        gerenciarCliente = new TabPage();
        alterdados_panel = new Panel();
        pictureBox2 = new PictureBox();
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
        altertitulo_label = new Label();
        clientesGridView = new DataGridView();
        delete_cliente = new Button();
        alter_btn = new Button();
        gerenciarEstoque = new TabPage();
        button1 = new Button();
        Clientes.SuspendLayout();
        cadastrarCliente.SuspendLayout();
        cadastrarProduto.SuspendLayout();
        ((ISupportInitialize)produtosGrid).BeginInit();
        ((ISupportInitialize)quantidade_Int).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        gerenciarCliente.SuspendLayout();
        alterdados_panel.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)clientesGridView).BeginInit();
        gerenciarEstoque.SuspendLayout();
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
        Clientes.Name = "Clientes";
        Clientes.SelectedIndex = 0;
        Clientes.Size = new Size(1221, 711);
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
        cadastrarCliente.Location = new Point(4, 24);
        cadastrarCliente.Name = "cadastrarCliente";
        cadastrarCliente.Padding = new Padding(6);
        cadastrarCliente.RightToLeft = RightToLeft.No;
        cadastrarCliente.Size = new Size(1213, 683);
        cadastrarCliente.TabIndex = 0;
        cadastrarCliente.Text = "Cadastrar Cliente";
        cadastrarCliente.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label11.Location = new Point(60, 192);
        label11.Name = "label11";
        label11.Size = new Size(87, 26);
        label11.TabIndex = 17;
        label11.Text = "Email";
        label11.TextAlign = ContentAlignment.BottomLeft;
        // 
        // email_txt
        // 
        email_txt.Location = new Point(60, 220);
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
        nascimento_txt.Location = new Point(59, 317);
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
        estado_box.Name = "estado_box";
        estado_box.Size = new Size(265, 23);
        estado_box.TabIndex = 13;
        // 
        // label6
        // 
        label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(701, 369);
        label6.Name = "label6";
        label6.Size = new Size(87, 26);
        label6.TabIndex = 12;
        label6.Text = "Estado";
        label6.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label5
        // 
        label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(701, 213);
        label5.Name = "label5";
        label5.Size = new Size(87, 26);
        label5.TabIndex = 10;
        label5.Text = "Cidade";
        label5.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cidade_txt
        // 
        cidade_txt.Location = new Point(701, 242);
        cidade_txt.Name = "cidade_txt";
        cidade_txt.Size = new Size(266, 23);
        cidade_txt.TabIndex = 9;
        // 
        // label4
        // 
        label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(701, 81);
        label4.Name = "label4";
        label4.Size = new Size(87, 26);
        label4.TabIndex = 8;
        label4.Text = "Endereço";
        label4.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cliente_save
        // 
        cliente_save.Anchor = AnchorStyles.Bottom;
        cliente_save.Location = new Point(466, 575);
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
        label3.Name = "label3";
        label3.Size = new Size(87, 26);
        label3.TabIndex = 6;
        label3.Text = "CPF";
        label3.TextAlign = ContentAlignment.BottomLeft;
        // 
        // datadenascimento
        // 
        datadenascimento.AutoEllipsis = true;
        datadenascimento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        datadenascimento.Location = new Point(59, 288);
        datadenascimento.Name = "datadenascimento";
        datadenascimento.Size = new Size(162, 26);
        datadenascimento.TabIndex = 5;
        datadenascimento.Text = "Data de Nascimento";
        datadenascimento.TextAlign = ContentAlignment.BottomLeft;
        // 
        // endereco_txt
        // 
        endereco_txt.Location = new Point(701, 110);
        endereco_txt.Name = "endereco_txt";
        endereco_txt.Size = new Size(266, 23);
        endereco_txt.TabIndex = 4;
        // 
        // nome_txt
        // 
        nome_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        nome_txt.Location = new Point(60, 82);
        nome_txt.Name = "nome_txt";
        nome_txt.Size = new Size(87, 26);
        nome_txt.TabIndex = 3;
        nome_txt.Text = "Nome";
        nome_txt.TextAlign = ContentAlignment.BottomLeft;
        // 
        // nomeCliente_txt
        // 
        nomeCliente_txt.Location = new Point(60, 110);
        nomeCliente_txt.Name = "nomeCliente_txt";
        nomeCliente_txt.Size = new Size(266, 23);
        nomeCliente_txt.TabIndex = 0;
        // 
        // cadastrarProduto
        // 
        cadastrarProduto.BackgroundImage = Properties.Resources.Sem_nome__1920_x_1080_px_;
        cadastrarProduto.BackgroundImageLayout = ImageLayout.Zoom;
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
        cadastrarProduto.Controls.Add(pictureBox1);
        cadastrarProduto.Location = new Point(4, 24);
        cadastrarProduto.Name = "cadastrarProduto";
        cadastrarProduto.Padding = new Padding(3);
        cadastrarProduto.Size = new Size(1213, 683);
        cadastrarProduto.TabIndex = 1;
        cadastrarProduto.Text = "Cadastrar Produto";
        cadastrarProduto.UseVisualStyleBackColor = true;
        // 
        // solicitarEstoque_btn
        // 
        solicitarEstoque_btn.Location = new Point(635, 583);
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
        delete_produto_btn.Location = new Point(323, 583);
        delete_produto_btn.Name = "delete_produto_btn";
        delete_produto_btn.Size = new Size(209, 61);
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
        produtosGrid.Name = "produtosGrid";
        produtosGrid.ReadOnly = true;
        produtosGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        produtosGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        produtosGrid.Size = new Size(1191, 319);
        produtosGrid.TabIndex = 15;
        // 
        // filial_box
        // 
        filial_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        filial_box.FormattingEnabled = true;
        filial_box.Items.AddRange(new object[] { "Filial - Belo Horizonte", "Filial - Juiz de Fora", "Filial - São Paulo", "Filial - Rio de Janeiro", "Filial - Santa Catarina" });
        filial_box.Location = new Point(8, 495);
        filial_box.Name = "filial_box";
        filial_box.Size = new Size(222, 33);
        filial_box.TabIndex = 14;
        // 
        // quantidade_Int
        // 
        quantidade_Int.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        quantidade_Int.Location = new Point(333, 409);
        quantidade_Int.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        quantidade_Int.Name = "quantidade_Int";
        quantidade_Int.Size = new Size(185, 29);
        quantidade_Int.TabIndex = 13;
        quantidade_Int.TextAlign = HorizontalAlignment.Center;
        // 
        // produto_save
        // 
        produto_save.Anchor = AnchorStyles.Bottom;
        produto_save.Location = new Point(33, 583);
        produto_save.Name = "produto_save";
        produto_save.Size = new Size(209, 61);
        produto_save.TabIndex = 12;
        produto_save.Text = "Salvar";
        produto_save.UseVisualStyleBackColor = true;
        produto_save.Click += produto_save_Click;
        // 
        // label10
        // 
        label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label10.Location = new Point(333, 477);
        label10.Name = "label10";
        label10.Size = new Size(165, 19);
        label10.TabIndex = 11;
        label10.Text = "Preço Unitario";
        label10.TextAlign = ContentAlignment.BottomLeft;
        // 
        // preco_txt
        // 
        preco_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        preco_txt.Location = new Point(333, 495);
        preco_txt.Name = "preco_txt";
        preco_txt.Size = new Size(185, 33);
        preco_txt.TabIndex = 10;
        // 
        // label9
        // 
        label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label9.Location = new Point(333, 368);
        label9.Name = "label9";
        label9.Size = new Size(119, 38);
        label9.TabIndex = 9;
        label9.Text = "Quantidade";
        label9.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label8
        // 
        label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label8.Location = new Point(8, 466);
        label8.Name = "label8";
        label8.Size = new Size(87, 26);
        label8.TabIndex = 7;
        label8.Text = "Filial";
        label8.TextAlign = ContentAlignment.BottomLeft;
        // 
        // label7
        // 
        label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.Location = new Point(8, 376);
        label7.Name = "label7";
        label7.Size = new Size(160, 26);
        label7.TabIndex = 5;
        label7.Text = "Nome do produto";
        label7.TextAlign = ContentAlignment.BottomLeft;
        // 
        // produtoNome_txt
        // 
        produtoNome_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        produtoNome_txt.Location = new Point(8, 405);
        produtoNome_txt.Name = "produtoNome_txt";
        produtoNome_txt.Size = new Size(222, 33);
        produtoNome_txt.TabIndex = 4;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logosemfundo;
        pictureBox1.Location = new Point(635, 256);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(602, 535);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 16;
        pictureBox1.TabStop = false;
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
        gerenciarCliente.Name = "gerenciarCliente";
        gerenciarCliente.Padding = new Padding(3);
        gerenciarCliente.Size = new Size(1213, 683);
        gerenciarCliente.TabIndex = 2;
        gerenciarCliente.Text = "Gerenciar Clientes";
        gerenciarCliente.UseVisualStyleBackColor = true;
        // 
        // alterdados_panel
        // 
        alterdados_panel.BackgroundImageLayout = ImageLayout.Stretch;
        alterdados_panel.Controls.Add(pictureBox2);
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
        alterdados_panel.Controls.Add(altertitulo_label);
        alterdados_panel.Location = new Point(6, 342);
        alterdados_panel.Name = "alterdados_panel";
        alterdados_panel.Size = new Size(1185, 338);
        alterdados_panel.TabIndex = 23;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(703, 84);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(99, 66);
        pictureBox2.TabIndex = 21;
        pictureBox2.TabStop = false;
        // 
        // cpf_txt1
        // 
        cpf_txt1.Culture = new System.Globalization.CultureInfo("en-US");
        cpf_txt1.Location = new Point(417, 160);
        cpf_txt1.Mask = "000.000.000-00";
        cpf_txt1.Name = "cpf_txt1";
        cpf_txt1.Size = new Size(342, 23);
        cpf_txt1.TabIndex = 20;
        // 
        // editSave_btn
        // 
        editSave_btn.Location = new Point(475, 250);
        editSave_btn.Name = "editSave_btn";
        editSave_btn.Size = new Size(233, 51);
        editSave_btn.TabIndex = 19;
        editSave_btn.Text = "SALVAR";
        editSave_btn.UseVisualStyleBackColor = true;
        editSave_btn.Click += editSave_btn_Click;
        // 
        // altercpf_label
        // 
        altercpf_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        altercpf_label.ImageAlign = ContentAlignment.BottomLeft;
        altercpf_label.Location = new Point(417, 134);
        altercpf_label.Name = "altercpf_label";
        altercpf_label.Size = new Size(102, 25);
        altercpf_label.TabIndex = 18;
        altercpf_label.Text = "CPF";
        altercpf_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // nascimento_txt1
        // 
        nascimento_txt1.Format = DateTimePickerFormat.Short;
        nascimento_txt1.Location = new Point(6, 278);
        nascimento_txt1.Name = "nascimento_txt1";
        nascimento_txt1.Size = new Size(337, 23);
        nascimento_txt1.TabIndex = 15;
        // 
        // estado_txt1
        // 
        estado_txt1.DropDownStyle = ComboBoxStyle.DropDownList;
        estado_txt1.FormattingEnabled = true;
        estado_txt1.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins", "Distrito Federal" });
        estado_txt1.Location = new Point(827, 278);
        estado_txt1.Name = "estado_txt1";
        estado_txt1.Size = new Size(342, 23);
        estado_txt1.TabIndex = 14;
        // 
        // altercidade_label
        // 
        altercidade_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        altercidade_label.ImageAlign = ContentAlignment.BottomLeft;
        altercidade_label.Location = new Point(827, 134);
        altercidade_label.Name = "altercidade_label";
        altercidade_label.Size = new Size(102, 25);
        altercidade_label.TabIndex = 12;
        altercidade_label.Text = "CIDADE";
        altercidade_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // cidade_txt1
        // 
        cidade_txt1.Location = new Point(827, 160);
        cidade_txt1.Name = "cidade_txt1";
        cidade_txt1.Size = new Size(342, 23);
        cidade_txt1.TabIndex = 11;
        // 
        // alterestado_label
        // 
        alterestado_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alterestado_label.ImageAlign = ContentAlignment.BottomLeft;
        alterestado_label.Location = new Point(827, 250);
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
        alteremail_label.Location = new Point(6, 134);
        alteremail_label.Name = "alteremail_label";
        alteremail_label.Size = new Size(102, 25);
        alteremail_label.TabIndex = 8;
        alteremail_label.Text = "EMAIL";
        alteremail_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // email_txt1
        // 
        email_txt1.Location = new Point(6, 160);
        email_txt1.Name = "email_txt1";
        email_txt1.Size = new Size(342, 23);
        email_txt1.TabIndex = 7;
        // 
        // alternascimento_label
        // 
        alternascimento_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alternascimento_label.ImageAlign = ContentAlignment.BottomLeft;
        alternascimento_label.Location = new Point(1, 250);
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
        alterendereco_label.Location = new Point(827, 14);
        alterendereco_label.Name = "alterendereco_label";
        alterendereco_label.Size = new Size(212, 25);
        alterendereco_label.TabIndex = 4;
        alterendereco_label.Text = "ENDEREÇO";
        alterendereco_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // endereco_txt1
        // 
        endereco_txt1.Location = new Point(827, 40);
        endereco_txt1.Name = "endereco_txt1";
        endereco_txt1.Size = new Size(342, 23);
        endereco_txt1.TabIndex = 3;
        // 
        // alternome_label
        // 
        alternome_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        alternome_label.ImageAlign = ContentAlignment.BottomLeft;
        alternome_label.Location = new Point(6, 14);
        alternome_label.Name = "alternome_label";
        alternome_label.Size = new Size(102, 25);
        alternome_label.TabIndex = 2;
        alternome_label.Text = "NOME";
        alternome_label.TextAlign = ContentAlignment.BottomLeft;
        // 
        // alteruser_txt
        // 
        alteruser_txt.Location = new Point(6, 40);
        alteruser_txt.Name = "alteruser_txt";
        alteruser_txt.Size = new Size(342, 23);
        alteruser_txt.TabIndex = 1;
        // 
        // altertitulo_label
        // 
        altertitulo_label.Font = new Font("MS Reference Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
        altertitulo_label.Location = new Point(398, 6);
        altertitulo_label.Name = "altertitulo_label";
        altertitulo_label.Size = new Size(370, 76);
        altertitulo_label.TabIndex = 16;
        altertitulo_label.Text = "Alterar Dados";
        // 
        // clientesGridView
        // 
        clientesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        clientesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        clientesGridView.BackgroundColor = Color.FromArgb(255, 224, 192);
        clientesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        clientesGridView.GridColor = Color.FromArgb(0, 0, 64);
        clientesGridView.Location = new Point(8, 6);
        clientesGridView.Name = "clientesGridView";
        clientesGridView.ReadOnly = true;
        clientesGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        clientesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        clientesGridView.Size = new Size(1197, 291);
        clientesGridView.TabIndex = 0;
        clientesGridView.CellClick += clientesGridView_CellClick;
        // 
        // delete_cliente
        // 
        delete_cliente.Location = new Point(688, 303);
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
        alter_btn.Name = "alter_btn";
        alter_btn.Size = new Size(230, 53);
        alter_btn.TabIndex = 21;
        alter_btn.Text = "ALTERAR DADOS";
        alter_btn.UseVisualStyleBackColor = true;
        alter_btn.Click += alter_btn_Click;
        // 
        // gerenciarEstoque
        // 
        gerenciarEstoque.Controls.Add(button1);
        gerenciarEstoque.Location = new Point(4, 24);
        gerenciarEstoque.Name = "gerenciarEstoque";
        gerenciarEstoque.Padding = new Padding(3);
        gerenciarEstoque.Size = new Size(1213, 683);
        gerenciarEstoque.TabIndex = 3;
        gerenciarEstoque.Text = "Gerenciar Vendas";
        gerenciarEstoque.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(98, 598);
        button1.Name = "button1";
        button1.Size = new Size(213, 47);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Zoom;
        ClientSize = new Size(1221, 711);
        Controls.Add(Clientes);
        DoubleBuffered = true;
        ForeColor = SystemColors.ControlText;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Location = new Point(15, 15);
        MinimumSize = new Size(1030, 750);
        Name = "Home";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Raven Stock";
        Load += Home_Load;
        Clientes.ResumeLayout(false);
        cadastrarCliente.ResumeLayout(false);
        cadastrarCliente.PerformLayout();
        cadastrarProduto.ResumeLayout(false);
        cadastrarProduto.PerformLayout();
        ((ISupportInitialize)produtosGrid).EndInit();
        ((ISupportInitialize)quantidade_Int).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        gerenciarCliente.ResumeLayout(false);
        alterdados_panel.ResumeLayout(false);
        alterdados_panel.PerformLayout();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)clientesGridView).EndInit();
        gerenciarEstoque.ResumeLayout(false);
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
    

    private System.Windows.Forms.Label altertitulo_label;

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
}