﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiPrimeraPantalla_prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
