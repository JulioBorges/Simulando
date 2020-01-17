namespace Simulando.UI
{
    partial class FrmRealizacaoProva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealizacaoProva));
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.questaoTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter();
            this.timerTempo = new System.Windows.Forms.Timer(this.components);
            this.tabControlProva = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelIniciando = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelTxt = new System.Windows.Forms.Label();
            this.labelAtencao = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBoxTeclas = new System.Windows.Forms.GroupBox();
            this.tabItemAlinhamento = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRespD = new System.Windows.Forms.Label();
            this.txtRespC = new System.Windows.Forms.Label();
            this.txtRespB = new System.Windows.Forms.Label();
            this.txtRespA = new System.Windows.Forms.Label();
            this.txtTextoQuestao = new System.Windows.Forms.Label();
            this.pictureBoxImgQuestao = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxQuestoesVisao = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTempo = new System.Windows.Forms.Label();
            this.txtIdadeAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItemProva = new DevComponents.DotNetBar.TabItem(this.components);
            this.parametrosTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.ParametrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlProva)).BeginInit();
            this.tabControlProva.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.panelIniciando.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgQuestao)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questaoTableAdapter
            // 
            this.questaoTableAdapter.ClearBeforeFill = true;
            // 
            // timerTempo
            // 
            this.timerTempo.Interval = 1000;
            this.timerTempo.Tick += new System.EventHandler(this.timerTempo_Tick);
            // 
            // tabControlProva
            // 
            this.tabControlProva.BackColor = System.Drawing.Color.Transparent;
            this.tabControlProva.CanReorderTabs = false;
            this.tabControlProva.Controls.Add(this.tabControlPanel1);
            this.tabControlProva.Controls.Add(this.tabControlPanel2);
            this.tabControlProva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProva.Location = new System.Drawing.Point(0, 0);
            this.tabControlProva.Name = "tabControlProva";
            this.tabControlProva.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControlProva.SelectedTabIndex = 1;
            this.tabControlProva.Size = new System.Drawing.Size(772, 526);
            this.tabControlProva.Style = DevComponents.DotNetBar.eTabStripStyle.Flat;
            this.tabControlProva.TabIndex = 13;
            this.tabControlProva.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tabControlProva.Tabs.Add(this.tabItemProva);
            this.tabControlProva.Tabs.Add(this.tabItemAlinhamento);
            this.tabControlProva.TabsVisible = false;
            this.tabControlProva.Text = "Prova";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.panelIniciando);
            this.tabControlPanel2.Controls.Add(this.buttonFechar);
            this.tabControlPanel2.Controls.Add(this.labelTxt);
            this.tabControlPanel2.Controls.Add(this.labelAtencao);
            this.tabControlPanel2.Controls.Add(this.btnAnterior);
            this.tabControlPanel2.Controls.Add(this.btnE);
            this.tabControlPanel2.Controls.Add(this.btnD);
            this.tabControlPanel2.Controls.Add(this.btnProxima);
            this.tabControlPanel2.Controls.Add(this.btnFinalizar);
            this.tabControlPanel2.Controls.Add(this.btnIniciar);
            this.tabControlPanel2.Controls.Add(this.btnLimpar);
            this.tabControlPanel2.Controls.Add(this.btnC);
            this.tabControlPanel2.Controls.Add(this.btnB);
            this.tabControlPanel2.Controls.Add(this.btnA);
            this.tabControlPanel2.Controls.Add(this.groupBoxTeclas);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(772, 501);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItemAlinhamento;
            this.tabControlPanel2.Text = "alinhar";
            // 
            // panelIniciando
            // 
            this.panelIniciando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIniciando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIniciando.Controls.Add(this.label18);
            this.panelIniciando.Controls.Add(this.label17);
            this.panelIniciando.Controls.Add(this.label16);
            this.panelIniciando.Controls.Add(this.label15);
            this.panelIniciando.Controls.Add(this.label14);
            this.panelIniciando.Controls.Add(this.label13);
            this.panelIniciando.Controls.Add(this.label12);
            this.panelIniciando.Controls.Add(this.label11);
            this.panelIniciando.Location = new System.Drawing.Point(109, 93);
            this.panelIniciando.Name = "panelIniciando";
            this.panelIniciando.Size = new System.Drawing.Size(555, 315);
            this.panelIniciando.TabIndex = 30;
            this.panelIniciando.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(60, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 18);
            this.label18.TabIndex = 7;
            this.label18.Text = "LIMPAR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Yellow;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(218, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 18);
            this.label17.TabIndex = 6;
            this.label17.Text = "PRÓXIMA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(115, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 5;
            this.label16.Text = "ANTERIOR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(231, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "FINALIZAR";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(552, 198);
            this.label14.TabIndex = 3;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "INICIAR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(107, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "PARA INICIAR A PROVA CLIQUE EM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Teclas Alinhadas com sucesso !!!";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Location = new System.Drawing.Point(697, 1);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 29;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelTxt
            // 
            this.labelTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxt.Location = new System.Drawing.Point(1, 24);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(770, 35);
            this.labelTxt.TabIndex = 28;
            this.labelTxt.Text = "Antes de iniciar a prova é necessário que se verifique o funcionamento dos botões" +
    ".\r\nAo clicar, a tecla irá se destacar.";
            this.labelTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtencao
            // 
            this.labelAtencao.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtencao.Location = new System.Drawing.Point(1, 1);
            this.labelAtencao.Name = "labelAtencao";
            this.labelAtencao.Size = new System.Drawing.Size(770, 23);
            this.labelAtencao.TabIndex = 28;
            this.labelAtencao.Text = "Atenção ! ! !";
            this.labelAtencao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnterior.BackColor = System.Drawing.Color.Yellow;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(245, 284);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(138, 56);
            this.btnAnterior.TabIndex = 26;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnE.BackColor = System.Drawing.SystemColors.Window;
            this.btnE.Enabled = false;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(389, 346);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(138, 56);
            this.btnE.TabIndex = 21;
            this.btnE.TabStop = false;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnD.BackColor = System.Drawing.SystemColors.Window;
            this.btnD.Enabled = false;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(389, 284);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(138, 56);
            this.btnD.TabIndex = 20;
            this.btnD.TabStop = false;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProxima.BackColor = System.Drawing.Color.Yellow;
            this.btnProxima.Enabled = false;
            this.btnProxima.FlatAppearance.BorderSize = 0;
            this.btnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.Location = new System.Drawing.Point(245, 222);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(138, 56);
            this.btnProxima.TabIndex = 25;
            this.btnProxima.TabStop = false;
            this.btnProxima.Text = "PRÓXIMA";
            this.btnProxima.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.BackColor = System.Drawing.Color.Red;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizar.Location = new System.Drawing.Point(245, 160);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 56);
            this.btnFinalizar.TabIndex = 24;
            this.btnFinalizar.TabStop = false;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciar.Enabled = false;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(245, 99);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(138, 56);
            this.btnIniciar.TabIndex = 23;
            this.btnIniciar.TabStop = false;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(245, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 56);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnC.BackColor = System.Drawing.SystemColors.Window;
            this.btnC.Enabled = false;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(389, 222);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(138, 56);
            this.btnC.TabIndex = 19;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.BackColor = System.Drawing.SystemColors.Window;
            this.btnB.Enabled = false;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(389, 160);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(138, 56);
            this.btnB.TabIndex = 18;
            this.btnB.TabStop = false;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.BackColor = System.Drawing.SystemColors.Window;
            this.btnA.Enabled = false;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(389, 98);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(138, 56);
            this.btnA.TabIndex = 17;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // groupBoxTeclas
            // 
            this.groupBoxTeclas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTeclas.Location = new System.Drawing.Point(225, 77);
            this.groupBoxTeclas.Name = "groupBoxTeclas";
            this.groupBoxTeclas.Size = new System.Drawing.Size(323, 346);
            this.groupBoxTeclas.TabIndex = 27;
            this.groupBoxTeclas.TabStop = false;
            // 
            // tabItemAlinhamento
            // 
            this.tabItemAlinhamento.AttachedControl = this.tabControlPanel2;
            this.tabItemAlinhamento.Name = "tabItemAlinhamento";
            this.tabItemAlinhamento.Text = "alinha";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.panel3);
            this.tabControlPanel1.Controls.Add(this.panel2);
            this.tabControlPanel1.Controls.Add(this.panel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(772, 501);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.SystemColors.Control;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItemProva;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtRespD);
            this.panel3.Controls.Add(this.txtRespC);
            this.panel3.Controls.Add(this.txtRespB);
            this.panel3.Controls.Add(this.txtRespA);
            this.panel3.Controls.Add(this.txtTextoQuestao);
            this.panel3.Controls.Add(this.pictureBoxImgQuestao);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(60, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 362);
            this.panel3.TabIndex = 5;
            // 
            // txtRespD
            // 
            this.txtRespD.BackColor = System.Drawing.SystemColors.Window;
            this.txtRespD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespD.Location = new System.Drawing.Point(42, 297);
            this.txtRespD.Name = "txtRespD";
            this.txtRespD.Size = new System.Drawing.Size(480, 57);
            this.txtRespD.TabIndex = 11;
            // 
            // txtRespC
            // 
            this.txtRespC.BackColor = System.Drawing.SystemColors.Window;
            this.txtRespC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespC.Location = new System.Drawing.Point(42, 232);
            this.txtRespC.Name = "txtRespC";
            this.txtRespC.Size = new System.Drawing.Size(480, 57);
            this.txtRespC.TabIndex = 10;
            // 
            // txtRespB
            // 
            this.txtRespB.BackColor = System.Drawing.SystemColors.Window;
            this.txtRespB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespB.Location = new System.Drawing.Point(42, 167);
            this.txtRespB.Name = "txtRespB";
            this.txtRespB.Size = new System.Drawing.Size(480, 57);
            this.txtRespB.TabIndex = 9;
            // 
            // txtRespA
            // 
            this.txtRespA.BackColor = System.Drawing.SystemColors.Window;
            this.txtRespA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespA.Location = new System.Drawing.Point(42, 102);
            this.txtRespA.Name = "txtRespA";
            this.txtRespA.Size = new System.Drawing.Size(480, 57);
            this.txtRespA.TabIndex = 8;
            // 
            // txtTextoQuestao
            // 
            this.txtTextoQuestao.BackColor = System.Drawing.SystemColors.Window;
            this.txtTextoQuestao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTextoQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoQuestao.Location = new System.Drawing.Point(8, 24);
            this.txtTextoQuestao.Name = "txtTextoQuestao";
            this.txtTextoQuestao.Size = new System.Drawing.Size(692, 66);
            this.txtTextoQuestao.TabIndex = 7;
            // 
            // pictureBoxImgQuestao
            // 
            this.pictureBoxImgQuestao.Location = new System.Drawing.Point(556, 102);
            this.pictureBoxImgQuestao.Name = "pictureBoxImgQuestao";
            this.pictureBoxImgQuestao.Size = new System.Drawing.Size(144, 129);
            this.pictureBoxImgQuestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgQuestao.TabIndex = 6;
            this.pictureBoxImgQuestao.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "D)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "B)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "A)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Questão:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBoxQuestoesVisao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(1, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 362);
            this.panel2.TabIndex = 4;
            // 
            // listBoxQuestoesVisao
            // 
            this.listBoxQuestoesVisao.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxQuestoesVisao.Enabled = false;
            this.listBoxQuestoesVisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestoesVisao.FormattingEnabled = true;
            this.listBoxQuestoesVisao.ItemHeight = 15;
            this.listBoxQuestoesVisao.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.listBoxQuestoesVisao.Location = new System.Drawing.Point(0, 0);
            this.listBoxQuestoesVisao.Name = "listBoxQuestoesVisao";
            this.listBoxQuestoesVisao.Size = new System.Drawing.Size(52, 360);
            this.listBoxQuestoesVisao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTempo);
            this.panel1.Controls.Add(this.txtIdadeAluno);
            this.panel1.Controls.Add(this.txtNomeAluno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxLogoEmpresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 137);
            this.panel1.TabIndex = 2;
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempo.Location = new System.Drawing.Point(275, 102);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(221, 20);
            this.labelTempo.TabIndex = 6;
            this.labelTempo.Text = "Tempo restante - 00:00:00";
            // 
            // txtIdadeAluno
            // 
            this.txtIdadeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeAluno.Location = new System.Drawing.Point(67, 103);
            this.txtIdadeAluno.Name = "txtIdadeAluno";
            this.txtIdadeAluno.ReadOnly = true;
            this.txtIdadeAluno.ShortcutsEnabled = false;
            this.txtIdadeAluno.Size = new System.Drawing.Size(56, 21);
            this.txtIdadeAluno.TabIndex = 4;
            this.txtIdadeAluno.TabStop = false;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(67, 76);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.ReadOnly = true;
            this.txtNomeAluno.ShortcutsEnabled = false;
            this.txtNomeAluno.Size = new System.Drawing.Size(501, 21);
            this.txtNomeAluno.TabIndex = 4;
            this.txtNomeAluno.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aluno: ";
            // 
            // pictureBoxLogoEmpresa
            // 
            this.pictureBoxLogoEmpresa.Location = new System.Drawing.Point(580, 11);
            this.pictureBoxLogoEmpresa.Name = "pictureBoxLogoEmpresa";
            this.pictureBoxLogoEmpresa.Size = new System.Drawing.Size(171, 111);
            this.pictureBoxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoEmpresa.TabIndex = 1;
            this.pictureBoxLogoEmpresa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulando.NET\r\nProva simulada - Teste teórico Técnico.";
            // 
            // tabItemProva
            // 
            this.tabItemProva.AttachedControl = this.tabControlPanel1;
            this.tabItemProva.Name = "tabItemProva";
            this.tabItemProva.Text = "Prova";
            // 
            // parametrosTableAdapter
            // 
            this.parametrosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRealizacaoProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 526);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlProva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmRealizacaoProva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRealizacaoProva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRealizacaoProva_FormClosing);
            this.Load += new System.EventHandler(this.FrmRealizacaoProva_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmRealizacaoProva_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlProva)).EndInit();
            this.tabControlProva.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.panelIniciando.ResumeLayout(false);
            this.panelIniciando.PerformLayout();
            this.tabControlPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgQuestao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private Data.SimulandoDBDataSetTableAdapters.QuestaoTableAdapter questaoTableAdapter;
        private System.Windows.Forms.Timer timerTempo;
        private DevComponents.DotNetBar.TabControl tabControlProva;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtRespD;
        private System.Windows.Forms.Label txtRespC;
        private System.Windows.Forms.Label txtRespB;
        private System.Windows.Forms.Label txtRespA;
        private System.Windows.Forms.Label txtTextoQuestao;
        private System.Windows.Forms.PictureBox pictureBoxImgQuestao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxQuestoesVisao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.TextBox txtIdadeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogoEmpresa;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.TabItem tabItemProva;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItemAlinhamento;
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
        private System.Windows.Forms.GroupBox groupBoxTeclas;
        private System.Windows.Forms.Label labelAtencao;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Panel panelIniciando;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Data.SimulandoDBDataSetTableAdapters.ParametrosTableAdapter parametrosTableAdapter;
    }
}