using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using CustomControls.Data;
using Simulando.Classes;
using Simulando.Report;

namespace Simulando.UI
{
    public partial class FrmRealizacaoProva : Form
    {
        private bool finalizando;
        private int questaoAtual;
        private TimeSpan TempoProva;
        private bool AlinhandoTela, SolicitandoInicio, UsaTecladoVirtual;
        private char TeclaA, TeclaB, TeclaC, TeclaD, TeclaE, TeclaInicia, TeclaFinaliza, TeclaProxima, TeclaAnterior, TeclaLimpar;
        private List<Questao> ListaQuestoes;
        private Resultado resultadoProva;

        private Keyboard TecladoVirtual;

        public FrmRealizacaoProva()
        {
            InitializeComponent();
        }

        private void FrmRealizacaoProva_Load(object sender, EventArgs e)
        {
            questaoTableAdapter.Fill(simulandoDBDataSet.Questao);
            parametrosTableAdapter.Fill(simulandoDBDataSet.Parametros);
            SetaTeclas();
            SolicitandoInicio = true;
            if (UsaTecladoVirtual)
            {
                //KeyPreview = false;
                AlinhandoTela = false;
                groupBoxTeclas.Visible = false;
                panelIniciando.Visible = true;
                buttonFechar.Visible = false;
                labelAtencao.Visible = false;
                labelTxt.Visible = false;

                TecladoVirtual = new Keyboard
                                     {
                                         AcaoBotaoA = () => SelecionaOpcaoQuestao('A'),
                                         AcaoBotaoB = () => SelecionaOpcaoQuestao('B'),
                                         AcaoBotaoC = () => SelecionaOpcaoQuestao('C'),
                                         AcaoBotaoD = () => SelecionaOpcaoQuestao('D'),
                                         AcaoBotaoE = () => SelecionaOpcaoQuestao('E'),
                                         AcaoBotaoAnterior = QuestaoAnterior,
                                         AcaoBotaoFinalizar = Finalizar,
                                         AcaoBotaoIniciar = IniciaProva,
                                         AcaoBotaoLimpar = LimpaOpcao,
                                         AcaoBotaoProxima = ProximaQuestao,
                                         Location = new Point(DesktopBounds.Width - 400, 0)
                                     };

                TecladoVirtual.Show(this);
            }
            else
            {
                AlinhandoTela = true;
            }
        }

        private void SetaTeclas()
        {
            var dados = (from obj in simulandoDBDataSet.Parametros.AsEnumerable()
                         select obj).First();

            UsaTecladoVirtual = dados.P_UsaTecladoVirtual == "S";
            if (UsaTecladoVirtual)
            {
                TeclaA = (char) Keys.A;
                TeclaB = (char) Keys.B;
                TeclaC = (char) Keys.C;
                TeclaD = (char) Keys.D;
                TeclaE = (char) Keys.E;
                TeclaFinaliza = (char) Keys.Escape;
                TeclaProxima = (char) Keys.Right;
                TeclaAnterior = (char) Keys.Left;
                TeclaInicia = (char) Keys.Enter;
                TeclaLimpar = (char) Keys.Back;
            }
            else
            {
                TeclaA = dados.P_TeclaA[0];
                TeclaB = dados.P_TeclaB[0];
                TeclaC = dados.P_TeclaC[0];
                TeclaD = dados.P_TeclaD[0];
                TeclaE = dados.P_TeclaE[0];
                TeclaFinaliza = dados.P_TeclaFinalizar[0];
                TeclaProxima = dados.P_TeclaProxima[0];
                TeclaAnterior = dados.P_TeclaAnterior[0];
                TeclaInicia = dados.P_TeclaIniciar[0];
                TeclaLimpar = dados.P_TeclaLimpar[0];
            }
        }

        private void IniciaProva()
        {
            CarregaDadosAluno();
            questaoAtual = 1;

            ListaQuestoes = CarregaQuestoes();
            resultadoProva = new Resultado (ListaQuestoes)
                                 {
                                     DescricaoProva = Global.gDadosProva["Prv_Descricao"].ToString(),
                                     NomeAluno = Global.gDadosAluno["Al_Nome"].ToString()
                                 };

            CarregaDadosQuestao(questaoAtual);
            pictureBoxLogoEmpresa.ImageLocation = Global.ImagemLogo != "" ? Global.ImagemLogo : "";

            //TempoProva = new TimeSpan(0, 0, 15); //
            TempoProva = new TimeSpan(0, 59, 59);
            labelTempo.Text = string.Format("Tempo restante - {0}", TempoProva);
            timerTempo.Enabled = true;
            tabControlProva.SelectedTabIndex = 0;
            SolicitandoInicio = false;
        }

