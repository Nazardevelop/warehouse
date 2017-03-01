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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }
        private void lbrefresh()
        {
            lBstaff.DataSource = null;
            lBstaff.DataSource = Staff.N.Values.ToList();
            tBname.Text = "";
            tBsurname.Text = "";
            tBpost.Text = "";
        }


        private void FormStaff_Load(object sender, EventArgs e)
        {
            cBorg.DataSource = Organization.N.Values.ToList();
            lbrefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tBname.Text == "" || tBsurname.Text == "" || tBpost.Text == "")
            {
                MessageBox.Show("Some fields are empty, please fill them and push button(ADD)");
            }
            else
            {
                new Staff(tBpost.Text, tBname.Text, tBsurname.Text, cmBsex.SelectedItem.ToString(), dTPbirth.Value, (Organization)cBorg.SelectedItem);
                lbrefresh();
            }

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (lBstaff.SelectedItem == null)
            {
                MessageBox.Show("There is nobody to fire");
            }
            else
            {
                Staff.N.Remove(((Staff)lBstaff.SelectedItem).Id);
                lbrefresh();
            }
        }

        private void lBstaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbrefresh();
        }
    }
}
