using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleReservation
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comment.Text != "" && rating.Text != "")
            {
                Database database = new Database();
                if (database.saveFeedBack(comment.Text, rating.Text))
                {
                    MessageBox.Show("Done");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Fill the  Required fields");

                }
            }
        }
    }
}
