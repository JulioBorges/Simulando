using System.Windows.Forms;
using Simulando.Classes;
using System.IO;
using System;

namespace Simulando.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonParametros_Click(object sender, EventArgs e)
        {
            new FrmParametros().ShowDialog();
            CarregaLogo();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaLogo();
        }

        private void CarregaLogo()
        {
            try
            {
                if (File.Exists(Global.ImagemLogo))
                    pbLogo.ImageLocation = Global.ImagemLogo;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar a imagem.\nDetalhes: " + ex.Message);
            }
        }

        public void LimpaLogo()
        {
            pbLogo.Image = null;
        }

        private void buttonCadastrarAluno_Click(object sender, EventArgs e)
        {
            new FrmCadAluno().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmSelecaoProva().ShowDialog();
        }
    }
}
