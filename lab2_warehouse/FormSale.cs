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
    public partial class FormSale : Form
    {
        public FormSale(Shipment ship)
        {
            InitializeComponent();
            s = ship;
        }
        Shipment s;
        private void nUDrefresh()
        {
            nUDamountp.Value = 0;
            
        }
        private void FormSale_Load(object sender, EventArgs e)
        {
            tBthisSh.Text = s.Shname;
            cbBpartner.DataSource = Organization.N.Values.ToList();
            
            nUDrefresh();
           
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (nUDamountp.Value <= 0 || cbBpartner.SelectedItem == null)
            {
                MessageBox.Show("Some fields are empty or filled in a wrong way, please fix it");
            }
                if(nUDamountp.Value>s.Amount)
                {
                    MessageBox.Show("You can not sale more than you have");
                }

            
                if ((int)nUDamountp.Value == s.Amount)
                {
                    Shipment.N.Remove(s.Id);
                    nUDrefresh();
                }
                if (s.Amount > (int)nUDamountp.Value)
                {
                    s.Amount -= (int)nUDamountp.Value;
                    nUDrefresh();
                    
                }
            
        }

        private void FormSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shipment.Serialize();
        }

       

    }
}
