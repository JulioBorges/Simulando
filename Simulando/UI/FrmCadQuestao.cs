using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using CustomControls.Data;
using System.Data;
using Simulando.Classes;

namespace Simulando.UI
{
    public partial class FrmCadQuestao : Form
    {
        DataRowView questao;
        public FrmCadQuestao()
        {
            InitializeComponent();
        }

        private void ButtonSalvarClick(object sender, EventArgs e)
        {
            if (!Consistencia())
                return;

            questao = (DataRowView)questaoBindingSource.Current;
            questao["Q_RespostaCorreta"] = rbA.Checked ? 'A' : rbB.Checked ? 'B' : rbC.Checked ? 'C' : 'D';

            VerificaImagem();
            Validate();
            questaoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(simulandoDBDataSet);
            HabilitaComponentesEdicao(false, false);
            Mensagem.Aviso(this, "Questão Salva com sucesso !");
        }

        private void VerificaImagem()
        {
            dtPicImagem.pictureBoxData.SuspendLayout();
            string caminhoLogo = string.Format(@"{0}\Img\{1}.jpg", Global.DiretorioAplicacao,
                                   txtId.Text);
            var fi = new FileInfo(caminhoLogo);

            if (!string.IsNullOrEmpty(dtPicImagem.CaminhoImagem))
            {
                if (fi.Exists)
                    Global.DeletaArquivo(fi);

                if (new FileInfo(dtPicImagem.CaminhoImagem).Extension != ".jpg")
                {
                    Image img = new Bitmap(dtPicImagem.CaminhoImagem);
                    img.Save(Global.DiretorioAplicacao + @"\imgtemp.jpg", ImageFormat.Jpeg);
                    dtPicImagem.CaminhoImagem = Global.DiretorioAplicacao + @"\imgtemp.jpg";
                }

                File.Copy(dtPicImagem.CaminhoImagem, fi.FullName);
                Global.ProtegeArquivo(fi.FullName);

                if (File.Exists(Global.DiretorioAplicacao + @"\imgtemp.jpg"))
                    File.Delete(Global.DiretorioAplicacao + @"\imgtemp.jpg");
            }
            else if (string.IsNullOrEmpty(dtPicImagem.pictureBoxData.ImageLocation))
            {
                if (fi.Exists)
                    Global.DeletaArquivo(fi);
            }
            dtPicImagem.pictureBoxData.ResumeLayout(true);
        }

        private bool Consistencia()
        {
            if (!rbA.Checked && !rbB.Checked && !rbC.Checked && !rbD.Checked)
            {
                Mensagem.Erro(this, "É necessário marcar a resposta correta !");
                return false;
            }

            if (cbCategoria.SelectedItem == null)
            {
                Mensagem.Erro(this, "Selecione uma categoria para a questão !");
                return false;
            }

            if (srcNivel.SelectedStar == 0)
            {
                Mensagem.Erro(this, "Selecione um nível para a questão !");
                return false;
            }

            return true;
        }

        private void FrmCadQuestao_Load(object sender, EventArgs e)
        {
            CarregaDados(true);
            HabilitaComponentesEdicao(false, false);
        }

        private void CarregaDados(bool Loading)
        {
            try
            {
                questaoTableAdapter.Fill(simulandoDBDataSet.Questao);
                categoriaTableAdapter.Fill(simulandoDBDataSet.Categoria);
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
                
                if (Loading)
                    questaoBindingSource.MoveLast();

                var caminhoLogo = string.Format(@"{0}\Img\{1}.jpg", Global.DiretorioAplicacao,
                                                    txtId.Text);
                if (File.Exists(caminhoLogo))
                    dtPicImagem.pictureBoxData.ImageLocation = caminhoLogo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os dados.\nDetalhes: " + ex.Message);
            }
        }

