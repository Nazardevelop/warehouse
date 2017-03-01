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
    public partial class FormBuyMore : Form
    {
        public FormBuyMore(Shipment ship)
        {
            InitializeComponent();
            sh = ship;
        }
        Shipment sh;
        private void nUDrefresh()
        {
            nUDamount.Value = 0;
        }
        private void FormBuyMore_Load(object sender, EventArgs e)
        {
            cBpartner.DataSource = Organization.N.Values.ToList();
            tBShname.Text = sh.Shname;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if ((int)nUDamount.Value <= 0 || cBpartner.SelectedItem == null)
            {
                MessageBox.Show("Some fields are emptyor filled in a wrong way, please fix it");
            }
            else
            {
                sh.Amount += (int)nUDamount.Value;
                nUDrefresh();
            }
        }

        private void FormBuyMore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shipment.Serialize();
        }

       
    }
}