        private List<Questao> CarregaQuestoes()
        {
            List<Questao> lista = new List<Questao>(30);

            for (int i = 1; i <= 30; i++)
            {
                var DadosQuestao = (from questao in simulandoDBDataSet.Questao.AsEnumerable()
                                    where questao.Id == Convert.ToInt32(Global.gDadosProva[string.Format("Prv_Q{0}", i)])
                                    select questao).First();

                txtTextoQuestao.Text = DadosQuestao.Q_Texto;
                txtRespA.Text = DadosQuestao.Q_RespostaA;
                txtRespB.Text = DadosQuestao.Q_RespostaB;
                txtRespC.Text = DadosQuestao.Q_RespostaC;
                txtRespD.Text = DadosQuestao.Q_RespostaD;
                
                string caminhoLogo = string.Format(@"{0}\Img\{1}.jpg", Global.DiretorioAplicacao,
                                                   DadosQuestao.Id);

                lista.Add(new Questao
                              {
                                  NumeroQuestao = i,
                                  IdQuestao = DadosQuestao.Id,
                                  Texto = DadosQuestao.Q_Texto,
                                  RespostaA = DadosQuestao.Q_RespostaA,
                                  RespostaB = DadosQuestao.Q_RespostaB,
                                  RespostaC = DadosQuestao.Q_RespostaC,
                                  RespostaD = DadosQuestao.Q_RespostaD,
                                  RespostaCorreta = DadosQuestao.Q_RespostaCorreta,
                                  Imagem = File.Exists(caminhoLogo) ? caminhoLogo : ""
                              });
            }

            return lista;
        }

        private void CarregaDadosQuestao(int numQuestao)
        {
            pictureBoxImgQuestao.Focus();

            txtTextoQuestao.Text = resultadoProva.Respostas[numQuestao - 1].Texto;
            txtRespA.Text = resultadoProva.Respostas[numQuestao - 1].RespostaA;
            txtRespB.Text = resultadoProva.Respostas[numQuestao - 1].RespostaB;
            txtRespC.Text = resultadoProva.Respostas[numQuestao - 1].RespostaC;
            txtRespD.Text = resultadoProva.Respostas[numQuestao - 1].RespostaD;
            pictureBoxImgQuestao.ImageLocation = resultadoProva.Respostas[numQuestao - 1].Imagem;

            listBoxQuestoesVisao.SelectedIndex = numQuestao - 1;
            
            MarcaOpcaoQuestao(numQuestao);
        }

        private void CarregaDadosAluno()
        {
            txtNomeAluno.Text = Global.gDadosAluno["Al_Nome"].ToString();
            txtIdadeAluno.Text = Global.gDadosAluno["Al_Idade"].ToString();
        }

        private void MarcaOpcaoQuestao(int numQuestao)
        {
            if (SolicitandoInicio)
                return;

            SuspendLayout();
            txtRespA.BackColor = resultadoProva.Respostas[numQuestao - 1].ARespondida ? Color.Yellow : SystemColors.Window;
            txtRespB.BackColor = resultadoProva.Respostas[numQuestao - 1].BRespondida ? Color.Yellow : SystemColors.Window;
            txtRespC.BackColor = resultadoProva.Respostas[numQuestao - 1].CRespondida ? Color.Yellow : SystemColors.Window;
            txtRespD.BackColor = resultadoProva.Respostas[numQuestao - 1].DRespondida ? Color.Yellow : SystemColors.Window;
            ResumeLayout(true);
        }

