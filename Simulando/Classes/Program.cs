using System;
using System.Windows.Forms;
using Simulando.UI;
using System.IO;

namespace Simulando.Classes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var exec = new FileInfo(Application.ExecutablePath);
            if (exec.Directory != null) 
                Global.DiretorioAplicacao = exec.Directory.FullName;

            if (!Directory.Exists(Global.DiretorioAplicacao + @"\Img"))
                Directory.CreateDirectory(Global.DiretorioAplicacao + @"\Img");

            Global.ImagemLogo = Global.DiretorioAplicacao + @"\Img\company.logo";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Global.FrmApp = new FrmPrincipal();
            Application.Run(Global.FrmApp);
        }
    }
}
