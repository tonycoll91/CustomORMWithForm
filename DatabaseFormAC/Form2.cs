using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                Marina m1 = Marina.GetMarinaById(gototxt.Text);

                if (m1.id != null)
                {
                    Marina_numtxt.Text = m1.id;
                    Marina_nametxt.Text = m1.name;
                    Marina_addresstxt.Text = m1.address;
                    Marina_citytxt.Text = m1.city;
                    Marina_statetxt.Text = m1.state;
                    Marina_ziptxt.Text = m1.zip;
                }
                else
                {
                    MessageBox.Show("No Marina Found");
                }
            }

            catch (SqlException exception)
            {
                MessageBox.Show("I'm sorry but to use the GO button you need to type in a valid number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updatetxt.Text = gototxt.Text;
            deletetxt.Text = gototxt.Text;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (SqlException exception)
            {
                MessageBox.Show("I'm sorry but you must give it a record number to delete first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                Marina m1 = new Marina();

                m1.id = Marina_numtxt.Text;
                m1.name = Marina_nametxt.Text;
                m1.address = Marina_addresstxt.Text;
                m1.city = Marina_citytxt.Text;
                m1.state = Marina_statetxt.Text;
                m1.zip = Marina_ziptxt.Text;
                
                if (Marina.DoesMarinaExists(m1.id) == false)
                {
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
                else if (Marina.DoesMarinaExists(m1.id) == true)
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        m1.Update();

                        MessageBox.Show("1 row affected. Marina_num " + Marina_numtxt.Text + " was updated in the database.");
                    }
                    else
                    {
                        MessageBox.Show("0 rows affected");
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show("You must first navigate to a populated record or create a new record before saving", "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void btnAllMarinas_Click(object sender, EventArgs e)
        {
            List<Marina> marinas = Marina.GetAllMarinas();

            foreach(Marina marina in marinas)
            {
                MessageBox.Show(marina.id + " " + marina.name + " " + marina.address + " " + marina.city + " " + marina.state + " " + marina.zip);
            }
        }
    }
}
