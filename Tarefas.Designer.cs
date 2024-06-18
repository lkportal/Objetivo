namespace MetasObjetivos {
    partial class Tarefas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.concluida = new System.Windows.Forms.Label();
            this.LabelPontosstatic = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.comboDificuldade = new System.Windows.Forms.ComboBox();
            this.labelDificuldade = new System.Windows.Forms.Label();
            this.dataPrazo = new System.Windows.Forms.DateTimePicker();
            this.labelPrazo = new System.Windows.Forms.Label();
            this.txtAdicionaCategoria = new System.Windows.Forms.TextBox();
            this.labelAdicionaCategoria = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.btnInserirTarefa = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.picture = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.Tarefa = new System.Windows.Forms.TabPage();
            this.btnRemoveCategoria = new System.Windows.Forms.Button();
            this.btnAdicionaCategoria = new System.Windows.Forms.Button();
            this.AdicionaTarefas = new System.Windows.Forms.Label();
            this.detalhe = new System.Windows.Forms.TabPage();
            this.listaTarefas = new System.Windows.Forms.DataGridView();
            this.labelAndamento = new System.Windows.Forms.Label();
            this.emAndamento = new System.Windows.Forms.Label();
            this.labelPontos = new System.Windows.Forms.Label();
            this.labelConcluidas = new System.Windows.Forms.Label();
            this.labelTotalTarefas = new System.Windows.Forms.Label();
            this.config = new System.Windows.Forms.TabPage();
            this.oBJETIVOS_METASDataSet = new MetasObjetivos.OBJETIVOS_METASDataSet();
            this.tAREFASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAREFASTableAdapter = new MetasObjetivos.OBJETIVOS_METASDataSetTableAdapters.TAREFASTableAdapter();
            this.tAREFASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nome_tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasRestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.Tarefa.SuspendLayout();
            this.detalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJETIVOS_METASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(340, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUsuario.Location = new System.Drawing.Point(8, 43);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 24);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuário:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.Color.DarkRed;
            this.labelN.Location = new System.Drawing.Point(632, 43);
            this.labelN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(52, 24);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(351, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rank";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(5, 291);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(118, 24);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Tarefas";
            // 
            // concluida
            // 
            this.concluida.AutoSize = true;
            this.concluida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concluida.ForeColor = System.Drawing.Color.DarkRed;
            this.concluida.Location = new System.Drawing.Point(152, 291);
            this.concluida.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.concluida.Name = "concluida";
            this.concluida.Size = new System.Drawing.Size(104, 24);
            this.concluida.TabIndex = 6;
            this.concluida.Text = "Concluidas";
            // 
            // LabelPontosstatic
            // 
            this.LabelPontosstatic.AutoSize = true;
            this.LabelPontosstatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPontosstatic.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelPontosstatic.Location = new System.Drawing.Point(618, 291);
            this.LabelPontosstatic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPontosstatic.Name = "LabelPontosstatic";
            this.LabelPontosstatic.Size = new System.Drawing.Size(68, 24);
            this.LabelPontosstatic.TabIndex = 7;
            this.LabelPontosstatic.Text = "Pontos";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(6, 142);
            this.txtTitulo.MaxLength = 20;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(238, 31);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(22, 214);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(238, 140);
            this.txtDescricao.TabIndex = 10;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(3, 121);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(46, 16);
            this.titulo.TabIndex = 11;
            this.titulo.Text = "Titulo";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(2, 187);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(79, 16);
            this.descricao.TabIndex = 12;
            this.descricao.Text = "Descrição";
            // 
            // comboDificuldade
            // 
            this.comboDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDificuldade.FormattingEnabled = true;
            this.comboDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil",
            " "});
            this.comboDificuldade.Location = new System.Drawing.Point(336, 140);
            this.comboDificuldade.Name = "comboDificuldade";
            this.comboDificuldade.Size = new System.Drawing.Size(144, 33);
            this.comboDificuldade.TabIndex = 13;
            this.comboDificuldade.SelectedIndexChanged += new System.EventHandler(this.comboDificuldade_SelectedIndexChanged);
            // 
            // labelDificuldade
            // 
            this.labelDificuldade.AutoSize = true;
            this.labelDificuldade.Location = new System.Drawing.Point(332, 121);
            this.labelDificuldade.Name = "labelDificuldade";
            this.labelDificuldade.Size = new System.Drawing.Size(87, 16);
            this.labelDificuldade.TabIndex = 14;
            this.labelDificuldade.Text = "Dificuldade";
            // 
            // dataPrazo
            // 
            this.dataPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPrazo.Location = new System.Drawing.Point(337, 217);
            this.dataPrazo.Name = "dataPrazo";
            this.dataPrazo.Size = new System.Drawing.Size(143, 22);
            this.dataPrazo.TabIndex = 15;
            this.dataPrazo.Enter += new System.EventHandler(this.dataPrazo_Enter);
            // 
            // labelPrazo
            // 
            this.labelPrazo.AutoSize = true;
            this.labelPrazo.Location = new System.Drawing.Point(334, 187);
            this.labelPrazo.Name = "labelPrazo";
            this.labelPrazo.Size = new System.Drawing.Size(81, 16);
            this.labelPrazo.TabIndex = 16;
            this.labelPrazo.Text = "Data Final";
            // 
            // txtAdicionaCategoria
            // 
            this.txtAdicionaCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAdicionaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionaCategoria.Location = new System.Drawing.Point(570, 370);
            this.txtAdicionaCategoria.MaxLength = 20;
            this.txtAdicionaCategoria.Name = "txtAdicionaCategoria";
            this.txtAdicionaCategoria.Size = new System.Drawing.Size(238, 31);
            this.txtAdicionaCategoria.TabIndex = 17;
            // 
            // labelAdicionaCategoria
            // 
            this.labelAdicionaCategoria.AutoSize = true;
            this.labelAdicionaCategoria.Location = new System.Drawing.Point(567, 349);
            this.labelAdicionaCategoria.Name = "labelAdicionaCategoria";
            this.labelAdicionaCategoria.Size = new System.Drawing.Size(144, 16);
            this.labelAdicionaCategoria.TabIndex = 18;
            this.labelAdicionaCategoria.Text = "Adiciona Categoria";
            // 
            // categoria
            // 
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "estudar",
            "comprar"});
            this.categoria.Location = new System.Drawing.Point(335, 313);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(144, 33);
            this.categoria.TabIndex = 19;
            this.categoria.SelectedIndexChanged += new System.EventHandler(this.categoria_SelectedIndexChanged);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(334, 281);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(153, 16);
            this.labelCategoria.TabIndex = 20;
            this.labelCategoria.Text = "Seleciona Categoria";
            // 
            // btnInserirTarefa
            // 
            this.btnInserirTarefa.Location = new System.Drawing.Point(361, 395);
            this.btnInserirTarefa.Name = "btnInserirTarefa";
            this.btnInserirTarefa.Size = new System.Drawing.Size(97, 38);
            this.btnInserirTarefa.TabIndex = 21;
            this.btnInserirTarefa.Text = "Adicionar";
            this.btnInserirTarefa.UseVisualStyleBackColor = true;
            this.btnInserirTarefa.Click += new System.EventHandler(this.btnInserirTarefa_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Tarefa);
            this.tabControl1.Controls.Add(this.detalhe);
            this.tabControl1.Controls.Add(this.config);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 496);
            this.tabControl1.TabIndex = 22;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.picture);
            this.Home.Controls.Add(this.labelNick);
            this.Home.Controls.Add(this.labelNivel);
            this.Home.Controls.Add(this.labelNome);
            this.Home.Controls.Add(this.labelUsuario);
            this.Home.Controls.Add(this.labelN);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(827, 467);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(277, 142);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(203, 196);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(95, 47);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(0, 16);
            this.labelNick.TabIndex = 7;
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(692, 47);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(0, 16);
            this.labelNivel.TabIndex = 6;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(95, 47);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 16);
            this.labelNome.TabIndex = 5;
            // 
            // Tarefa
            // 
            this.Tarefa.Controls.Add(this.btnRemoveCategoria);
            this.Tarefa.Controls.Add(this.btnAdicionaCategoria);
            this.Tarefa.Controls.Add(this.AdicionaTarefas);
            this.Tarefa.Controls.Add(this.titulo);
            this.Tarefa.Controls.Add(this.txtTitulo);
            this.Tarefa.Controls.Add(this.btnInserirTarefa);
            this.Tarefa.Controls.Add(this.descricao);
            this.Tarefa.Controls.Add(this.txtDescricao);
            this.Tarefa.Controls.Add(this.comboDificuldade);
            this.Tarefa.Controls.Add(this.labelDificuldade);
            this.Tarefa.Controls.Add(this.txtAdicionaCategoria);
            this.Tarefa.Controls.Add(this.labelAdicionaCategoria);
            this.Tarefa.Controls.Add(this.categoria);
            this.Tarefa.Controls.Add(this.labelCategoria);
            this.Tarefa.Controls.Add(this.labelPrazo);
            this.Tarefa.Controls.Add(this.dataPrazo);
            this.Tarefa.Location = new System.Drawing.Point(4, 27);
            this.Tarefa.Name = "Tarefa";
            this.Tarefa.Padding = new System.Windows.Forms.Padding(3);
            this.Tarefa.Size = new System.Drawing.Size(827, 465);
            this.Tarefa.TabIndex = 1;
            this.Tarefa.Text = "Tarefas";
            this.Tarefa.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategoria
            // 
            this.btnRemoveCategoria.AutoSize = true;
            this.btnRemoveCategoria.Location = new System.Drawing.Point(716, 407);
            this.btnRemoveCategoria.Name = "btnRemoveCategoria";
            this.btnRemoveCategoria.Size = new System.Drawing.Size(92, 28);
            this.btnRemoveCategoria.TabIndex = 24;
            this.btnRemoveCategoria.Text = "Remover";
            this.btnRemoveCategoria.UseVisualStyleBackColor = true;
            this.btnRemoveCategoria.Click += new System.EventHandler(this.btnRemoveCategoria_Click);
            // 
            // btnAdicionaCategoria
            // 
            this.btnAdicionaCategoria.AutoSize = true;
            this.btnAdicionaCategoria.Location = new System.Drawing.Point(570, 407);
            this.btnAdicionaCategoria.Name = "btnAdicionaCategoria";
            this.btnAdicionaCategoria.Size = new System.Drawing.Size(87, 28);
            this.btnAdicionaCategoria.TabIndex = 23;
            this.btnAdicionaCategoria.Text = "adicionar";
            this.btnAdicionaCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionaCategoria.Click += new System.EventHandler(this.btnAdicionaCategoria_Click);
            // 
            // AdicionaTarefas
            // 
            this.AdicionaTarefas.AutoSize = true;
            this.AdicionaTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionaTarefas.Location = new System.Drawing.Point(298, 29);
            this.AdicionaTarefas.Name = "AdicionaTarefas";
            this.AdicionaTarefas.Size = new System.Drawing.Size(239, 25);
            this.AdicionaTarefas.TabIndex = 22;
            this.AdicionaTarefas.Text = "Adiciona Nova Tarefa";
            // 
            // detalhe
            // 
            this.detalhe.Controls.Add(this.listaTarefas);
            this.detalhe.Controls.Add(this.labelAndamento);
            this.detalhe.Controls.Add(this.emAndamento);
            this.detalhe.Controls.Add(this.labelPontos);
            this.detalhe.Controls.Add(this.labelConcluidas);
            this.detalhe.Controls.Add(this.labelTotalTarefas);
            this.detalhe.Controls.Add(this.LabelPontosstatic);
            this.detalhe.Controls.Add(this.labelTotal);
            this.detalhe.Controls.Add(this.concluida);
            this.detalhe.Location = new System.Drawing.Point(4, 25);
            this.detalhe.Name = "detalhe";
            this.detalhe.Size = new System.Drawing.Size(827, 467);
            this.detalhe.TabIndex = 2;
            this.detalhe.Text = "Detalhes";
            this.detalhe.UseVisualStyleBackColor = true;
            // 
            // listaTarefas
            // 
            this.listaTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaTarefas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaTarefas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_tarefa,
            this.detalhes,
            this.categoria_,
            this.diasRestantes,
            this.prioridade,
            this.estatus,
            this.pontos_});
            this.listaTarefas.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaTarefas.Location = new System.Drawing.Point(0, 0);
            this.listaTarefas.Name = "listaTarefas";
            this.listaTarefas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaTarefas.RowHeadersVisible = false;
            this.listaTarefas.RowHeadersWidth = 50;
            this.listaTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaTarefas.Size = new System.Drawing.Size(827, 277);
            this.listaTarefas.TabIndex = 14;
            // 
            // labelAndamento
            // 
            this.labelAndamento.AutoSize = true;
            this.labelAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAndamento.Location = new System.Drawing.Point(356, 331);
            this.labelAndamento.Name = "labelAndamento";
            this.labelAndamento.Size = new System.Drawing.Size(36, 37);
            this.labelAndamento.TabIndex = 13;
            this.labelAndamento.Text = "0";
            // 
            // emAndamento
            // 
            this.emAndamento.AutoSize = true;
            this.emAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emAndamento.ForeColor = System.Drawing.Color.DarkRed;
            this.emAndamento.Location = new System.Drawing.Point(305, 291);
            this.emAndamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emAndamento.Name = "emAndamento";
            this.emAndamento.Size = new System.Drawing.Size(152, 24);
            this.emAndamento.TabIndex = 12;
            this.emAndamento.Text = "Em Andamento..";
            // 
            // labelPontos
            // 
            this.labelPontos.AutoSize = true;
            this.labelPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPontos.Location = new System.Drawing.Point(630, 331);
            this.labelPontos.Name = "labelPontos";
            this.labelPontos.Size = new System.Drawing.Size(36, 37);
            this.labelPontos.TabIndex = 11;
            this.labelPontos.Text = "0";
            // 
            // labelConcluidas
            // 
            this.labelConcluidas.AutoSize = true;
            this.labelConcluidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcluidas.Location = new System.Drawing.Point(183, 331);
            this.labelConcluidas.Name = "labelConcluidas";
            this.labelConcluidas.Size = new System.Drawing.Size(36, 37);
            this.labelConcluidas.TabIndex = 10;
            this.labelConcluidas.Text = "0";
            // 
            // labelTotalTarefas
            // 
            this.labelTotalTarefas.AutoSize = true;
            this.labelTotalTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTarefas.Location = new System.Drawing.Point(40, 331);
            this.labelTotalTarefas.Name = "labelTotalTarefas";
            this.labelTotalTarefas.Size = new System.Drawing.Size(36, 37);
            this.labelTotalTarefas.TabIndex = 9;
            this.labelTotalTarefas.Text = "0";
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(4, 27);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(827, 465);
            this.config.TabIndex = 3;
            this.config.Text = "Configuração";
            this.config.UseVisualStyleBackColor = true;
            // 
            // oBJETIVOS_METASDataSet
            // 
            this.oBJETIVOS_METASDataSet.DataSetName = "OBJETIVOS_METASDataSet";
            this.oBJETIVOS_METASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAREFASBindingSource
            // 
            this.tAREFASBindingSource.DataMember = "TAREFAS";
            this.tAREFASBindingSource.DataSource = this.oBJETIVOS_METASDataSet;
            // 
            // tAREFASTableAdapter
            // 
            this.tAREFASTableAdapter.ClearBeforeFill = true;
            // 
            // tAREFASBindingSource1
            // 
            this.tAREFASBindingSource1.DataMember = "TAREFAS";
            this.tAREFASBindingSource1.DataSource = this.oBJETIVOS_METASDataSet;
            // 
            // nome_tarefa
            // 
            this.nome_tarefa.HeaderText = "Tarefa";
            this.nome_tarefa.Name = "nome_tarefa";
            // 
            // detalhes
            // 
            this.detalhes.HeaderText = "Descrição";
            this.detalhes.Name = "detalhes";
            // 
            // categoria_
            // 
            this.categoria_.HeaderText = "Categoria";
            this.categoria_.Name = "categoria_";
            // 
            // diasRestantes
            // 
            this.diasRestantes.HeaderText = "Dias Restantes";
            this.diasRestantes.Name = "diasRestantes";
            // 
            // prioridade
            // 
            this.prioridade.HeaderText = "Prioridade";
            this.prioridade.Name = "prioridade";
            this.prioridade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prioridade.ToolTipText = "Click Para concluir";
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Status";
            this.estatus.Name = "estatus";
            this.estatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pontos_
            // 
            this.pontos_.HeaderText = "Pontos ";
            this.pontos_.Name = "pontos_";
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 496);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tarefas_Load);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.Tarefa.ResumeLayout(false);
            this.Tarefa.PerformLayout();
            this.detalhe.ResumeLayout(false);
            this.detalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBJETIVOS_METASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFASBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label concluida;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.ComboBox comboDificuldade;
        private System.Windows.Forms.Label labelDificuldade;
        private System.Windows.Forms.DateTimePicker dataPrazo;
        private System.Windows.Forms.Label labelPrazo;
        private System.Windows.Forms.TextBox txtAdicionaCategoria;
        private System.Windows.Forms.Label labelAdicionaCategoria;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button btnInserirTarefa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Tarefa;
        private System.Windows.Forms.TabPage detalhe;
        private System.Windows.Forms.TabPage config;
        private System.Windows.Forms.Label AdicionaTarefas;
        private System.Windows.Forms.Label labelAndamento;
        private System.Windows.Forms.Label emAndamento;
        private System.Windows.Forms.Label labelPontos;
        private System.Windows.Forms.Label labelConcluidas;
        private System.Windows.Forms.Label labelTotalTarefas;
        private System.Windows.Forms.Label LabelPontosstatic;
        private System.Windows.Forms.DataGridView listaTarefas;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Button btnRemoveCategoria;
        private System.Windows.Forms.Button btnAdicionaCategoria;
        private System.Windows.Forms.PictureBox picture;
        private OBJETIVOS_METASDataSet oBJETIVOS_METASDataSet;
        private System.Windows.Forms.BindingSource tAREFASBindingSource;
        private OBJETIVOS_METASDataSetTableAdapters.TAREFASTableAdapter tAREFASTableAdapter;
        private System.Windows.Forms.BindingSource tAREFASBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasRestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos_;
    }
}