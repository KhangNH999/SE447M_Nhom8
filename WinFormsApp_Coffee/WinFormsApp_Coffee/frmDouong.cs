﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Coffee
{
    public partial class frmDouong : Form
    {
        public frmDouong()
        {
            InitializeComponent();
        }

        private void btnGiaapdung_Click(object sender, EventArgs e)
        {
            frmGiaapdung f = new frmGiaapdung();
            f.ShowDialog();        
        }
    }
}
