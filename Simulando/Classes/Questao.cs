using System.Drawing;

namespace Simulando.Classes
{
    public class Questao
    {
        public int NumeroQuestao { get; set; }
        public int IdQuestao { get; set; }
        public string RespostaCorreta { get; set; }
        public string Texto { get; set; }
        public string RespostaA { get; set; }
        public string RespostaB { get; set; }
        public string RespostaC { get; set; }
        public string RespostaD { get; set; }

        public bool ACorreta
        {
            get { return RespostaCorreta == "A"; }
        }

        public bool ARespondida { get; set; }

        public bool BCorreta
        {
            get { return RespostaCorreta == "B"; }
        }

        public bool BRespondida { get; set; }

        public bool CCorreta
        {
            get { return RespostaCorreta == "C"; }
        }

        public bool CRespondida { get; set; }

        public bool DCorreta
        {
            get { return RespostaCorreta == "D"; }
        }

        public bool DRespondida { get; set; }

        public string Imagem { get; set; }
    }
}