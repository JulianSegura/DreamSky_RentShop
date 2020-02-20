using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamSkyEntities;
using BusinessLayer;

namespace UserInterfaceLayer
{
    public partial class Form2 : Form
    {
        BusinessCategoriaProducto catProducto = new BusinessCategoriaProducto();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = catProducto.GetAll();
            dgvDetails.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            catProducto.Nombre = txtName.Text.Trim();
            catProducto.Activo = Convert.ToBoolean(chkActive.CheckState);
            string resultado =catProducto.InsertCategory();

            MessageBox.Show(resultado);

            Form2_Load(sender, e);
        }
    }
}
