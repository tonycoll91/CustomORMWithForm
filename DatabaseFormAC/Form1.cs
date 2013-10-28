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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MarinaDBConnector Marina = new MarinaDBConnector("Data Source=(local);Initial Catalog=ALEXAMARA;User Id=sa;Password=abc123;Integrated Security=false;");

        private void gobtn_Click(object sender, EventArgs e)
        {
            MarinaDBRow record = Marina.Select(gototxt.Text);

            Marina_numtxt.Text = record.id;
            Marina_nametxt.Text = record.name;
            Marina_addresstxt.Text = record.address;
            Marina_citytxt.Text = record.city;
            Marina_statetxt.Text = record.state;
            Marina_ziptxt.Text = record.zip;
            
            updatetxt.Text = gototxt.Text;
            deletetxt.Text = gototxt.Text;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Marina.Update(updatetxt.Text,Marina_numtxt.Text, Marina_nametxt.Text, Marina_addresstxt.Text, Marina_citytxt.Text, Marina_statetxt.Text, Marina_ziptxt.Text);
            
            gototxt.Text = updatetxt.Text;
            deletetxt.Text = updatetxt.Text;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Marina.Delete(deletetxt.Text);

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
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add a new record?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Marina.Insert(Marina_numtxt.Text, Marina_nametxt.Text, Marina_addresstxt.Text, Marina_citytxt.Text, Marina_statetxt.Text, Marina_ziptxt.Text);
                
                MessageBox.Show("1 row affected. Marina_num " + Marina_numtxt.Text + " was put into the database.");
            }
            else
            {
                MessageBox.Show("0 rows affected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            //Displays Non-Modal Form
            form.Show();
        }
    }
}
