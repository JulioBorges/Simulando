namespace Simulando.UI
{
    partial class FrmSelecaoProva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecaoProva));
            this.simulandoDBDataSet = new Simulando.Data.SimulandoDBDataSet();
            this.comboBoxAluno = new System.Windows.Forms.ComboBox();
            this.provaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.ProvaTableAdapter();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new Simulando.Data.SimulandoDBDataSetTableAdapters.AlunoTableAdapter();
            this.comboBoxProva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRealizarProva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simulandoDBDataSet
            // 
            this.simulandoDBDataSet.DataSetName = "SimulandoDBDataSet";
            this.simulandoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAluno
            // 
            this.comboBoxAluno.DataSource = this.alunoBindingSource;
            this.comboBoxAluno.DisplayMember = "Al_Nome";
            this.comboBoxAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAluno.FormattingEnabled = true;
            this.comboBoxAluno.Location = new System.Drawing.Point(12, 33);
            this.comboBoxAluno.Name = "comboBoxAluno";
            this.comboBoxAluno.Size = new System.Drawing.Size(495, 24);
            this.comboBoxAluno.TabIndex = 0;
            this.comboBoxAluno.ValueMember = "Id";
            // 
            // provaBindingSource
            // 
            this.provaBindingSource.AllowNew = false;
            this.provaBindingSource.DataMember = "Prova";
            this.provaBindingSource.DataSource = this.simulandoDBDataSet;
            // 
            // provaTableAdapter
            // 
            this.provaTableAdapter.ClearBeforeFill = true;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.AllowNew = false;
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.simulandoDBDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxProva
            // 
            this.comboBoxProva.DataSource = this.provaBindingSource;
            this.comboBoxProva.DisplayMember = "Prv_Descricao";
            this.comboBoxProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProva.FormattingEnabled = true;
            this.comboBoxProva.Location = new System.Drawing.Point(12, 89);
            this.comboBoxProva.Name = "comboBoxProva";
            this.comboBoxProva.Size = new System.Drawing.Size(495, 24);
            this.comboBoxProva.TabIndex = 1;
            this.comboBoxProva.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aluno:";
            // 
            // buttonRealizarProva
            // 
            this.buttonRealizarProva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRealizarProva.Location = new System.Drawing.Point(101, 119);
            this.buttonRealizarProva.Name = "buttonRealizarProva";
            this.buttonRealizarProva.Size = new System.Drawing.Size(317, 58);
            this.buttonRealizarProva.TabIndex = 3;
            this.buttonRealizarProva.Text = "Realizar Prova";
            this.buttonRealizarProva.UseVisualStyleBackColor = true;
            this.buttonRealizarProva.Click += new System.EventHandler(this.buttonRealizarProva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prova:";
            // 
            // FrmSelecaoProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRealizarProva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProva);
            this.Controls.Add(this.comboBoxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelecaoProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de prova";
            this.Load += new System.EventHandler(this.FrmSelecaoProva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulandoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.SimulandoDBDataSet simulandoDBDataSet;
        private System.Windows.Forms.ComboBox comboBoxAluno;
        private System.Windows.Forms.BindingSource provaBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.ProvaTableAdapter provaTableAdapter;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private Data.SimulandoDBDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRealizarProva;
        private System.Windows.Forms.Label label2;
    }
}