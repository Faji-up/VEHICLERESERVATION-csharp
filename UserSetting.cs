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
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();
            setData();
        }

        private void UserSetting_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (database.updateUser(usernameText.Text, passwordText.Text, ActiveUser.Id)){
                MessageBox.Show("Change Successful");
            }
            else
            {
                MessageBox.Show("Changing Error");
            }
        }

        private void setData()
        {
            usernameText.Text = ActiveUser.Username;
            passwordText.Text = ActiveUser.Password;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHistory history = new UserHistory();
            history.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userReservationPage userReservation = new userReservationPage();
            userReservation.ShowDialog();
        }

        private void showSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPage searchPage = new SearchPage();
            searchPage.ShowDialog();
        }

        private void showCars_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.ShowDialog();
        }
    }
}
