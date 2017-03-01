using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_code;

namespace lab2_warehouse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo fmI = new FormInfo();
            fmI.ShowDialog();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuy fmB = new FormBuy();
            fmB.Show();
        }


        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStaff fmSf = new FormStaff();
            fmSf.Show();
        }

        private void partnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPartners fmP = new FormPartners();
            fmP.Show();
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResources fmR = new FormResources();
            fmR.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Organization.DeSerialize();
            Staff.DeSerialize();
            Shipment.DeSerialize();

        }
        private void FormMain_FormClosing(object sender, FormClosedEventArgs e)
        {
            Organization.Serialize();
            Staff.Serialize();
            Shipment.Serialize();
        }
    }
}
