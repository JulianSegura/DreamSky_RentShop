using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (progressBar1.Value == 50) this.Close();



        }
    }
}
