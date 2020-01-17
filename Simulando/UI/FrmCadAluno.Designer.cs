namespace Simulando.UI
{
    partial class FrmCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadAluno));
            this.bindingNavigatorDados = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonInserir = new System.Windows.Forms.ToolStripButton();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.buttonPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.buttonAnterior = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonProximo = new System.Windows.Forms.ToolStripButton();
            this.buttonUltimo = new System.Windows.Forms.ToolStripButton();
            this.SeparatorNav2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.buttonSalvar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonDeletar = new System.Windows.Forms.ToolStripButton();
            this.SeparatorFim = new System.Windows.Forms.ToolStripSeparator();
            this.alunoTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.AlunoTableAdapter();
            this.tableAdapterManager = new Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager();
            this.alunoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).BeginInit();
            this.bindingNavigatorDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorDados
            // 
            this.bindingNavigatorDados.AddNewItem = this.buttonInserir;
            this.bindingNavigatorDados.BindingSource = this.alunoBindingSource;
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
            this.bindingNavigatorDados.Size = new System.Drawing.Size(614, 43);
            this.bindingNavigatorDados.TabIndex = 17;
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
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.simulandoDBDataSet;
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // buttonSalvar
            // 
            this.buttonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ParametrosTableAdapter = null;
            this.tableAdapterManager.ProvaTableAdapter = null;
            this.tableAdapterManager.QuestaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Simulando.Data.SimulandoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoDataGridView
            // 
            this.alunoDataGridView.AllowUserToAddRows = false;
            this.alunoDataGridView.AllowUserToDeleteRows = false;
            this.alunoDataGridView.AutoGenerateColumns = false;
            this.alunoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.alunoDataGridView.DataSource = this.alunoBindingSource;
            this.alunoDataGridView.Location = new System.Drawing.Point(12, 46);
            this.alunoDataGridView.Name = "alunoDataGridView";
            this.alunoDataGridView.Size = new System.Drawing.Size(589, 291);
            this.alunoDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Al_Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Al_Idade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // FrmCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 349);
            this.Controls.Add(this.alunoDataGridView);
            this.Controls.Add(this.bindingNavigatorDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadAluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadAluno_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDados)).EndInit();
            this.bindingNavigatorDados.ResumeLayout(false);
            this.bindingNavigatorDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripButton buttonSalvar;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripButton buttonDeletar;
        private System.Windows.Forms.ToolStripSeparator SeparatorFim;
        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private Data.SimulandoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView alunoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}