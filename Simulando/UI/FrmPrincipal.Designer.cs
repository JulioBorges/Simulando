namespace Simulando.UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.buttonParametros = new System.Windows.Forms.Button();
            this.buttonCadastrarAluno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParametros
            // 
            this.buttonParametros.Location = new System.Drawing.Point(12, 12);
            this.buttonParametros.Name = "buttonParametros";
            this.buttonParametros.Size = new System.Drawing.Size(157, 33);
            this.buttonParametros.TabIndex = 0;
            this.buttonParametros.Text = "Parâmetros";
            this.buttonParametros.UseVisualStyleBackColor = true;
            this.buttonParametros.Click += new System.EventHandler(this.buttonParametros_Click);
            // 
            // buttonCadastrarAluno
            // 
            this.buttonCadastrarAluno.Location = new System.Drawing.Point(12, 51);
            this.buttonCadastrarAluno.Name = "buttonCadastrarAluno";
            this.buttonCadastrarAluno.Size = new System.Drawing.Size(157, 33);
            this.buttonCadastrarAluno.TabIndex = 1;
            this.buttonCadastrarAluno.Text = "Cadastrar Aluno";
            this.buttonCadastrarAluno.UseVisualStyleBackColor = true;
            this.buttonCadastrarAluno.Click += new System.EventHandler(this.buttonCadastrarAluno_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fazer Prova";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(183, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(583, 392);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Resultados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCadastrarAluno);
            this.Controls.Add(this.buttonParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulando.NET";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParametros;
        private System.Windows.Forms.Button buttonCadastrarAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button button2;

    }
}

