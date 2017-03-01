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
    public partial class FormPartners : Form
    {
        public FormPartners()
        {
            InitializeComponent();
        }
        private void lbrefresh()
        {
            lBpartners.DataSource = null;
            lBpartners.DataSource = Organization.N.Values.ToList();
            tBaddpartner.Text = null;
        }
        private void FormPartners_Load(object sender, EventArgs e)
        {
            lbrefresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tBaddpartner.Text == "")
            {
                MessageBox.Show("Field is empty, enter the name of partner please");
            }
            else
            {
                Organization org = new Organization(tBaddpartner.Text);
                lbrefresh();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lBpartners.SelectedItem == null)
            {
                MessageBox.Show("There is nothing to delete");
            }
            else
            {
                Organization.N.Remove(((Organization)lBpartners.SelectedItem).Id);
                lbrefresh();
            }
        }

        private void lBpartners_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbrefresh();
        }

    }
}
