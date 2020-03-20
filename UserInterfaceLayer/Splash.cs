using System;
using System.Windows.Forms;

namespace UserInterfaceLayer
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(3);
            if (progressBar1.Value == 100) this.timer1.Stop();
            if (progressBar1.Value == 20) this.Close();



        }
    }
}
