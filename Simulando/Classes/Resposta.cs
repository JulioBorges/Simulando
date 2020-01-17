namespace Simulando.Classes
{
    class Resposta
    {
        public int IdQuestao { get; set; }
        public string OpcaoCorreta { get; set; }
        public string OpcaoRespondida { get; set; }

        public Resposta()
        {
            OpcaoCorreta = "";
            OpcaoRespondida = "";
        }
    }
}
