using System;
using System.Windows.Forms;
using CustomControls.Data;
using System.IO;
using Simulando.Classes;

namespace Simulando.UI
{
    public partial class FrmParametros : Form
    {
        private FrmMapeamentoTecla frmMapTeclado;

        public FrmParametros()
        {
            InitializeComponent();
        }

        private void buttonSalvarClick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(dtPicImagem.CaminhoImagem))
                    VerificaImagemAtual();
                else if (string.IsNullOrEmpty(dtPicImagem.pictureBoxData.ImageLocation))
                {
                    var fi = new FileInfo(Global.ImagemLogo);
                    if (fi.Exists)
                    {
                        Global.DeletaArquivo(fi);
                        Global.FrmApp.LimpaLogo();
                    }
                }

                Validate();
                parametrosBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(simulandoDBDataSet);
                HabilitaComponentesEdicao(false);
                Mensagem.Aviso(this, "Dados alterados com sucesso !");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar os dados de Parâmetros" + ex.Message);
            }
        }

        private void VerificaImagemAtual()
        {
            var fi = new FileInfo(Global.ImagemLogo);
            
            if (fi.Exists)
            {
                Global.FrmApp.LimpaLogo();

                Global.DeletaArquivo(fi);
            }

            File.Copy(dtPicImagem.CaminhoImagem, fi.FullName);
            Global.ProtegeArquivo(fi.FullName);
        }

        private void FrmParametros_Load(object sender, EventArgs e)
        {
            CarregaDados();
            HabilitaComponentesEdicao(false);
        }

        private void CarregaDados()
        {
            try
            {
                parametrosTableAdapter.Fill(simulandoDBDataSet.Parametros);

                if (File.Exists(Global.ImagemLogo))
                    dtPicImagem.pictureBoxData.ImageLocation = Global.ImagemLogo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os dados.\nDetalhes: " + ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        void HabilitaComponentesEdicao(bool habilitar)
        {
            txtNomeEmpresa.Enabled = habilitar;
            txtSenhaParametros.Enabled = habilitar;
            dtPicImagem.Enabled = habilitar;
            cbUsaTecladoVirtual.Enabled = habilitar;
            
            groupBoxMapeamento.Enabled = !cbUsaTecladoVirtual.Checked && habilitar;

            //BindingNavigator
            buttonAtualizar.Enabled = !habilitar;
            buttonEditar.Enabled = !habilitar;
            buttonCancelar.Enabled = habilitar;
            buttonSalvar.Enabled = habilitar;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            HabilitaComponentesEdicao(true);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            parametrosBindingSource.CancelEdit();
            HabilitaComponentesEdicao(false);
        }

        private void btnCadQuestoes_Click(object sender, EventArgs e)
        {
            new FrmCadQuestao().ShowDialog();
        }

        private void buttonCadCategoria_Click(object sender, EventArgs e)
        {
            new FrmCadCategoria().ShowDialog();
        }

        private void buttonCadProva_Click(object sender, EventArgs e)
        {
            new FrmCadProva().ShowDialog();
        }

        private void cbUsaTecladoVirtual_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMapeamento.Enabled = !cbUsaTecladoVirtual.Checked;
        }

        void MapeandoTecla(TextBox ptxtInfo, string DescricaoBotao)
        {
            frmMapTeclado = new FrmMapeamentoTecla
                                {
                                    NomeBotao = DescricaoBotao
                                };

            if (frmMapTeclado.ShowDialog(this) == DialogResult.OK)
                ptxtInfo.Text = frmMapTeclado.Tag.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaIniciarTextBox, "INICIAR");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaFinalizarTextBox, "FINALIZAR");
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaProximaTextBox, "PROXIMA");
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaAnteriorTextBox, "ANTERIOR");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaLimparTextBox, "LIMPAR");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaATextBox, "A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaBTextBox, "B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaCTextBox, "C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaDTextBox, "D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            MapeandoTecla(p_TeclaETextBox, "E");
        }
    }
}
