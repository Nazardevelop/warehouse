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
    public partial class FormBuy : Form
    {
        public FormBuy()
        {
            InitializeComponent();
        }
      private void  formrefresh()
        {
            tBproduct.Text="";
            nUDamount.Value=0;
        }

        private void btnAddshipment_Click(object sender, EventArgs e)
        {
            if (tBproduct.Text == "" || nUDamount.Value <= 0 || cBpartner.SelectedItem == null)
            {
                MessageBox.Show("Some fields are empty, please fill them");
            }
            else
            {
                
                Shipment s = new Shipment(tBproduct.Text , (int)nUDamount.Value, (Organization)cBpartner.SelectedItem);
                formrefresh();
            }
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            cBpartner.DataSource = Organization.N.Values.ToList();
            formrefresh();
        }
    }
}
