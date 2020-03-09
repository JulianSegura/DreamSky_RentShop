﻿using System;
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
    public partial class frmClientes : Form
    {
        private frmMain _mainForm;

        public frmClientes()
        {
            InitializeComponent();

        }
        public frmClientes(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            _mainForm.EnableButtons();
        }
    } 
}