        private void FrmRealizacaoProva_KeyUp(object sender, KeyEventArgs e)
        {
            if (UsaTecladoVirtual)
            {
                if (e.KeyValue == 115)
                {
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                finalizando = false;

                if (AlinhandoTela)
                {
                    AlinharTela(e.KeyData);
                }
                else if (SolicitandoInicio)
                {
                    if (e.KeyData == (Keys) TeclaInicia)
                        IniciaProva();
                }
                else
                {
                    if (e.KeyData == (Keys)TeclaA || e.KeyData == (Keys)TeclaB ||
                        e.KeyData == (Keys)TeclaC || e.KeyData == (Keys)TeclaD)
                        SelecionaOpcaoQuestao((char) e.KeyData);//MarcaOpcaoQuestao((char) e.KeyData);
                    else if (e.KeyData == (Keys)TeclaFinaliza)
                        Finalizar();
                    else if (e.KeyData == (Keys)TeclaProxima)
                        ProximaQuestao();
                    else if (e.KeyData == (Keys)TeclaAnterior)
                        QuestaoAnterior();
                    else if (e.KeyData == (Keys)TeclaLimpar)
                        LimpaOpcao();
                    else
                        e.Handled = true;
                }
            }
        }

        private void SelecionaOpcaoQuestao(char resp)
        {
            if (SolicitandoInicio)
                return;

            resultadoProva.Respostas[questaoAtual - 1].ARespondida = (resp == TeclaA);
            resultadoProva.Respostas[questaoAtual - 1].BRespondida = (resp == TeclaB);
            resultadoProva.Respostas[questaoAtual - 1].CRespondida = (resp == TeclaC);
            resultadoProva.Respostas[questaoAtual - 1].DRespondida = (resp == TeclaD);

            MarcaOpcaoQuestao(questaoAtual);
        }

        private void Finalizar()
        {
            if (!Mensagem.Pergunta(this, "Deseja realmente finalizar a prova?", DialogResult.Yes))
                return;

            timerTempo.Enabled = false;
            finalizando = true;
            Close();
            FrmRelatorioResultado frmResult = new FrmRelatorioResultado(resultadoProva);
            frmResult.ShowDialog();
        }

        private void AlinharTela(Keys tecla)
        {
            SuspendLayout();

            if (tecla == (Keys)TeclaInicia)
                btnIniciar.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaFinaliza)
                btnFinalizar.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaLimpar)
                btnLimpar.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaProxima)
                btnProxima.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaAnterior)
                btnAnterior.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaA)
                btnA.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaB)
                btnB.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaC)
                btnC.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaD)
                btnD.BackColor = Color.Blue;

            if (tecla == (Keys)TeclaE)
                btnE.BackColor = Color.Blue;

            ResumeLayout(true);

            if (btnIniciar.BackColor != Color.Blue || btnFinalizar.BackColor != Color.Blue ||
                btnLimpar.BackColor != Color.Blue || btnProxima.BackColor != Color.Blue ||
                btnAnterior.BackColor != Color.Blue || btnA.BackColor != Color.Blue || btnB.BackColor != Color.Blue ||
                btnC.BackColor != Color.Blue || btnD.BackColor != Color.Blue || btnE.BackColor != Color.Blue) 
                return;

            AlinhandoTela = false;
            SolicitandoInicio = true;
            groupBoxTeclas.Visible = false;
            panelIniciando.Visible = true;
            buttonFechar.Visible = false;
            labelAtencao.Visible = false;
            labelTxt.Visible = false;
        }

        private void FrmRealizacaoProva_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finalizando)
                e.Cancel = true;
        }

        private void timerTempo_Tick(object sender, EventArgs e)
        {
            TempoProva = TempoProva.Subtract(new TimeSpan(0, 0, 1));

            labelTempo.Text = string.Format("Tempo restante - {0}", TempoProva);

            if (TempoProva != TimeSpan.Zero) 
                return;

            timerTempo.Enabled = false;
            Mensagem.Atencao(this, "Acabou a prova !!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProximaQuestao()
        {
            if (SolicitandoInicio)
                return;

            if (questaoAtual == 30)
                return;

            questaoAtual++;
            CarregaDadosQuestao(questaoAtual);
        }

        private void QuestaoAnterior()
        {
            if (SolicitandoInicio)
                return;

            if (questaoAtual <= 1)
                return;

            questaoAtual--;
            CarregaDadosQuestao(questaoAtual);
        }

        private void LimpaOpcao()
        {
            SelecionaOpcaoQuestao(' ');
        }

    }
}
