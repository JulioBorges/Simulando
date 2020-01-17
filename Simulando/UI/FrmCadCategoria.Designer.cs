namespace Simulando.UI
{
    partial class FrmCadCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCategoria));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label cat_DescricaoLabel;
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
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new CustomControls.Data.DataTextBox();
            this.categoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            cat_DescricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = this.buttonInserir;
            this.bindingNavigatorDados.BindingSource = this.categoriaBindingSource;
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
            this.bindingNavigatorDados.Size = new System.Drawing.Size(472, 43);
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
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.simulandoDBDataSet;
            this.categoriaBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.categoriaBindingSource_AddingNew);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ParametrosTableAdapter = null;
            this.tableAdapterManager.QuestaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "Cód.:";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(16, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 17;
            // 
            // cat_DescricaoLabel
            // 
            cat_DescricaoLabel.AutoSize = true;
            cat_DescricaoLabel.Location = new System.Drawing.Point(85, 50);
            cat_DescricaoLabel.Name = "cat_DescricaoLabel";
            cat_DescricaoLabel.Size = new System.Drawing.Size(58, 13);
            cat_DescricaoLabel.TabIndex = 17;
            cat_DescricaoLabel.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Cat_Descricao", true));
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Field = null;
            this.txtDescricao.Location = new System.Drawing.Point(88, 66);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Property = null;
            this.txtDescricao.Size = new System.Drawing.Size(368, 20);
            this.txtDescricao.TabIndex = 18;
            this.txtDescricao.TipoValidacao = CustomControls.Data.TipoTexto.Geral;
            // 
            // categoriaDataGridView
            // 
            this.categoriaDataGridView.AllowUserToAddRows = false;
            this.categoriaDataGridView.AllowUserToDeleteRows = false;
            this.categoriaDataGridView.AutoGenerateColumns = false;
            this.categoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.categoriaDataGridView.DataSource = this.categoriaBindingSource;
            this.categoriaDataGridView.Location = new System.Drawing.Point(16, 102);
            this.categoriaDataGridView.MultiSelect = false;
            this.categoriaDataGridView.Name = "categoriaDataGridView";
            this.categoriaDataGridView.ReadOnly = true;
            this.categoriaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriaDataGridView.Size = new System.Drawing.Size(440, 201);
            this.categoriaDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cat_Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // FrmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 322);
            this.Controls.Add(this.categoriaDataGridView);
            this.Controls.Add(cat_DescricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bindingNavigatorDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de categorias";
            this.Load += new System.EventHandler(this.FrmCadCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Data.SimulandoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private CustomControls.Data.DataTextBox txtDescricao;
        private System.Windows.Forms.DataGridView categoriaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}