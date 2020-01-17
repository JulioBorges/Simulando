using System;
using System.Data;
using System.Windows.Forms;
using Simulando.Classes;

namespace Simulando.UI
{
    public partial class FrmSelecaoProva : Form
    {
        public FrmSelecaoProva()
        {
            InitializeComponent();
        }

        private void FrmSelecaoProva_Load(object sender, EventArgs e)
        {
            alunoTableAdapter.Fill(simulandoDBDataSet.Aluno);
            provaTableAdapter.Fill(simulandoDBDataSet.Prova);
        }

        private void buttonRealizarProva_Click(object sender, EventArgs e)
        {
            Close();
            Global.gDadosAluno = (DataRowView)alunoBindingSource.Current;
            Global.gDadosProva = (DataRowView)provaBindingSource.Current;
            new FrmRealizacaoProva().ShowDialog();
        }
    }
}