        private void HabilitaComponentesEdicao(bool habilitar, bool Pesquisa)
        {
            txtId.Enabled = habilitar;
            txtRespostaA.Enabled = habilitar;
            txtRespostaB.Enabled = habilitar;
            txtRespostaC.Enabled = habilitar;
            txtRespostaD.Enabled = habilitar;
            txtTextoQuestao.Enabled = habilitar;
            cbCategoria.Enabled = habilitar;
            rbA.Enabled = habilitar;
            rbB.Enabled = habilitar;
            rbC.Enabled = habilitar;
            rbD.Enabled = habilitar;
            dtPicImagem.Enabled = habilitar;
            srcNivel.Enabled = habilitar;
            buttonAddCategoria.Enabled = habilitar;

            btnSelecionarQuestao.Enabled = !habilitar;
            btnSelecionarQuestao.Visible = Global.SelecionandoQuestao;

            //BindingNavigator
            buttonAtualizar.Enabled = !habilitar;
            buttonEditar.Enabled = !habilitar;
            buttonInserir.Enabled = !habilitar;
            buttonDeletar.Enabled = !habilitar;

            if (Pesquisa)
            {
                buttonCancelar.Enabled = !habilitar;
                buttonSalvar.Enabled = !habilitar;
                btnPesquisar.Enabled = habilitar;
                cbCriterioBusca.Enabled = habilitar;
                cbCriterioBusca.SelectedIndex = habilitar ? 0 : -1;

                buttonPrimeiro.Enabled = questaoBindingSource.Position > 0 && !habilitar;
                buttonAnterior.Enabled = questaoBindingSource.Position > 0 && !habilitar;
                buttonProximo.Enabled = questaoBindingSource.Position < questaoBindingSource.Count && !habilitar;
                buttonUltimo.Enabled = questaoBindingSource.Position < questaoBindingSource.Count && !habilitar;
            }
            else
            {
                buttonCancelar.Enabled = habilitar;
                buttonSalvar.Enabled = habilitar;   
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (questaoBindingSource.Count > 0)
                HabilitaComponentesEdicao(true, false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            questaoBindingSource.CancelEdit();
            HabilitaComponentesEdicao(false, false);
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (questaoBindingSource.Count > 0)
            {
                if (Mensagem.Pergunta(this,
                                      string.Format(
                                          "Deseja realmente excluir esta questão?{0}OBS.: Se a questão estiver cadastrada em alguma prova, a prova será excluída !",
                                          Environment.NewLine), DialogResult.No))
                    return;

                questaoBindingSource.RemoveCurrent();
                Validate();
                questaoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
                HabilitaComponentesEdicao(false, false);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            var posicao = questaoBindingSource.Position;
            CarregaDados(false);
            questaoBindingSource.Position = posicao;
        }

        private void questaoBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            HabilitaComponentesEdicao(true, false);
            dtPicImagem.pictureBoxData.ImageLocation = "";
            dtPicImagem.CaminhoImagem = "";
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            txtId.Text = questaoTableAdapter.GetId() == null ? "1" : Convert.ToString(questaoTableAdapter.GetId());
            dtPicImagem.pictureBoxData.ImageLocation = "";
            srcNivel.SelectedStar = 0;
            buttonInserir.Enabled = false;
            Refresh();
        }

        private void questaoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            dtPicImagem.pictureBoxData.ImageLocation = "";
            dtPicImagem.CaminhoImagem = "";
            dtPicImagem.pictureBoxData.Image = null;
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            if (questaoBindingSource.IsBindingSuspended)
                return;

            CarregaDadosQuestaoAtual();
            ResumeLayout(true);
        }

        private void CarregaDadosQuestaoAtual()
        {

            questao = (DataRowView)questaoBindingSource.Current;

            if ((questao != null) && (questao["Q_RespostaCorreta"] != DBNull.Value))
            {
                rbA.Checked = (Convert.ToChar(questao["Q_RespostaCorreta"]) == 'A');
                rbB.Checked = (Convert.ToChar(questao["Q_RespostaCorreta"]) == 'B');
                rbC.Checked = (Convert.ToChar(questao["Q_RespostaCorreta"]) == 'C');
                rbD.Checked = (Convert.ToChar(questao["Q_RespostaCorreta"]) == 'D');

                string caminhoLogo = string.Format(@"{0}\Img\{1}.jpg", Global.DiretorioAplicacao,
                                                   questao["Id"]);

                dtPicImagem.pictureBoxData.ImageLocation = File.Exists(caminhoLogo) ? caminhoLogo : "";
            }
        }

        private void buttonAddCategoria_Click(object sender, EventArgs e)
        {
            new FrmCadCategoria().ShowDialog();
        }

        private void btnSelecionarQuestao_Click(object sender, EventArgs e)
        {
            Global.CodQuestaoSelecionada = Convert.ToInt32(txtId.Text);
            Close();
        }

        private void btnIniciaPesquisa_Click(object sender, EventArgs e)
        {
            questaoBindingSource.SuspendBinding();
            HabilitaComponentesEdicao(true, true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            questaoBindingSource.Filter = MontaFiltro();
            questaoBindingSource.ResumeBinding();
            CarregaDadosQuestaoAtual();
            HabilitaComponentesEdicao(false, true);
        }

        private string MontaFiltro()
        {
            string filtro = "";

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                filtro = "Id = " + txtId.Text;
            }
            else
            {
                MontandoFiltro(ref filtro, "Q_RespostaA", txtRespostaA.Text, true);
                MontandoFiltro(ref filtro, "Q_RespostaB", txtRespostaB.Text, true);
                MontandoFiltro(ref filtro, "Q_RespostaC", txtRespostaC.Text, true);
                MontandoFiltro(ref filtro, "Q_RespostaD", txtRespostaD.Text, true);
                MontandoFiltro(ref filtro, "Q_Texto", txtTextoQuestao.Text, true);

                if (cbCategoria.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(filtro))
                        filtro += cbCriterioBusca.SelectedIndex == 0 ? " AND " : " OR ";

                    filtro += "Q_IdCategoria = " + cbCategoria.SelectedValue;
                }

                if (rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked)
                {
                    if (!string.IsNullOrEmpty(filtro))
                        filtro += cbCriterioBusca.SelectedIndex == 0 ? " AND " : " OR ";

                    filtro += "Q_RespostaCorreta = '" + (rbA.Checked ? 'A' : rbB.Checked ? 'B' : rbC.Checked ? 'C' : 'D') + "'";
                }

                if (srcNivel.SelectedStar > 0)
                {
                    if (!string.IsNullOrEmpty(filtro))
                        filtro += cbCriterioBusca.SelectedIndex == 0 ? " AND " : " OR ";

                    filtro += "Q_NivelQuestao = " + srcNivel.SelectedStar;
                }
            }

            return filtro;
        }

        private void MontandoFiltro(ref string filtro, string campo, string info, bool isString)
        {
            if (string.IsNullOrEmpty(info)) 
                return;

            if (!string.IsNullOrEmpty(filtro))
                filtro += cbCriterioBusca.SelectedIndex == 0 ? " AND " : " OR ";

            filtro += campo + " like ";
            filtro += isString ? "'%" + info + "%' " : info;
        }
    }
}
