using System.Data;
using System.IO;
using Simulando.UI;

namespace Simulando.Classes
{
    public static class Global
    {
        public static FrmPrincipal FrmApp;

        public static string DiretorioAplicacao,
                             ImagemLogo;

        public static bool SelecionandoQuestao;
        public static int CodQuestaoSelecionada;
        public static DataRowView gDadosAluno;
        public static DataRowView gDadosProva;

        #region Funcoes
        public static void LimparPasta(DirectoryInfo pasta)
        {
            // A pasta está marcada como ReadOnly? se sim, remove o atributo
            if ((pasta.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                pasta.Attributes ^= FileAttributes.ReadOnly;

            // Deleta os arquivos
            var arquivos = pasta.GetFiles();
            foreach (var arquivo in arquivos)
                DeletaArquivo(arquivo);

            // Obtém as subspastas da pasta atual
            var subpastas = pasta.GetDirectories();

            // Percorre a lista de subpastas
            foreach (var p in subpastas)
                LimparPasta(p);

            pasta.Delete(true);
        }

        public static void DeletaArquivo(FileInfo fi)
        {
            LiberaArquivo(fi.FullName);

            // Apaga o arquivo
            fi.Delete();
        }

        public static void ProtegeArquivo(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            File.SetAttributes(path, FileAttributes.Archive |
                                         FileAttributes.ReadOnly | FileAttributes.Hidden);
        }

        public static void LiberaArquivo(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
        }
        #endregion
    }
}
