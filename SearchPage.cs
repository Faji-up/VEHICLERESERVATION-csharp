
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
    public partial class SearchPage : Form
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            userReservationPage _userReservationPage = new userReservationPage();
            _userReservationPage.ShowDialog();
        }

        private void showCars_Click(object sender, EventArgs e)
        {

            this.Hide();

            Home home = new Home();
            home.ShowDialog();
        }

        private void SearchCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {

            this.Hide();

            UserSetting userSetting = new UserSetting();
            userSetting.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHistory userHistory = new UserHistory();
            userHistory.ShowDialog();
        }
    }
}
