using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Simulando.Classes;

namespace Simulando.Report
{
    public partial class FrmRelatorioResultado : Form
    {
        private readonly Resultado DadosRelatorio;

        public FrmRelatorioResultado(Resultado dadosRelatorio)
        {
            DadosRelatorio = dadosRelatorio;
            InitializeComponent();
        }

        private void FrmRelatorioResultado_Load(object sender, EventArgs e)
        {
            /*
            List<Questao> dados = new List<Questao>
                                      {
                                          new Questao
                                              {
                                                  NumeroQuestao = 1,
                                                  Texto = "Texto questao",
                                                  RespostaA = "Texto Resposta A",
                                                  RespostaB = "Texto Resposta B",
                                                  RespostaC = "Texto Resposta C",
                                                  RespostaD = "Texto Resposta D",
                                                  ACorreta = false,
                                                  BCorreta = true,
                                                  CCorreta = false,
                                                  DCorreta = false,
                                                  ARespondida = false,
                                                  BRespondida = false,
                                                  CRespondida = true,
                                                  DRespondida = false,
                                                  Imagem =
                                                      @"D:\Desenvolvimento\Projeto Simulando\Simulando\Simulando\bin\Debug\Img\31.jpg"
                                              },
                                          new Questao
                                              {
                                                  NumeroQuestao = 2,
                                                  Texto = "Texto questao asldkfjlasdkfjlaksdjfhosiadfsadfjkadsfkjadshf",
                                                  RespostaA = "Texto Resposta A",
                                                  RespostaB = "Texto Resposta B",
                                                  RespostaC = "Texto Resposta C",
                                                  RespostaD = "Texto Resposta D",
                                                  ACorreta = false,
                                                  BCorreta = true,
                                                  CCorreta = false,
                                                  DCorreta = false,
                                                  ARespondida = true,
                                                  BRespondida = false,
                                                  CRespondida = false,
                                                  DRespondida = false,
                                                  Imagem = ""
                                              }
                                      };*/
            resultadoBindingSource.DataSource = DadosRelatorio;
            QuestaoBindingSource.DataSource = DadosRelatorio.Respostas;
            reportViewer1.RefreshReport();
        }

    }
}
