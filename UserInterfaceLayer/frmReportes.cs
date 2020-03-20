using System;
using System.Windows.Forms;

namespace UserInterfaceLayer
{

    public partial class frmReportes : Form
    {

        private frmMain _mainForm;

        public frmReportes()
        {
            InitializeComponent();
        }
        public frmReportes(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
