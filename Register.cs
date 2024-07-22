
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBoxPasswordR_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void RegisterBtnR_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if(textBoxUsernameR.Text != "" &&  textBoxPasswordR.Text != "")
            {
                if (db.addNewUser(textBoxUsernameR.Text, textBoxPasswordR.Text))
                {
                    MessageBox.Show("Register Successful");
                    this.Hide();
                    LogIn logIn = new LogIn();
                    logIn.ShowDialog();
                }
            }
            
            else
            {
                MessageBox.Show("Invalid Username or Password", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsernameR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
