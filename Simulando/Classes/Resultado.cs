namespace Simulando.Classes
{
    using System.Collections.Generic;
    using System.Linq;

    public class Resultado
    {
        public List<Questao> Respostas;
        public string DescricaoProva { get; set; }
        public string NomeAluno { get; set; }

        public int QtdRespondidas
        {
            get
            {
                return Respostas.Count(lresposta => (lresposta.ARespondida ||
                                                     lresposta.BRespondida ||
                                                     lresposta.CRespondida ||
                                                     lresposta.DRespondida));
            }
        }

        public int Aproveitamento
        {
            get
            {
                int qtdAcertos = Respostas.Count(lresposta => ((lresposta.ACorreta && lresposta.ARespondida) ||
                                                               (lresposta.BCorreta && lresposta.BRespondida) ||
                                                               (lresposta.CCorreta && lresposta.CRespondida) ||
                                                               (lresposta.DCorreta && lresposta.DRespondida)));

                if (qtdAcertos > 0)
                    return (int) (100 * qtdAcertos) / 30;

                return 0;
            }
        }

        public Resultado(List<Questao> respostas)
        {
            Respostas = respostas;
        }
    }
}
