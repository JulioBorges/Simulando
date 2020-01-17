using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls.Data;

namespace Simulando.UI
{
    public partial class FrmCadAluno : Form
    {
        public FrmCadAluno()
        {
            InitializeComponent();
        }

        private void FrmCadAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simulandoDBDataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.simulandoDBDataSet.Aluno);

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            ((DataRowView) alunoBindingSource.Current)["Id"] = tableAdapterManager.AlunoTableAdapter.GetId() ?? 1;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            alunoBindingSource.ResetCurrentItem();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SalvarRegistro();
            Mensagem.Aviso(this, "Aluno salvo com sucesso !");
        }

        private void SalvarRegistro()
        {
            Validate();
            alunoDataGridView.EndEdit();
            tableAdapterManager.UpdateAll(simulandoDBDataSet);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            alunoBindingSource.CancelEdit();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (alunoBindingSource.Count <= 0)
                return;

            if (Mensagem.Pergunta(this, "Deseja realmente excluir esta aluno?", DialogResult.No))
                return;
            try
            {
                alunoBindingSource.RemoveCurrent();
                Validate();
                alunoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
            }
            catch (Exception exc)
            {
                Mensagem.Excecao(this, "Erro ao excluir o registro !", exc);
            }
        }

        private void alunoDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void FrmCadAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarRegistro();
        }
    }
}
