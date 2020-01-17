namespace Simulando.UI
{
    partial class FrmCadProva
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
            System.Windows.Forms.Label prv_DescricaoLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label q_TextoLabel;
            System.Windows.Forms.Label q_RespostaALabel;
            System.Windows.Forms.Label q_RespostaBLabel;
            System.Windows.Forms.Label q_RespostaCLabel;
            System.Windows.Forms.Label q_RespostaDLabel;
            System.Windows.Forms.Label q_IdCategoriaLabel;
            System.Windows.Forms.Label q_NivelQuestaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProva));
            this.groupBoxQuestao = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.pctImagemQuestao = new System.Windows.Forms.PictureBox();
            this.srcNivel = new CustomControls.Data.StarRatingControl();
            this.rbD = new CustomControls.Data.DataRadioButton();
            this.rbC = new CustomControls.Data.DataRadioButton();
            this.rbB = new CustomControls.Data.DataRadioButton();
            this.rbA = new CustomControls.Data.DataRadioButton();
            this.txtTextoQuestao = new System.Windows.Forms.TextBox();
            this.txtRespostaA = new System.Windows.Forms.TextBox();
            this.txtRespostaB = new System.Windows.Forms.TextBox();
            this.txtRespostaC = new System.Windows.Forms.TextBox();
            this.txtRespostaD = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.bindingNavigatorDados = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonInserir = new System.Windows.Forms.ToolStripButton();
            this.provaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.provaTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.ProvaTableAdapter();
            this.tableAdapterManager = new Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter();
            this.questaoTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblNrQuestao = new System.Windows.Forms.Label();
            this.btnProximaQuestao = new System.Windows.Forms.Button();
            this.btnQuestaoAnterior = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            prv_DescricaoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            q_TextoLabel = new System.Windows.Forms.Label();
            q_RespostaALabel = new System.Windows.Forms.Label();
            q_RespostaBLabel = new System.Windows.Forms.Label();
            q_RespostaCLabel = new System.Windows.Forms.Label();
            q_RespostaDLabel = new System.Windows.Forms.Label();
            q_IdCategoriaLabel = new System.Windows.Forms.Label();
            q_NivelQuestaoLabel = new System.Windows.Forms.Label();
            this.groupBoxQuestao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemQuestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // prv_DescricaoLabel
            // 
            prv_DescricaoLabel.AutoSize = true;
            prv_DescricaoLabel.Location = new System.Drawing.Point(80, 44);
            prv_DescricaoLabel.Name = "prv_DescricaoLabel";
            prv_DescricaoLabel.Size = new System.Drawing.Size(77, 13);
            prv_DescricaoLabel.TabIndex = 17;
            prv_DescricaoLabel.Text = "Prv Descricao:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(22, 79);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Id:";
            // 
            // q_TextoLabel
            // 
            q_TextoLabel.AutoSize = true;
            q_TextoLabel.Location = new System.Drawing.Point(13, 59);
            q_TextoLabel.Name = "q_TextoLabel";
            q_TextoLabel.Size = new System.Drawing.Size(50, 13);
            q_TextoLabel.TabIndex = 32;
            q_TextoLabel.Text = "Questão:";
            // 
            // q_RespostaALabel
            // 
            q_RespostaALabel.AutoSize = true;
            q_RespostaALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaALabel.Location = new System.Drawing.Point(10, 135);
            q_RespostaALabel.Name = "q_RespostaALabel";
            q_RespostaALabel.Size = new System.Drawing.Size(20, 15);
            q_RespostaALabel.TabIndex = 34;
            q_RespostaALabel.Text = "A)";
            // 
            // q_RespostaBLabel
            // 
            q_RespostaBLabel.AutoSize = true;
            q_RespostaBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaBLabel.Location = new System.Drawing.Point(10, 170);
            q_RespostaBLabel.Name = "q_RespostaBLabel";
            q_RespostaBLabel.Size = new System.Drawing.Size(21, 15);
            q_RespostaBLabel.TabIndex = 36;
            q_RespostaBLabel.Text = "B)";
            // 
            // q_RespostaCLabel
            // 
            q_RespostaCLabel.AutoSize = true;
            q_RespostaCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaCLabel.Location = new System.Drawing.Point(10, 205);
            q_RespostaCLabel.Name = "q_RespostaCLabel";
            q_RespostaCLabel.Size = new System.Drawing.Size(21, 15);
            q_RespostaCLabel.TabIndex = 38;
            q_RespostaCLabel.Text = "C)";
            // 
            // q_RespostaDLabel
            // 
            q_RespostaDLabel.AutoSize = true;
            q_RespostaDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            q_RespostaDLabel.Location = new System.Drawing.Point(10, 240);
            q_RespostaDLabel.Name = "q_RespostaDLabel";
            q_RespostaDLabel.Size = new System.Drawing.Size(22, 15);
            q_RespostaDLabel.TabIndex = 40;
            q_RespostaDLabel.Text = "D)";
            // 
            // q_IdCategoriaLabel
            // 
            q_IdCategoriaLabel.AutoSize = true;
            q_IdCategoriaLabel.Location = new System.Drawing.Point(10, 19);
            q_IdCategoriaLabel.Name = "q_IdCategoriaLabel";
            q_IdCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            q_IdCategoriaLabel.TabIndex = 48;
            q_IdCategoriaLabel.Text = "Categoria:";
            // 
            // q_NivelQuestaoLabel
            // 
            q_NivelQuestaoLabel.AutoSize = true;
            q_NivelQuestaoLabel.Location = new System.Drawing.Point(328, 19);
            q_NivelQuestaoLabel.Name = "q_NivelQuestaoLabel";
            q_NivelQuestaoLabel.Size = new System.Drawing.Size(34, 13);
            q_NivelQuestaoLabel.TabIndex = 47;
            q_NivelQuestaoLabel.Text = "Nivel:";
            // 
            // groupBoxQuestao
            // 
            this.groupBoxQuestao.Controls.Add(this.txtCategoria);
            this.groupBoxQuestao.Controls.Add(this.pctImagemQuestao);
            this.groupBoxQuestao.Controls.Add(q_IdCategoriaLabel);
            this.groupBoxQuestao.Controls.Add(q_NivelQuestaoLabel);
            this.groupBoxQuestao.Controls.Add(this.srcNivel);
            this.groupBoxQuestao.Controls.Add(this.rbD);
            this.groupBoxQuestao.Controls.Add(this.rbC);
            this.groupBoxQuestao.Controls.Add(this.rbB);
            this.groupBoxQuestao.Controls.Add(this.rbA);
            this.groupBoxQuestao.Controls.Add(q_TextoLabel);
            this.groupBoxQuestao.Controls.Add(this.txtTextoQuestao);
            this.groupBoxQuestao.Controls.Add(q_RespostaALabel);
            this.groupBoxQuestao.Controls.Add(this.txtRespostaA);
            this.groupBoxQuestao.Controls.Add(q_RespostaBLabel);
            this.groupBoxQuestao.Controls.Add(this.txtRespostaB);
            this.groupBoxQuestao.Controls.Add(q_RespostaCLabel);
            this.groupBoxQuestao.Controls.Add(this.txtRespostaC);
            this.groupBoxQuestao.Controls.Add(q_RespostaDLabel);
            this.groupBoxQuestao.Controls.Add(this.txtRespostaD);
            this.groupBoxQuestao.Controls.Add(idLabel1);
            this.groupBoxQuestao.Controls.Add(this.idTextBox1);
            this.groupBoxQuestao.Enabled = false;
            this.groupBoxQuestao.Location = new System.Drawing.Point(12, 136);
            this.groupBoxQuestao.Name = "groupBoxQuestao";
            this.groupBoxQuestao.Size = new System.Drawing.Size(599, 280);
            this.groupBoxQuestao.TabIndex = 4;
            this.groupBoxQuestao.TabStop = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(13, 36);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(309, 20);
            this.txtCategoria.TabIndex = 51;
            // 
            // pctImagemQuestao
            // 
            this.pctImagemQuestao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImagemQuestao.Location = new System.Drawing.Point(450, 19);
            this.pctImagemQuestao.Name = "pctImagemQuestao";
            this.pctImagemQuestao.Size = new System.Drawing.Size(139, 103);
            this.pctImagemQuestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagemQuestao.TabIndex = 50;
            this.pctImagemQuestao.TabStop = false;
            // 
            // srcNivel
            // 
            this.srcNivel.BottomMargin = 1;
            this.srcNivel.HoverColor = System.Drawing.Color.Yellow;
            this.srcNivel.LeftMargin = 2;
            this.srcNivel.Location = new System.Drawing.Point(328, 35);
            this.srcNivel.Name = "srcNivel";
            this.srcNivel.OutlineColor = System.Drawing.Color.DarkGray;
            this.srcNivel.OutlineThickness = 1;
            this.srcNivel.RightMargin = 2;
            this.srcNivel.SelectedColor = System.Drawing.Color.RoyalBlue;
            this.srcNivel.SelectedStar = 0;
            this.srcNivel.Size = new System.Drawing.Size(116, 19);
            this.srcNivel.StarCount = 5;
            this.srcNivel.StarSpacing = 5;
            this.srcNivel.TabIndex = 46;
            this.srcNivel.TopMargin = 1;
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
            this.rbD.Location = new System.Drawing.Point(36, 235);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(23, 24);
            this.rbD.TabIndex = 45;
            this.rbD.UseVisualStyleBackColor = true;
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
            this.rbC.Location = new System.Drawing.Point(36, 200);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(23, 24);
            this.rbC.TabIndex = 44;
            this.rbC.UseVisualStyleBackColor = true;
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
            this.rbB.Location = new System.Drawing.Point(36, 165);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(23, 24);
            this.rbB.TabIndex = 43;
            this.rbB.UseVisualStyleBackColor = true;
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
            this.rbA.Location = new System.Drawing.Point(36, 130);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(23, 24);
            this.rbA.TabIndex = 42;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // txtTextoQuestao
            // 
            this.txtTextoQuestao.Location = new System.Drawing.Point(13, 75);
            this.txtTextoQuestao.Multiline = true;
            this.txtTextoQuestao.Name = "txtTextoQuestao";
            this.txtTextoQuestao.Size = new System.Drawing.Size(431, 47);
            this.txtTextoQuestao.TabIndex = 33;
            // 
            // txtRespostaA
            // 
            this.txtRespostaA.Location = new System.Drawing.Point(66, 128);
            this.txtRespostaA.Multiline = true;
            this.txtRespostaA.Name = "txtRespostaA";
            this.txtRespostaA.Size = new System.Drawing.Size(523, 29);
            this.txtRespostaA.TabIndex = 35;
            // 
            // txtRespostaB
            // 
            this.txtRespostaB.Location = new System.Drawing.Point(66, 163);
            this.txtRespostaB.Multiline = true;
            this.txtRespostaB.Name = "txtRespostaB";
            this.txtRespostaB.Size = new System.Drawing.Size(523, 29);
            this.txtRespostaB.TabIndex = 37;
            // 
            // txtRespostaC
            // 
            this.txtRespostaC.Location = new System.Drawing.Point(66, 198);
            this.txtRespostaC.Multiline = true;
            this.txtRespostaC.Name = "txtRespostaC";
            this.txtRespostaC.Size = new System.Drawing.Size(523, 29);
            this.txtRespostaC.TabIndex = 39;
            // 
            // txtRespostaD
            // 
            this.txtRespostaD.Location = new System.Drawing.Point(66, 233);
            this.txtRespostaD.Multiline = true;
            this.txtRespostaD.Name = "txtRespostaD";
            this.txtRespostaD.Size = new System.Drawing.Size(523, 29);
            this.txtRespostaD.TabIndex = 41;
            // 
            // idTextBox1
            // 
            this.idTextBox1.Location = new System.Drawing.Point(47, 76);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = this.buttonInserir;
            this.bindingNavigatorDados.BindingSource = this.provaBindingSource;
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
            this.SeparatorFim});
            this.bindingNavigatorDados.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDados.MoveFirstItem = this.buttonPrimeiro;
            this.bindingNavigatorDados.MoveLastItem = this.buttonUltimo;
            this.bindingNavigatorDados.MoveNextItem = this.buttonProximo;
            this.bindingNavigatorDados.MovePreviousItem = this.buttonAnterior;
            this.bindingNavigatorDados.Name = "bindingNavigatorDados";
            this.bindingNavigatorDados.PositionItem = null;
            this.bindingNavigatorDados.Size = new System.Drawing.Size(625, 43);
            this.bindingNavigatorDados.TabIndex = 16;
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
            // provaBindingSource
            // 
            this.provaBindingSource.DataMember = "Prova";
            this.provaBindingSource.DataSource = this.simulandoDBDataSet;
            this.provaBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.provaBindingSource_BindingComplete);
            this.provaBindingSource.CurrentItemChanged += new System.EventHandler(this.provaBindingSource_CurrentItemChanged);
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
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
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
            // provaTableAdapter
            // 
            this.provaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ParametrosTableAdapter = null;
            this.tableAdapterManager.ProvaTableAdapter = this.provaTableAdapter;
            this.tableAdapterManager.QuestaoTableAdapter = this.questaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // questaoTableAdapter
            // 
            this.questaoTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provaBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 20);
            this.txtId.TabIndex = 17;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provaBindingSource, "Prv_Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(83, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(528, 20);
            this.txtDescricao.TabIndex = 18;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Location = new System.Drawing.Point(500, 105);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(111, 32);
            this.btnSelecionar.TabIndex = 19;
            this.btnSelecionar.Text = "Selecionar Questão";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblNrQuestao
            // 
            this.lblNrQuestao.AutoSize = true;
            this.lblNrQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrQuestao.Location = new System.Drawing.Point(12, 110);
            this.lblNrQuestao.Name = "lblNrQuestao";
            this.lblNrQuestao.Size = new System.Drawing.Size(102, 20);
            this.lblNrQuestao.TabIndex = 20;
            this.lblNrQuestao.Text = "Questão 01";
            // 
            // btnProximaQuestao
            // 
            this.btnProximaQuestao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProximaQuestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximaQuestao.Location = new System.Drawing.Point(164, 105);
            this.btnProximaQuestao.Name = "btnProximaQuestao";
            this.btnProximaQuestao.Size = new System.Drawing.Size(38, 32);
            this.btnProximaQuestao.TabIndex = 23;
            this.btnProximaQuestao.Text = ">>";
            this.btnProximaQuestao.UseVisualStyleBackColor = true;
            this.btnProximaQuestao.Click += new System.EventHandler(this.btnProximaQuestao_Click);
            // 
            // btnQuestaoAnterior
            // 
            this.btnQuestaoAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuestaoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestaoAnterior.Location = new System.Drawing.Point(120, 105);
            this.btnQuestaoAnterior.Name = "btnQuestaoAnterior";
            this.btnQuestaoAnterior.Size = new System.Drawing.Size(38, 32);
            this.btnQuestaoAnterior.TabIndex = 22;
            this.btnQuestaoAnterior.Text = "<<";
            this.btnQuestaoAnterior.UseVisualStyleBackColor = true;
            this.btnQuestaoAnterior.Click += new System.EventHandler(this.btnQuestaoAnterior_Click);
            // 
            // FrmCadProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 428);
            this.Controls.Add(this.btnProximaQuestao);
            this.Controls.Add(this.btnQuestaoAnterior);
            this.Controls.Add(this.lblNrQuestao);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(prv_DescricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bindingNavigatorDados);
            this.Controls.Add(this.groupBoxQuestao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Provas";
            this.Load += new System.EventHandler(this.FrmCadProva_Load);
            this.groupBoxQuestao.ResumeLayout(false);
            this.groupBoxQuestao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemQuestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuestao;
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
        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private System.Windows.Forms.BindingSource provaBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.ProvaTableAdapter provaTableAdapter;
        private Data.SimulandoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox idTextBox1;
        private CustomControls.Data.StarRatingControl srcNivel;
        private CustomControls.Data.DataRadioButton rbD;
        private CustomControls.Data.DataRadioButton rbC;
        private CustomControls.Data.DataRadioButton rbB;
        private CustomControls.Data.DataRadioButton rbA;
        private System.Windows.Forms.TextBox txtTextoQuestao;
        private System.Windows.Forms.TextBox txtRespostaA;
        private System.Windows.Forms.TextBox txtRespostaB;
        private System.Windows.Forms.TextBox txtRespostaC;
        private System.Windows.Forms.TextBox txtRespostaD;
        private System.Windows.Forms.PictureBox pctImagemQuestao;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblNrQuestao;
        private System.Windows.Forms.Button btnProximaQuestao;
        private System.Windows.Forms.Button btnQuestaoAnterior;
        private Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter questaoTableAdapter;
        private System.Windows.Forms.TextBox txtCategoria;
        private Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;


    }
}