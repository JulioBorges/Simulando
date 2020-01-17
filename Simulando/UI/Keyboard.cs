using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simulando.UI
{
    public partial class Keyboard : Form
    {

        Point Ponto;

        public Action AcaoBotaoProxima;
        public Action AcaoBotaoAnterior;
        public Action AcaoBotaoLimpar;
        public Action AcaoBotaoFinalizar;
        public Action AcaoBotaoIniciar;
        public Action AcaoBotaoA;
        public Action AcaoBotaoB;
        public Action AcaoBotaoC;
        public Action AcaoBotaoD;
        public Action AcaoBotaoE;

        public Keyboard()
        {
            InitializeComponent();
            Ponto = new Point();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Ponto.X = Left - MousePosition.X;
            Ponto.Y = Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Left = Ponto.X + MousePosition.X;
            Top = Ponto.Y + MousePosition.Y;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoIniciar != null) AcaoBotaoIniciar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoFinalizar != null) AcaoBotaoFinalizar();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoProxima != null) AcaoBotaoProxima();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoAnterior != null) AcaoBotaoAnterior();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoLimpar != null) AcaoBotaoLimpar();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoE != null) AcaoBotaoE();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoD != null) AcaoBotaoD();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoC != null) AcaoBotaoC();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoB != null) AcaoBotaoB();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (AcaoBotaoA != null) AcaoBotaoA();
        }
    }
}
