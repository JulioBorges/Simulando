using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CustomControls.Data;
using Simulando.Classes;

namespace Simulando.UI
{
    public partial class FrmCadProva : Form
    {
        private int questaoAtual = 1;
        private DataRowView dadosProva;

        public FrmCadProva()
        {
            InitializeComponent();
        }

        private void FrmCadProva_Load(object sender, EventArgs e)
        {
            CarregaDados(true);
        }

        private void CarregaDados(bool Loading)
        {
            try
            {
                categoriaTableAdapter.Fill(simulandoDBDataSet.Categoria);
                provaTableAdapter.Fill(simulandoDBDataSet.Prova);
                questaoTableAdapter.Fill(simulandoDBDataSet.Questao);
                carregaQuestao();
                HabilitaComponentesEdicao(false);
                
                if (Loading)
                    provaBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os dados.\nDetalhes: " + ex.Message);
            }
        }

        private void provaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
        }

        private void btnQuestaoAnterior_Click(object sender, EventArgs e)
        {
            if ((questaoAtual - 1) > 0)
            {
                questaoAtual--;

                carregaQuestao();
            }
        }

        private void carregaQuestao()
        {
            lblNrQuestao.Text = string.Format("Questão {0:00}", questaoAtual);

            limpaQuestao();

            if (provaBindingSource.Count > 0)
            {
                dadosProva = (DataRowView) provaBindingSource.Current;

                if (dadosProva[string.Format("Prv_Q{0}", questaoAtual)] != DBNull.Value)
                {
                    var dadosQuestao = from q in simulandoDBDataSet.Questao
                                       where q.Id == Convert.ToInt32(dadosProva[string.Format("Prv_Q{0}", questaoAtual)])
                                       select q;

                    if (dadosQuestao.Count() > 0)
                    {
                        var questao = dadosQuestao.First();
                        txtTextoQuestao.Text = questao.Q_Texto;
                        txtRespostaA.Text = questao.Q_RespostaA;
                        txtRespostaB.Text = questao.Q_RespostaB;
                        txtRespostaC.Text = questao.Q_RespostaC;
                        txtRespostaD.Text = questao.Q_RespostaD;
                        txtCategoria.Text = questao.CategoriaRow.Cat_Descricao;
                        srcNivel.SelectedStar = questao.Q_NivelQuestao;
                        carregaOpcaoCorreta(questao.Q_RespostaCorreta);
                        VerificaImagem(questao.Id);
                    }
                }
            }
        }

        private void limpaQuestao()
        {
            txtTextoQuestao.Text = "";
            txtRespostaA.Text = "";
            txtRespostaB.Text = "";
            txtRespostaC.Text = "";
            txtRespostaD.Text = "";
            txtCategoria.Text = "";
            srcNivel.SelectedStar = -1;
            carregaOpcaoCorreta("");
            pctImagemQuestao.ImageLocation = "";
        }

        private void carregaOpcaoCorreta(string questaoCorreta)
        {
            rbA.Checked = (questaoCorreta != "" && questaoCorreta == "A");
            rbB.Checked = (questaoCorreta != "" && questaoCorreta == "B");
            rbC.Checked = (questaoCorreta != "" && questaoCorreta == "C");
            rbD.Checked = (questaoCorreta != "" && questaoCorreta == "D");
        }
        
        private void HabilitaComponentesEdicao(bool habilitar)
        {
            txtDescricao.Enabled = habilitar;
            btnSelecionar.Enabled = habilitar;

            //BindingNavigator
            buttonAtualizar.Enabled = !habilitar;
            buttonEditar.Enabled = !habilitar;
            buttonCancelar.Enabled = habilitar;
            buttonSalvar.Enabled = habilitar;
        }

        private void btnProximaQuestao_Click(object sender, EventArgs e)
        {
            if ((questaoAtual + 1) <= 30)
            {
                questaoAtual++;

                carregaQuestao();
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(provaTableAdapter.GetId() ?? 1);
            questaoAtual = 1;
            carregaQuestao();
            HabilitaComponentesEdicao(true);
            Refresh();
        }

        private void provaBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
        }

        private void VerificaImagem(int codigoQuestao)
        {
            string caminhoLogo = string.Format(@"{0}\Img\{1}.jpg", Global.DiretorioAplicacao,
                                   codigoQuestao);
            var fi = new FileInfo(caminhoLogo);

            pctImagemQuestao.ImageLocation = fi.Exists ? caminhoLogo : "";
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            var posicao = provaBindingSource.Position;
            CarregaDados(false);
            provaBindingSource.Position = posicao;
            questaoAtual = 1;
            carregaQuestao();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (provaBindingSource.Count > 0)
                HabilitaComponentesEdicao(true);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaTodasQuestoes())
            {
                Validate();
                provaBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
                HabilitaComponentesEdicao(false);
                Mensagem.Aviso(this, "Prova salva com sucesso !");
            }
        }

        private bool VerificaTodasQuestoes()
        {
            dadosProva = (DataRowView)provaBindingSource.Current;
            for (int i = 1; i <= 30; i++)
            {
                if ((dadosProva[string.Format("Prv_Q{0}", i)] != DBNull.Value) &&
                    (Convert.ToInt32(dadosProva[string.Format("Prv_Q{0}", i)]) != 0)) 
                    continue;

                Mensagem.Erro(this, "Selecione todas as questões para poder finalizar a gravação!");
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            provaBindingSource.CancelEdit();
            HabilitaComponentesEdicao(false);
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (provaBindingSource.Count <= 0) 
                return;

            if (Mensagem.Pergunta(this,"Deseja realmente excluir esta prova?", DialogResult.No))
                return;
            try
            {
                provaBindingSource.RemoveCurrent();
                Validate();
                provaBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
                HabilitaComponentesEdicao(false);
                questaoAtual = 1;
                carregaQuestao();
            }
            catch (Exception exc)
            {
                Mensagem.Excecao(this, "Erro ao excluir o registro !", exc);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Global.SelecionandoQuestao = true;
            Global.CodQuestaoSelecionada = -1;
            new FrmCadQuestao().ShowDialog();
            Global.SelecionandoQuestao = false;
            if (Global.CodQuestaoSelecionada == -1)
                return;

            questaoTableAdapter.Fill(simulandoDBDataSet.Questao);
            dadosProva = (DataRowView)provaBindingSource.Current;
            dadosProva[string.Format("Prv_Q{0}", questaoAtual)] = Global.CodQuestaoSelecionada;
            carregaQuestao();
        }
    }
}
