using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFormAC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            Marina m1 = Marina.GetMarinaById(gototxt.Text);

            Marina_numtxt.Text = m1.id  ;
            Marina_nametxt.Text = m1.name;
            Marina_addresstxt.Text = m1.address;
            Marina_citytxt.Text = m1.city;
            Marina_statetxt.Text = m1.state;
            Marina_ziptxt.Text = m1.zip;

            updatetxt.Text = gototxt.Text;
            deletetxt.Text = gototxt.Text;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Marina m1 = new Marina();

            m1.id = Marina_numtxt.Text;
            m1.name = Marina_nametxt.Text;
            m1.address = Marina_addresstxt.Text;
            m1.city = Marina_citytxt.Text;
            m1.state = Marina_statetxt.Text;
            m1.zip = Marina_ziptxt.Text;

            m1.Update();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Marina.GetMarinaById(deletetxt.Text).Delete();

                MessageBox.Show("1 row affected. Marina_num " + deletetxt.Text + " was deleted from the database.");

                if (Marina_numtxt.Text == deletetxt.Text)
                {
                    Marina_numtxt.Text = "";
                    Marina_nametxt.Text = "";
                    Marina_addresstxt.Text = "";
                    Marina_citytxt.Text = "";
                    Marina_statetxt.Text = "";
                    Marina_ziptxt.Text = "";

                    updatetxt.Text = "";
                    gototxt.Text = "";
                    deletetxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("0 rows affected");
            }
        }

        private void newRecordbtn_Click(object sender, EventArgs e)
        {
            Marina_numtxt.Text = "";
            Marina_nametxt.Text = "";
            Marina_addresstxt.Text = "";
            Marina_citytxt.Text = "";
            Marina_statetxt.Text = "";
            Marina_ziptxt.Text = "";

            updatetxt.Text = "";
            gototxt.Text = "";
            deletetxt.Text = "";

            Marina_numtxt.ReadOnly = false;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Marina m1 = new Marina();

            m1.id = Marina_numtxt.Text;
            m1.name = Marina_nametxt.Text;
            m1.address = Marina_addresstxt.Text;
            m1.city = Marina_citytxt.Text;
            m1.state = Marina_statetxt.Text;
            m1.zip = Marina_ziptxt.Text;

            if (MessageBox.Show("Are you sure you want to add a new record?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                m1.Update();

                MessageBox.Show("1 row affected. Marina_num " + Marina_numtxt.Text + " was put into the database.");
            }
            else
            {
                MessageBox.Show("0 rows affected");
            }
        }
    }
}
