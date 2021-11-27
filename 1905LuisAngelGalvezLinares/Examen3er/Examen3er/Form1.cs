using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen3er
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pb1Conf_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            label11.Visible = true;

            pbEnv.Visible = false;
            pbCalc.Visible = false;
            pbLanz.Visible = false;
            pbList.Visible = false;
            pbAccess.Visible = false;

            lbenvios.Visible = false;
            lbCalc.Visible = false;
            lbLanz.Visible = false;
            lbList.Visible = false;
            lbAcce.Visible = false;

        }

        private void pb2Env_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label11.Visible = false;
            pbEnv.Visible = true;
            pbCalc.Visible = false;
            pbLanz.Visible = false;
            pbList.Visible = false;
            pbAccess.Visible = false;

            lbenvios.Visible = true;
            lbCalc.Visible = false;
            lbLanz.Visible = false;
            lbList.Visible = false;
            lbAcce.Visible = false;
        }

        private void pb3Calc_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label11.Visible = false;
            pbEnv.Visible = false;
            pbCalc.Visible = true;
            pbLanz.Visible = false;
            pbList.Visible = false;
            pbAccess.Visible = false;

            lbenvios.Visible = false;
            lbCalc.Visible = true;
            lbLanz.Visible = false;
            lbList.Visible = false;
            lbAcce.Visible = false;
        }

        private void pb4Lanz_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label11.Visible = false;
            pbEnv.Visible = false;
            pbCalc.Visible = false;
            pbLanz.Visible = true;
            pbList.Visible = false;
            pbAccess.Visible = false;

            lbenvios.Visible = false;
            lbCalc.Visible = false;
            lbLanz.Visible = true;
            lbList.Visible = false;
            lbAcce.Visible = false;
        }

        private void pb5List_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label11.Visible = false;
            pbEnv.Visible = false;
            pbCalc.Visible = false;
            pbLanz.Visible = false;
            pbList.Visible = true;
            pbAccess.Visible = false;

            lbenvios.Visible = false;
            lbCalc.Visible = false;
            lbLanz.Visible = false;
            lbList.Visible = true;
            lbAcce.Visible = false;
        }

        private void pb6Acc_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            label11.Visible = false;
            pbEnv.Visible = false;
            pbCalc.Visible = false;
            pbLanz.Visible = false;
            pbList.Visible = false;
            pbAccess.Visible = true;

            lbenvios.Visible = false;
            lbCalc.Visible = false;
            lbLanz.Visible = false;
            lbList.Visible = false;
            lbAcce.Visible = true;
        }
    }
}
