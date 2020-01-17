namespace Simulando.UI
{
    partial class FrmCadQuestao
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label q_TextoLabel;
            System.Windows.Forms.Label q_RespostaALabel;
            System.Windows.Forms.Label q_RespostaBLabel;
            System.Windows.Forms.Label q_RespostaCLabel;
            System.Windows.Forms.Label q_RespostaDLabel;
            System.Windows.Forms.Label q_NivelQuestaoLabel;
            System.Windows.Forms.Label q_IdCategoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadQuestao));
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.questaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questaoTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter();
            this.tableAdapterManager = new Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager();
            this.txtId = new CustomControls.Data.DataTextBox();
            this.txtTextoQuestao = new System.Windows.Forms.TextBox();
            this.txtRespostaA = new System.Windows.Forms.TextBox();
            this.txtRespostaB = new System.Windows.Forms.TextBox();
            this.txtRespostaC = new System.Windows.Forms.TextBox();
            this.txtRespostaD = new System.Windows.Forms.TextBox();
            this.bindingNavigatorDados = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonInserir = new System.Windows.Forms.ToolStripButton();
            this.buttonPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.buttonAnterior = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonProximo = new System.Windows.Forms.ToolStripButton();
            this.buttonUltimo = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonSalvar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonDeletar = new System.Windows.Forms.ToolStripButton();
            this.SeparatorFim = new System.Windows.Forms.ToolStripSeparator();
            this.btnIniciaPesquisa = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.cbCriterioBusca = new System.Windows.Forms.ToolStripComboBox();
            this.dtPicImagem = new CustomControls.Data.DataPictureBox();
            this.rbA = new CustomControls.Data.DataRadioButton();
            this.rbB = new CustomControls.Data.DataRadioButton();
            this.rbC = new CustomControls.Data.DataRadioButton();
            this.rbD = new CustomControls.Data.DataRadioButton();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.buttonAddCategoria = new System.Windows.Forms.Button();
            this.srcNivel = new CustomControls.Data.StarRatingControl();
            this.btnSelecionarQuestao = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            q_TextoLabel = new System.Windows.Forms.Label();
            q_RespostaALabel = new System.Windows.Forms.Label();
            q_RespostaBLabel = new System.Windows.Forms.Label();
            q_RespostaCLabel = new System.Windows.Forms.Label();
            q_RespostaDLabel = new System.Windows.Forms.Label();
            q_NivelQuestaoLabel = new System.Windows.Forms.Label();
            q_IdCategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 62);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Cód.:";
            // 
            // q_TextoLabel
            // 
            q_TextoLabel.AutoSize = true;
            q_TextoLabel.Location = new System.Drawing.Point(15, 100);
            q_TextoLabel.Name = "q_TextoLabel";
            q_TextoLabel.Size = new System.Drawing.Size(50, 13);
            q_TextoLabel.TabIndex = 3;
            q_TextoLabel.Text = "Questão:";
            // 
            // q_RespostaALabel
            // 
            q_RespostaALabel.AutoSize = true;
            q_RespostaALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaALabel.Location = new System.Drawing.Point(15, 196);
            q_RespostaALabel.Name = "q_RespostaALabel";
            q_RespostaALabel.Size = new System.Drawing.Size(20, 15);
            q_RespostaALabel.TabIndex = 7;
            q_RespostaALabel.Text = "A)";
            // 
            // q_RespostaBLabel
            // 
            q_RespostaBLabel.AutoSize = true;
            q_RespostaBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaBLabel.Location = new System.Drawing.Point(15, 271);
            q_RespostaBLabel.Name = "q_RespostaBLabel";
            q_RespostaBLabel.Size = new System.Drawing.Size(21, 15);
            q_RespostaBLabel.TabIndex = 9;
            q_RespostaBLabel.Text = "B)";
            // 
            // q_RespostaCLabel
            // 
            q_RespostaCLabel.AutoSize = true;
            q_RespostaCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaCLabel.Location = new System.Drawing.Point(15, 346);
            q_RespostaCLabel.Name = "q_RespostaCLabel";
            q_RespostaCLabel.Size = new System.Drawing.Size(21, 15);
            q_RespostaCLabel.TabIndex = 11;
            q_RespostaCLabel.Text = "C)";
            // 
            // q_RespostaDLabel
            // 
            q_RespostaDLabel.AutoSize = true;
            q_RespostaDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaDLabel.Location = new System.Drawing.Point(15, 421);
            q_RespostaDLabel.Name = "q_RespostaDLabel";
            q_RespostaDLabel.Size = new System.Drawing.Size(22, 15);
            q_RespostaDLabel.TabIndex = 13;
            q_RespostaDLabel.Text = "D)";
            // 
            // q_NivelQuestaoLabel
            // 
            q_NivelQuestaoLabel.AutoSize = true;
            q_NivelQuestaoLabel.Location = new System.Drawing.Point(500, 62);
            q_NivelQuestaoLabel.Name = "q_NivelQuestaoLabel";
            q_NivelQuestaoLabel.Size = new System.Drawing.Size(34, 13);
            q_NivelQuestaoLabel.TabIndex = 21;
            q_NivelQuestaoLabel.Text = "Nivel:";
            // 
            // q_IdCategoriaLabel
            // 
            q_IdCategoriaLabel.AutoSize = true;
            q_IdCategoriaLabel.Location = new System.Drawing.Point(68, 62);
            q_IdCategoriaLabel.Name = "q_IdCategoriaLabel";
            q_IdCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            q_IdCategoriaLabel.TabIndex = 22;
            q_IdCategoriaLabel.Text = "Categoria:";
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questaoBindingSource
            // 
            this.questaoBindingSource.DataMember = "Questao";
            this.questaoBindingSource.DataSource = this.simulandoDBDataSet;
            this.questaoBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.questaoBindingSource_AddingNew);
            this.questaoBindingSource.PositionChanged += new System.EventHandler(this.questaoBindingSource_PositionChanged);
            // 
            // questaoTableAdapter
            // 
            this.questaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ParametrosTableAdapter = null;
            this.tableAdapterManager.ProvaTableAdapter = null;
            this.tableAdapterManager.QuestaoTableAdapter = this.questaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Id", true));
            this.txtId.Field = null;
            this.txtId.Location = new System.Drawing.Point(15, 78);
            this.txtId.Name = "txtId";
            this.txtId.Property = null;
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 2;
            this.txtId.TipoValidacao = CustomControls.Data.TipoTexto.Geral;
            // 
            // txtTextoQuestao
            // 
            this.txtTextoQuestao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Q_Texto", true));
            this.txtTextoQuestao.Location = new System.Drawing.Point(15, 116);
            this.txtTextoQuestao.Multiline = true;
            this.txtTextoQuestao.Name = "txtTextoQuestao";
            this.txtTextoQuestao.Size = new System.Drawing.Size(529, 47);
            this.txtTextoQuestao.TabIndex = 4;
            // 
            // txtRespostaA
            // 
            this.txtRespostaA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Q_RespostaA", true));
            this.txtRespostaA.Location = new System.Drawing.Point(71, 170);
            this.txtRespostaA.Multiline = true;
            this.txtRespostaA.Name = "txtRespostaA";
            this.txtRespostaA.Size = new System.Drawing.Size(473, 67);
            this.txtRespostaA.TabIndex = 8;
            // 
            // txtRespostaB
            // 
            this.txtRespostaB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Q_RespostaB", true));
            this.txtRespostaB.Location = new System.Drawing.Point(71, 245);
            this.txtRespostaB.Multiline = true;
            this.txtRespostaB.Name = "txtRespostaB";
            this.txtRespostaB.Size = new System.Drawing.Size(473, 67);
            this.txtRespostaB.TabIndex = 10;
            // 
            // txtRespostaC
            // 
            this.txtRespostaC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Q_RespostaC", true));
            this.txtRespostaC.Location = new System.Drawing.Point(71, 320);
            this.txtRespostaC.Multiline = true;
            this.txtRespostaC.Name = "txtRespostaC";
            this.txtRespostaC.Size = new System.Drawing.Size(473, 67);
            this.txtRespostaC.TabIndex = 12;
            // 
            // txtRespostaD
            // 
            this.txtRespostaD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questaoBindingSource, "Q_RespostaD", true));
            this.txtRespostaD.Location = new System.Drawing.Point(71, 395);
            this.txtRespostaD.Multiline = true;
            this.txtRespostaD.Name = "txtRespostaD";
            this.txtRespostaD.Size = new System.Drawing.Size(473, 67);
            this.txtRespostaD.TabIndex = 14;
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = this.buttonInserir;
            this.bindingNavigatorDados.BindingSource = this.questaoBindingSource;
            this.bindingNavigatorDados.CountItem = null;
            this.bindingNavigatorDados.CountItemFormat = "de {0}";
            this.bindingNavigatorDados.DeleteItem = null;
            this.bindingNavigatorDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPrimeiro,
            this.buttonAnterior,
            this.SeparatorNav1,
            this.buttonProximo,
            this.buttonUltimo,
            this.SeparatorNav2,
            this.buttonAtualizar,
            this.buttonInserir,
            this.buttonEditar,
            this.buttonSalvar,
            this.buttonCancelar,
            this.buttonDeletar,
            this.SeparatorFim,
            this.btnIniciaPesquisa,
            this.btnPesquisar,
            this.cbCriterioBusca});
            this.bindingNavigatorDados.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDados.MoveFirstItem = this.buttonPrimeiro;
            this.bindingNavigatorDados.MoveLastItem = this.buttonUltimo;
            this.bindingNavigatorDados.MoveNextItem = this.buttonProximo;
            this.bindingNavigatorDados.MovePreviousItem = this.buttonAnterior;
            this.bindingNavigatorDados.Name = "bindingNavigatorDados";
            this.bindingNavigatorDados.PositionItem = null;
            this.bindingNavigatorDados.Size = new System.Drawing.Size(719, 43);
            this.bindingNavigatorDados.TabIndex = 15;
            // 
            // buttonInserir
            // 
            this.buttonInserir.AutoSize = false;
            this.buttonInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonInserir.Image = ((System.Drawing.Image)(resources.GetObject("buttonInserir.Image")));
            this.buttonInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.RightToLeftAutoMirrorImage = true;
            this.buttonInserir.Size = new System.Drawing.Size(40, 40);
            this.buttonInserir.Text = "Novo";
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.AutoSize = false;
            this.buttonPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrimeiro.Image")));
            this.buttonPrimeiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.RightToLeftAutoMirrorImage = true;
            this.buttonPrimeiro.Size = new System.Drawing.Size(40, 40);
            this.buttonPrimeiro.Text = "Primeiro";
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.AutoSize = false;
            this.buttonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnterior.Image")));
            this.buttonAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.RightToLeftAutoMirrorImage = true;
            this.buttonAnterior.Size = new System.Drawing.Size(40, 40);
            this.buttonAnterior.Text = "Anterior";
            // 
            // SeparatorNav1
            // 
            this.SeparatorNav1.Name = "SeparatorNav1";
            this.SeparatorNav1.Size = new System.Drawing.Size(6, 43);
            // 
            // buttonProximo
            // 
            this.buttonProximo.AutoSize = false;
            this.buttonProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProximo.Image = ((System.Drawing.Image)(resources.GetObject("buttonProximo.Image")));
            this.buttonProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.RightToLeftAutoMirrorImage = true;
            this.buttonProximo.Size = new System.Drawing.Size(40, 40);
            this.buttonProximo.Text = "Próximo";
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.AutoSize = false;
            this.buttonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUltimo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUltimo.Image")));
            this.buttonUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.RightToLeftAutoMirrorImage = true;
            this.buttonUltimo.Size = new System.Drawing.Size(40, 40);
            this.buttonUltimo.Text = "Ultimo";
            // 
            // SeparatorNav2
            // 
            this.SeparatorNav2.Name = "SeparatorNav2";
            this.SeparatorNav2.Size = new System.Drawing.Size(6, 43);
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
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(40, 40);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvarClick);
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
            // buttonDeletar
            // 
            this.buttonDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDeletar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletar.Image")));
            this.buttonDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(40, 40);
            this.buttonDeletar.Text = "Deletar registro";
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // SeparatorFim
            // 
            this.SeparatorFim.Name = "SeparatorFim";
            this.SeparatorFim.Size = new System.Drawing.Size(6, 43);
            // 
            // btnIniciaPesquisa
            // 
            this.btnIniciaPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciaPesquisa.Image")));
            this.btnIniciaPesquisa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIniciaPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIniciaPesquisa.Name = "btnIniciaPesquisa";
            this.btnIniciaPesquisa.Size = new System.Drawing.Size(124, 40);
            this.btnIniciaPesquisa.Text = "Iniciar Pesquisa";
            this.btnIniciaPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIniciaPesquisa.Click += new System.EventHandler(this.btnIniciaPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 40);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbCriterioBusca
            // 
            this.cbCriterioBusca.AutoSize = false;
            this.cbCriterioBusca.Enabled = false;
            this.cbCriterioBusca.Items.AddRange(new object[] {
            "E",
            "OU"});
            this.cbCriterioBusca.Name = "cbCriterioBusca";
            this.cbCriterioBusca.Size = new System.Drawing.Size(50, 23);
            this.cbCriterioBusca.ToolTipText = "Critério de busca";
            // 
            // dtPicImagem
            // 
            this.dtPicImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtPicImagem.CaminhoImagem = null;
            this.dtPicImagem.Field = null;
            this.dtPicImagem.Location = new System.Drawing.Point(550, 118);
            this.dtPicImagem.Name = "dtPicImagem";
            this.dtPicImagem.Property = null;
            this.dtPicImagem.Size = new System.Drawing.Size(152, 194);
            this.dtPicImagem.TabIndex = 16;
            // 
            // rbA
            // 
            this.rbA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbA.BackgroundImage")));
            this.rbA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbA.FlatAppearance.BorderSize = 0;
            this.rbA.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbA.ImagemChecked = ((System.Drawing.Image)(resources.GetObject("rbA.ImagemChecked")));
            this.rbA.ImagemUnChecked = ((System.Drawing.Image)(resources.GetObject("rbA.ImagemUnChecked")));
            this.rbA.Location = new System.Drawing.Point(41, 191);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(23, 24);
            this.rbA.TabIndex = 24;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbB.BackgroundImage")));
            this.rbB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbB.FlatAppearance.BorderSize = 0;
            this.rbB.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbB.ImagemChecked = ((System.Drawing.Image)(resources.GetObject("rbB.ImagemChecked")));
            this.rbB.ImagemUnChecked = ((System.Drawing.Image)(resources.GetObject("rbB.ImagemUnChecked")));
            this.rbB.Location = new System.Drawing.Point(41, 266);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(23, 24);
            this.rbB.TabIndex = 25;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbC.BackgroundImage")));
            this.rbC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbC.FlatAppearance.BorderSize = 0;
            this.rbC.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbC.ImagemChecked = ((System.Drawing.Image)(resources.GetObject("rbC.ImagemChecked")));
            this.rbC.ImagemUnChecked = ((System.Drawing.Image)(resources.GetObject("rbC.ImagemUnChecked")));
            this.rbC.Location = new System.Drawing.Point(41, 341);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(23, 24);
            this.rbC.TabIndex = 26;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbD.BackgroundImage")));
            this.rbD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbD.FlatAppearance.BorderSize = 0;
            this.rbD.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbD.ImagemChecked = ((System.Drawing.Image)(resources.GetObject("rbD.ImagemChecked")));
            this.rbD.ImagemUnChecked = ((System.Drawing.Image)(resources.GetObject("rbD.ImagemUnChecked")));
            this.rbD.Location = new System.Drawing.Point(41, 416);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(23, 24);
            this.rbD.TabIndex = 27;
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.simulandoDBDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questaoBindingSource, "Q_IdCategoria", true));
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "Cat_Descricao";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(71, 78);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(399, 21);
            this.cbCategoria.TabIndex = 27;
            this.cbCategoria.ValueMember = "Id";
            // 
            // buttonAddCategoria
            // 
            this.buttonAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategoria.Location = new System.Drawing.Point(476, 78);
            this.buttonAddCategoria.Name = "buttonAddCategoria";
            this.buttonAddCategoria.Size = new System.Drawing.Size(21, 20);
            this.buttonAddCategoria.TabIndex = 28;
            this.buttonAddCategoria.Text = "+";
            this.buttonAddCategoria.UseVisualStyleBackColor = true;
            this.buttonAddCategoria.Click += new System.EventHandler(this.buttonAddCategoria_Click);
            // 
            // srcNivel
            // 
            this.srcNivel.BottomMargin = 1;
            this.srcNivel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedStar", this.questaoBindingSource, "Q_NivelQuestao", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.srcNivel.HoverColor = System.Drawing.Color.Yellow;
            this.srcNivel.LeftMargin = 2;
            this.srcNivel.Location = new System.Drawing.Point(503, 78);
            this.srcNivel.Name = "srcNivel";
            this.srcNivel.OutlineColor = System.Drawing.Color.DarkGray;
            this.srcNivel.OutlineThickness = 1;
            this.srcNivel.RightMargin = 2;
            this.srcNivel.SelectedColor = System.Drawing.Color.RoyalBlue;
            this.srcNivel.SelectedStar = 0;
            this.srcNivel.Size = new System.Drawing.Size(116, 19);
            this.srcNivel.StarCount = 5;
            this.srcNivel.StarSpacing = 5;
            this.srcNivel.TabIndex = 30;
            this.srcNivel.TopMargin = 1;
            // 
            // btnSelecionarQuestao
            // 
            this.btnSelecionarQuestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarQuestao.Location = new System.Drawing.Point(550, 366);
            this.btnSelecionarQuestao.Name = "btnSelecionarQuestao";
            this.btnSelecionarQuestao.Size = new System.Drawing.Size(149, 51);
            this.btnSelecionarQuestao.TabIndex = 31;
            this.btnSelecionarQuestao.Text = "Selecionar Questão";
            this.btnSelecionarQuestao.UseVisualStyleBackColor = true;
            this.btnSelecionarQuestao.Click += new System.EventHandler(this.btnSelecionarQuestao_Click);
            // 
            // FrmCadQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.btnSelecionarQuestao);
            this.Controls.Add(this.srcNivel);
            this.Controls.Add(this.buttonAddCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(q_IdCategoriaLabel);
            this.Controls.Add(q_NivelQuestaoLabel);
            this.Controls.Add(this.dtPicImagem);
            this.Controls.Add(this.bindingNavigatorDados);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(q_TextoLabel);
            this.Controls.Add(this.txtTextoQuestao);
            this.Controls.Add(q_RespostaALabel);
            this.Controls.Add(this.txtRespostaA);
            this.Controls.Add(q_RespostaBLabel);
            this.Controls.Add(this.txtRespostaB);
            this.Controls.Add(q_RespostaCLabel);
            this.Controls.Add(this.txtRespostaC);
            this.Controls.Add(q_RespostaDLabel);
            this.Controls.Add(this.txtRespostaD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadQuestao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de questões";
            this.Load += new System.EventHandler(this.FrmCadQuestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private System.Windows.Forms.BindingSource questaoBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter questaoTableAdapter;
        private Data.SimulandoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CustomControls.Data.DataTextBox txtId;
        private System.Windows.Forms.TextBox txtTextoQuestao;
        private System.Windows.Forms.TextBox txtRespostaA;
        private System.Windows.Forms.TextBox txtRespostaB;
        private System.Windows.Forms.TextBox txtRespostaC;
        private System.Windows.Forms.TextBox txtRespostaD;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDados;
        private System.Windows.Forms.ToolStripButton buttonInserir;
        private System.Windows.Forms.ToolStripButton buttonPrimeiro;
        private System.Windows.Forms.ToolStripButton buttonAnterior;
        private System.Windows.Forms.ToolStripSeparator SeparatorNav1;
        private System.Windows.Forms.ToolStripButton buttonProximo;
        private System.Windows.Forms.ToolStripButton buttonUltimo;
        private System.Windows.Forms.ToolStripSeparator SeparatorNav2;
        private System.Windows.Forms.ToolStripButton buttonAtualizar;
        private System.Windows.Forms.ToolStripButton buttonEditar;
        private System.Windows.Forms.ToolStripButton buttonSalvar;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripButton buttonDeletar;
        private System.Windows.Forms.ToolStripSeparator SeparatorFim;
        private CustomControls.Data.DataPictureBox dtPicImagem;
        private CustomControls.Data.DataRadioButton rbA;
        private CustomControls.Data.DataRadioButton rbB;
        private CustomControls.Data.DataRadioButton rbC;
        private CustomControls.Data.DataRadioButton rbD;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button buttonAddCategoria;
        private CustomControls.Data.StarRatingControl srcNivel;
        private System.Windows.Forms.Button btnSelecionarQuestao;
        private System.Windows.Forms.ToolStripButton btnIniciaPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.ToolStripComboBox cbCriterioBusca;

    }
}