using System.Windows.Forms;

namespace Simulando.UI
{
    public partial class FrmMapeamentoTecla : Form
    {
        public string NomeBotao { get; set; }
        public FrmMapeamentoTecla()
        {
            InitializeComponent();
        }

        private void FrmMapeamentoTecla_Load(object sender, System.EventArgs e)
        {
            labelTecla.Text = NomeBotao;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmMapeamentoTecla_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void FrmMapeamentoTecla_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxValor.Text = ((char)e.KeyData).ToString();
            Tag = (char)e.KeyData;
        }
    }
}
