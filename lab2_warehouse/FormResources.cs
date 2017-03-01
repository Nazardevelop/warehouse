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
    public partial class FormResources : Form
    {
        public FormResources()
        {
            InitializeComponent();
        }

        private void lBres_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void lbrefresh()
        {
            lBres.DataSource = Shipment.N.Values.ToList();
        }
        private void FormResources_Load(object sender, EventArgs e)
        {
            lBres.DataSource = Shipment.N.Values.ToList();
        }

        private void btnthrowaway_Click(object sender, EventArgs e)
        {
            Shipment.N.Remove(((Shipment)lBres.SelectedItem).Id);
            lbrefresh();
        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            FormSale fmS = new FormSale((Shipment)lBres.SelectedItem);
            fmS.Show();
            Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FormBuyMore fmBM = new FormBuyMore((Shipment)lBres.SelectedItem);
            fmBM.Show();
            Close();
        }
    }
}
