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
    public partial class frmRentas : Form
    {
        private frmMain _mainForm;

        public frmRentas()
        {
            InitializeComponent();
        }
        public frmRentas(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRentas_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            _mainForm.EnableButtons();
        }

        private void frmRentas_Load(object sender, EventArgs e)
        {
            dtpDesde.MinDate = DateTime.Today;
            dtpHasta.MinDate = DateTime.Today;
        }
    }
}
