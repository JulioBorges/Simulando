namespace Simulando.UI
{
    partial class FrmParametros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label p_SenhaParametrosLabel;
            System.Windows.Forms.Label p_NomeEmpresaLabel;
            System.Windows.Forms.Label p_TeclaALabel;
            System.Windows.Forms.Label p_TeclaIniciarLabel;
            System.Windows.Forms.Label p_TeclaFinalizarLabel;
            System.Windows.Forms.Label p_TeclaProximaLabel;
            System.Windows.Forms.Label p_TeclaAnteriorLabel;
            System.Windows.Forms.Label p_TeclaLimparLabel;
            System.Windows.Forms.Label p_TeclaBLabel;
            System.Windows.Forms.Label p_TeclaCLabel;
            System.Windows.Forms.Label p_TeclaDLabel;
            System.Windows.Forms.Label p_TeclaELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametros));
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.parametrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametrosTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.ParametrosTableAdapter();
            this.tableAdapterManager = new Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorDados = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonSalvar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.SeparatorFim = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlParametros = new System.Windows.Forms.TabControl();
            this.tabPageGeral = new System.Windows.Forms.TabPage();
            this.buttonCadProva = new System.Windows.Forms.Button();
            this.buttonCadCategoria = new System.Windows.Forms.Button();
            this.btnCadQuestoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaParametros = new CustomControls.Data.DataTextBox();
            this.txtNomeEmpresa = new CustomControls.Data.DataTextBox();
            this.dtPicImagem = new CustomControls.Data.DataPictureBox();
            this.tabPageTeclado = new System.Windows.Forms.TabPage();
            this.groupBoxMapeamento = new System.Windows.Forms.GroupBox();
            this.p_TeclaETextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaDTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaCTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaBTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaLimparTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaAnteriorTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaProximaTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaFinalizarTextBox = new System.Windows.Forms.TextBox();
            this.p_TeclaIniciarTextBox = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.p_TeclaATextBox = new System.Windows.Forms.TextBox();
            this.btnB = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.cbUsaTecladoVirtual = new CustomControls.Data.DataCheckBox(this.components);
            p_SenhaParametrosLabel = new System.Windows.Forms.Label();
            p_NomeEmpresaLabel = new System.Windows.Forms.Label();
            p_TeclaALabel = new System.Windows.Forms.Label();
            p_TeclaIniciarLabel = new System.Windows.Forms.Label();
            p_TeclaFinalizarLabel = new System.Windows.Forms.Label();
            p_TeclaProximaLabel = new System.Windows.Forms.Label();
            p_TeclaAnteriorLabel = new System.Windows.Forms.Label();
            p_TeclaLimparLabel = new System.Windows.Forms.Label();
            p_TeclaBLabel = new System.Windows.Forms.Label();
            p_TeclaCLabel = new System.Windows.Forms.Label();
            p_TeclaDLabel = new System.Windows.Forms.Label();
            p_TeclaELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            this.tabControlParametros.SuspendLayout();
            this.tabPageGeral.SuspendLayout();
            this.tabPageTeclado.SuspendLayout();
            this.groupBoxMapeamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_SenhaParametrosLabel
            // 
            p_SenhaParametrosLabel.AutoSize = true;
            p_SenhaParametrosLabel.Location = new System.Drawing.Point(8, 73);
            p_SenhaParametrosLabel.Name = "p_SenhaParametrosLabel";
            p_SenhaParametrosLabel.Size = new System.Drawing.Size(130, 13);
            p_SenhaParametrosLabel.TabIndex = 30;
            p_SenhaParametrosLabel.Text = "Senha para configuração:";
            // 
            // p_NomeEmpresaLabel
            // 
            p_NomeEmpresaLabel.AutoSize = true;
            p_NomeEmpresaLabel.Location = new System.Drawing.Point(8, 33);
            p_NomeEmpresaLabel.Name = "p_NomeEmpresaLabel";
            p_NomeEmpresaLabel.Size = new System.Drawing.Size(96, 13);
            p_NomeEmpresaLabel.TabIndex = 26;
            p_NomeEmpresaLabel.Text = "Nome da empresa:";
            // 
            // p_TeclaALabel
            // 
            p_TeclaALabel.AutoSize = true;
            p_TeclaALabel.Location = new System.Drawing.Point(264, 24);
            p_TeclaALabel.Name = "p_TeclaALabel";
            p_TeclaALabel.Size = new System.Drawing.Size(47, 13);
            p_TeclaALabel.TabIndex = 26;
            p_TeclaALabel.Text = "Tecla A:";
            // 
            // p_TeclaIniciarLabel
            // 
            p_TeclaIniciarLabel.AutoSize = true;
            p_TeclaIniciarLabel.Location = new System.Drawing.Point(45, 24);
            p_TeclaIniciarLabel.Name = "p_TeclaIniciarLabel";
            p_TeclaIniciarLabel.Size = new System.Drawing.Size(68, 13);
            p_TeclaIniciarLabel.TabIndex = 27;
            p_TeclaIniciarLabel.Text = "Tecla Iniciar:";
            // 
            // p_TeclaFinalizarLabel
            // 
            p_TeclaFinalizarLabel.AutoSize = true;
            p_TeclaFinalizarLabel.Location = new System.Drawing.Point(45, 60);
            p_TeclaFinalizarLabel.Name = "p_TeclaFinalizarLabel";
            p_TeclaFinalizarLabel.Size = new System.Drawing.Size(78, 13);
            p_TeclaFinalizarLabel.TabIndex = 28;
            p_TeclaFinalizarLabel.Text = "Tecla Finalizar:";
            // 
            // p_TeclaProximaLabel
            // 
            p_TeclaProximaLabel.AutoSize = true;
            p_TeclaProximaLabel.Location = new System.Drawing.Point(45, 99);
            p_TeclaProximaLabel.Name = "p_TeclaProximaLabel";
            p_TeclaProximaLabel.Size = new System.Drawing.Size(77, 13);
            p_TeclaProximaLabel.TabIndex = 29;
            p_TeclaProximaLabel.Text = "Tecla Proxima:";
            // 
            // p_TeclaAnteriorLabel
            // 
            p_TeclaAnteriorLabel.AutoSize = true;
            p_TeclaAnteriorLabel.Location = new System.Drawing.Point(45, 138);
            p_TeclaAnteriorLabel.Name = "p_TeclaAnteriorLabel";
            p_TeclaAnteriorLabel.Size = new System.Drawing.Size(76, 13);
            p_TeclaAnteriorLabel.TabIndex = 30;
            p_TeclaAnteriorLabel.Text = "Tecla Anterior:";
            // 
            // p_TeclaLimparLabel
            // 
            p_TeclaLimparLabel.AutoSize = true;
            p_TeclaLimparLabel.Location = new System.Drawing.Point(45, 177);
            p_TeclaLimparLabel.Name = "p_TeclaLimparLabel";
            p_TeclaLimparLabel.Size = new System.Drawing.Size(71, 13);
            p_TeclaLimparLabel.TabIndex = 31;
            p_TeclaLimparLabel.Text = "Tecla Limpar:";
            // 
            // p_TeclaBLabel
            // 
            p_TeclaBLabel.AutoSize = true;
            p_TeclaBLabel.Location = new System.Drawing.Point(264, 60);
            p_TeclaBLabel.Name = "p_TeclaBLabel";
            p_TeclaBLabel.Size = new System.Drawing.Size(47, 13);
            p_TeclaBLabel.TabIndex = 32;
            p_TeclaBLabel.Text = "Tecla B:";
            // 
            // p_TeclaCLabel
            // 
            p_TeclaCLabel.AutoSize = true;
            p_TeclaCLabel.Location = new System.Drawing.Point(264, 99);
            p_TeclaCLabel.Name = "p_TeclaCLabel";
            p_TeclaCLabel.Size = new System.Drawing.Size(47, 13);
            p_TeclaCLabel.TabIndex = 33;
            p_TeclaCLabel.Text = "Tecla C:";
            // 
            // p_TeclaDLabel
            // 
            p_TeclaDLabel.AutoSize = true;
            p_TeclaDLabel.Location = new System.Drawing.Point(264, 138);
            p_TeclaDLabel.Name = "p_TeclaDLabel";
            p_TeclaDLabel.Size = new System.Drawing.Size(48, 13);
            p_TeclaDLabel.TabIndex = 34;
            p_TeclaDLabel.Text = "Tecla D:";
            // 
            // p_TeclaELabel
            // 
            p_TeclaELabel.AutoSize = true;
            p_TeclaELabel.Location = new System.Drawing.Point(265, 177);
            p_TeclaELabel.Name = "p_TeclaELabel";
            p_TeclaELabel.Size = new System.Drawing.Size(47, 13);
            p_TeclaELabel.TabIndex = 35;
            p_TeclaELabel.Text = "Tecla E:";
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrosBindingSource
            // 
            this.parametrosBindingSource.DataMember = "Parametros";
            this.parametrosBindingSource.DataSource = this.simulandoDBDataSet;
            // 
            // parametrosTableAdapter
            // 
            this.parametrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ParametrosTableAdapter = this.parametrosTableAdapter;
            this.tableAdapterManager.ProvaTableAdapter = null;
            this.tableAdapterManager.QuestaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = null;
            this.bindingNavigatorDados.BindingSource = this.parametrosBindingSource;
            this.bindingNavigatorDados.CountItem = null;
            this.bindingNavigatorDados.CountItemFormat = "de {0}";
            this.bindingNavigatorDados.DeleteItem = null;
            this.bindingNavigatorDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAtualizar,
            this.buttonEditar,
            this.buttonSalvar,
            this.buttonCancelar,
            this.SeparatorFim});
            this.bindingNavigatorDados.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDados.MoveFirstItem = null;
            this.bindingNavigatorDados.MoveLastItem = null;
            this.bindingNavigatorDados.MoveNextItem = null;
            this.bindingNavigatorDados.MovePreviousItem = null;
            this.bindingNavigatorDados.Name = "bindingNavigatorDados";
            this.bindingNavigatorDados.PositionItem = null;
            this.bindingNavigatorDados.Size = new System.Drawing.Size(552, 43);
            this.bindingNavigatorDados.TabIndex = 16;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.AutoSize = false;
            this.buttonAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.Image")));
            this.buttonAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(40, 40);
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.AutoSize = false;
            this.buttonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(40, 40);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(40, 40);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvarClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelar.Text = "Calcelar edição";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // SeparatorFim
            // 
            this.SeparatorFim.Name = "SeparatorFim";
            this.SeparatorFim.Size = new System.Drawing.Size(6, 43);
            // 
            // tabControlParametros
            // 
            this.tabControlParametros.Controls.Add(this.tabPageGeral);
            this.tabControlParametros.Controls.Add(this.tabPageTeclado);
            this.tabControlParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlParametros.Location = new System.Drawing.Point(0, 43);
            this.tabControlParametros.Name = "tabControlParametros";
            this.tabControlParametros.SelectedIndex = 0;
            this.tabControlParametros.Size = new System.Drawing.Size(552, 303);
            this.tabControlParametros.TabIndex = 23;
            // 
            // tabPageGeral
            // 
            this.tabPageGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGeral.Controls.Add(this.buttonCadProva);
            this.tabPageGeral.Controls.Add(this.buttonCadCategoria);
            this.tabPageGeral.Controls.Add(this.btnCadQuestoes);
            this.tabPageGeral.Controls.Add(this.label1);
            this.tabPageGeral.Controls.Add(this.txtSenhaParametros);
            this.tabPageGeral.Controls.Add(this.txtNomeEmpresa);
            this.tabPageGeral.Controls.Add(p_SenhaParametrosLabel);
            this.tabPageGeral.Controls.Add(p_NomeEmpresaLabel);
            this.tabPageGeral.Controls.Add(this.dtPicImagem);
            this.tabPageGeral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeral.Name = "tabPageGeral";
            this.tabPageGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeral.Size = new System.Drawing.Size(544, 277);
            this.tabPageGeral.TabIndex = 0;
            this.tabPageGeral.Text = "Configurações gerais";
            // 
            // buttonCadProva
            // 
            this.buttonCadProva.Location = new System.Drawing.Point(8, 205);
            this.buttonCadProva.Name = "buttonCadProva";
            this.buttonCadProva.Size = new System.Drawing.Size(246, 39);
            this.buttonCadProva.TabIndex = 29;
            this.buttonCadProva.Text = "Cadastro de Provas";
            this.buttonCadProva.UseVisualStyleBackColor = true;
            this.buttonCadProva.Click += new System.EventHandler(this.buttonCadProva_Click);
            // 
            // buttonCadCategoria
            // 
            this.buttonCadCategoria.Location = new System.Drawing.Point(8, 115);
            this.buttonCadCategoria.Name = "buttonCadCategoria";
            this.buttonCadCategoria.Size = new System.Drawing.Size(246, 39);
            this.buttonCadCategoria.TabIndex = 27;
            this.buttonCadCategoria.Text = "Cadastro de Categorias";
            this.buttonCadCategoria.UseVisualStyleBackColor = true;
            this.buttonCadCategoria.Click += new System.EventHandler(this.buttonCadCategoria_Click);
            // 
            // btnCadQuestoes
            // 
            this.btnCadQuestoes.Location = new System.Drawing.Point(8, 160);
            this.btnCadQuestoes.Name = "btnCadQuestoes";
            this.btnCadQuestoes.Size = new System.Drawing.Size(246, 39);
            this.btnCadQuestoes.TabIndex = 28;
            this.btnCadQuestoes.Text = "Cadastro de Questões";
            this.btnCadQuestoes.UseVisualStyleBackColor = true;
            this.btnCadQuestoes.Click += new System.EventHandler(this.btnCadQuestoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Logo da empresa:";
            // 
            // txtSenhaParametros
            // 
            this.txtSenhaParametros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenhaParametros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_SenhaParametros", true));
            this.txtSenhaParametros.Field = null;
            this.txtSenhaParametros.Location = new System.Drawing.Point(8, 89);
            this.txtSenhaParametros.MaxLength = 10;
            this.txtSenhaParametros.Name = "txtSenhaParametros";
            this.txtSenhaParametros.PasswordChar = '*';
            this.txtSenhaParametros.Property = null;
            this.txtSenhaParametros.Size = new System.Drawing.Size(143, 20);
            this.txtSenhaParametros.TabIndex = 24;
            this.txtSenhaParametros.TipoValidacao = CustomControls.Data.TipoTexto.Geral;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_NomeEmpresa", true));
            this.txtNomeEmpresa.Field = null;
            this.txtNomeEmpresa.Location = new System.Drawing.Point(8, 49);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Property = null;
            this.txtNomeEmpresa.Size = new System.Drawing.Size(529, 20);
            this.txtNomeEmpresa.TabIndex = 23;
            this.txtNomeEmpresa.TipoValidacao = CustomControls.Data.TipoTexto.Geral;
            // 
            // dtPicImagem
            // 
            this.dtPicImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtPicImagem.CaminhoImagem = null;
            this.dtPicImagem.Field = null;
            this.dtPicImagem.Location = new System.Drawing.Point(270, 89);
            this.dtPicImagem.Name = "dtPicImagem";
            this.dtPicImagem.Property = null;
            this.dtPicImagem.Size = new System.Drawing.Size(267, 155);
            this.dtPicImagem.TabIndex = 25;
            // 
            // tabPageTeclado
            // 
            this.tabPageTeclado.AutoScroll = true;
            this.tabPageTeclado.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTeclado.Controls.Add(this.groupBoxMapeamento);
            this.tabPageTeclado.Controls.Add(this.cbUsaTecladoVirtual);
            this.tabPageTeclado.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeclado.Name = "tabPageTeclado";
            this.tabPageTeclado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeclado.Size = new System.Drawing.Size(544, 277);
            this.tabPageTeclado.TabIndex = 1;
            this.tabPageTeclado.Text = "Configurações de teclado";
            // 
            // groupBoxMapeamento
            // 
            this.groupBoxMapeamento.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMapeamento.Controls.Add(p_TeclaELabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaETextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaDLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaDTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaCLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaCTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaBLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaBTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaLimparLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaLimparTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaAnteriorLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaAnteriorTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaProximaLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaProximaTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaFinalizarLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaFinalizarTextBox);
            this.groupBoxMapeamento.Controls.Add(p_TeclaIniciarLabel);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaIniciarTextBox);
            this.groupBoxMapeamento.Controls.Add(this.btnFinalizar);
            this.groupBoxMapeamento.Controls.Add(p_TeclaALabel);
            this.groupBoxMapeamento.Controls.Add(this.btnA);
            this.groupBoxMapeamento.Controls.Add(this.p_TeclaATextBox);
            this.groupBoxMapeamento.Controls.Add(this.btnB);
            this.groupBoxMapeamento.Controls.Add(this.btnAnterior);
            this.groupBoxMapeamento.Controls.Add(this.btnC);
            this.groupBoxMapeamento.Controls.Add(this.btnE);
            this.groupBoxMapeamento.Controls.Add(this.btnLimpar);
            this.groupBoxMapeamento.Controls.Add(this.btnD);
            this.groupBoxMapeamento.Controls.Add(this.btnIniciar);
            this.groupBoxMapeamento.Controls.Add(this.btnProxima);
            this.groupBoxMapeamento.Enabled = false;
            this.groupBoxMapeamento.Location = new System.Drawing.Point(8, 48);
            this.groupBoxMapeamento.Name = "groupBoxMapeamento";
            this.groupBoxMapeamento.Size = new System.Drawing.Size(524, 225);
            this.groupBoxMapeamento.TabIndex = 28;
            this.groupBoxMapeamento.TabStop = false;
            this.groupBoxMapeamento.Text = "Mapeamento de botões (Somente teclado físico)";
            // 
            // p_TeclaETextBox
            // 
            this.p_TeclaETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaE", true));
            this.p_TeclaETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaETextBox.Location = new System.Drawing.Point(267, 193);
            this.p_TeclaETextBox.Name = "p_TeclaETextBox";
            this.p_TeclaETextBox.ReadOnly = true;
            this.p_TeclaETextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaETextBox.TabIndex = 36;
            this.p_TeclaETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaDTextBox
            // 
            this.p_TeclaDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaD", true));
            this.p_TeclaDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaDTextBox.Location = new System.Drawing.Point(267, 154);
            this.p_TeclaDTextBox.Name = "p_TeclaDTextBox";
            this.p_TeclaDTextBox.ReadOnly = true;
            this.p_TeclaDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaDTextBox.TabIndex = 35;
            this.p_TeclaDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaCTextBox
            // 
            this.p_TeclaCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaC", true));
            this.p_TeclaCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaCTextBox.Location = new System.Drawing.Point(267, 115);
            this.p_TeclaCTextBox.Name = "p_TeclaCTextBox";
            this.p_TeclaCTextBox.ReadOnly = true;
            this.p_TeclaCTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaCTextBox.TabIndex = 34;
            this.p_TeclaCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaBTextBox
            // 
            this.p_TeclaBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaB", true));
            this.p_TeclaBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaBTextBox.Location = new System.Drawing.Point(267, 76);
            this.p_TeclaBTextBox.Name = "p_TeclaBTextBox";
            this.p_TeclaBTextBox.ReadOnly = true;
            this.p_TeclaBTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaBTextBox.TabIndex = 33;
            this.p_TeclaBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaLimparTextBox
            // 
            this.p_TeclaLimparTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaLimpar", true));
            this.p_TeclaLimparTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaLimparTextBox.Location = new System.Drawing.Point(48, 193);
            this.p_TeclaLimparTextBox.Name = "p_TeclaLimparTextBox";
            this.p_TeclaLimparTextBox.ReadOnly = true;
            this.p_TeclaLimparTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaLimparTextBox.TabIndex = 32;
            this.p_TeclaLimparTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaAnteriorTextBox
            // 
            this.p_TeclaAnteriorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaAnterior", true));
            this.p_TeclaAnteriorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaAnteriorTextBox.Location = new System.Drawing.Point(48, 154);
            this.p_TeclaAnteriorTextBox.Name = "p_TeclaAnteriorTextBox";
            this.p_TeclaAnteriorTextBox.ReadOnly = true;
            this.p_TeclaAnteriorTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaAnteriorTextBox.TabIndex = 31;
            this.p_TeclaAnteriorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaProximaTextBox
            // 
            this.p_TeclaProximaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaProxima", true));
            this.p_TeclaProximaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaProximaTextBox.Location = new System.Drawing.Point(48, 115);
            this.p_TeclaProximaTextBox.Name = "p_TeclaProximaTextBox";
            this.p_TeclaProximaTextBox.ReadOnly = true;
            this.p_TeclaProximaTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaProximaTextBox.TabIndex = 30;
            this.p_TeclaProximaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaFinalizarTextBox
            // 
            this.p_TeclaFinalizarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaFinalizar", true));
            this.p_TeclaFinalizarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaFinalizarTextBox.Location = new System.Drawing.Point(48, 76);
            this.p_TeclaFinalizarTextBox.Name = "p_TeclaFinalizarTextBox";
            this.p_TeclaFinalizarTextBox.ReadOnly = true;
            this.p_TeclaFinalizarTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaFinalizarTextBox.TabIndex = 29;
            this.p_TeclaFinalizarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_TeclaIniciarTextBox
            // 
            this.p_TeclaIniciarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaIniciar", true));
            this.p_TeclaIniciarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaIniciarTextBox.Location = new System.Drawing.Point(48, 37);
            this.p_TeclaIniciarTextBox.Name = "p_TeclaIniciarTextBox";
            this.p_TeclaIniciarTextBox.ReadOnly = true;
            this.p_TeclaIniciarTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaIniciarTextBox.TabIndex = 28;
            this.p_TeclaIniciarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Red;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizar.Location = new System.Drawing.Point(154, 60);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(107, 36);
            this.btnFinalizar.TabIndex = 24;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.Window;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(373, 24);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(107, 33);
            this.btnA.TabIndex = 17;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // p_TeclaATextBox
            // 
            this.p_TeclaATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosBindingSource, "P_TeclaA", true));
            this.p_TeclaATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_TeclaATextBox.Location = new System.Drawing.Point(267, 37);
            this.p_TeclaATextBox.Name = "p_TeclaATextBox";
            this.p_TeclaATextBox.ReadOnly = true;
            this.p_TeclaATextBox.Size = new System.Drawing.Size(100, 20);
            this.p_TeclaATextBox.TabIndex = 27;
            this.p_TeclaATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.Window;
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(373, 63);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(107, 33);
            this.btnB.TabIndex = 18;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Yellow;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(154, 138);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(107, 36);
            this.btnAnterior.TabIndex = 26;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Window;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(373, 102);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(107, 33);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.Window;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(373, 180);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(107, 33);
            this.btnE.TabIndex = 21;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(154, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 36);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.Window;
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(373, 141);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(107, 33);
            this.btnD.TabIndex = 20;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(154, 24);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(107, 33);
            this.btnIniciar.TabIndex = 23;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.BackColor = System.Drawing.Color.Yellow;
            this.btnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.Location = new System.Drawing.Point(154, 99);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(107, 36);
            this.btnProxima.TabIndex = 25;
            this.btnProxima.Text = "PRÓXIMA";
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // cbUsaTecladoVirtual
            // 
            this.cbUsaTecladoVirtual.DataBindings.Add(new System.Windows.Forms.Binding("ValueData", this.parametrosBindingSource, "P_UsaTecladoVirtual", true));
            this.cbUsaTecladoVirtual.Field = null;
            this.cbUsaTecladoVirtual.Location = new System.Drawing.Point(8, 18);
            this.cbUsaTecladoVirtual.Name = "cbUsaTecladoVirtual";
            this.cbUsaTecladoVirtual.Property = null;
            this.cbUsaTecladoVirtual.Size = new System.Drawing.Size(123, 24);
            this.cbUsaTecladoVirtual.TabIndex = 1;
            this.cbUsaTecladoVirtual.Text = "Usa teclado Virtual";
            this.cbUsaTecladoVirtual.UseVisualStyleBackColor = true;
            this.cbUsaTecladoVirtual.ValueChecked = "S";
            this.cbUsaTecladoVirtual.ValueData = "N";
            this.cbUsaTecladoVirtual.ValueUnchecked = "N";
            this.cbUsaTecladoVirtual.CheckedChanged += new System.EventHandler(this.cbUsaTecladoVirtual_CheckedChanged);
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.tabControlParametros);
            this.Controls.Add(this.bindingNavigatorDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmParametros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParametros";
            this.Load += new System.EventHandler(this.FrmParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            this.tabControlParametros.ResumeLayout(false);
            this.tabPageGeral.ResumeLayout(false);
            this.tabPageGeral.PerformLayout();
            this.tabPageTeclado.ResumeLayout(false);
            this.groupBoxMapeamento.ResumeLayout(false);
            this.groupBoxMapeamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private System.Windows.Forms.BindingSource parametrosBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter;
        private Data.SimulandoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDados;
        private System.Windows.Forms.ToolStripButton buttonAtualizar;
        private System.Windows.Forms.ToolStripButton buttonEditar;
        private System.Windows.Forms.ToolStripButton buttonSalvar;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripSeparator SeparatorFim;
        private System.Windows.Forms.TabControl tabControlParametros;
        private System.Windows.Forms.TabPage tabPageGeral;
        private System.Windows.Forms.Button buttonCadProva;
        private System.Windows.Forms.Button buttonCadCategoria;
        private System.Windows.Forms.Button btnCadQuestoes;
        private System.Windows.Forms.Label label1;
        private CustomControls.Data.DataTextBox txtSenhaParametros;
        private CustomControls.Data.DataTextBox txtNomeEmpresa;
        private CustomControls.Data.DataPictureBox dtPicImagem;
        private System.Windows.Forms.TabPage tabPageTeclado;
        private CustomControls.Data.DataCheckBox cbUsaTecladoVirtual;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.GroupBox groupBoxMapeamento;
        private System.Windows.Forms.TextBox p_TeclaETextBox;
        private System.Windows.Forms.TextBox p_TeclaDTextBox;
        private System.Windows.Forms.TextBox p_TeclaCTextBox;
        private System.Windows.Forms.TextBox p_TeclaBTextBox;
        private System.Windows.Forms.TextBox p_TeclaLimparTextBox;
        private System.Windows.Forms.TextBox p_TeclaAnteriorTextBox;
        private System.Windows.Forms.TextBox p_TeclaProximaTextBox;
        private System.Windows.Forms.TextBox p_TeclaFinalizarTextBox;
        private System.Windows.Forms.TextBox p_TeclaIniciarTextBox;
        private System.Windows.Forms.TextBox p_TeclaATextBox;
    }
}