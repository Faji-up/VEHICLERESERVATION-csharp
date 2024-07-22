
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleReservation
{
    public partial class AddVehiclePage : Form
    {
        public AddVehiclePage()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vehicleImageBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e) // add vehicle button
        {
            Database db = new Database();
            string car_name = CarNameText.Text;
            string car_price = CarPriceText.Text;
            string car_des = CarDesText.Text;
            MemoryStream car_image = new MemoryStream();

            vehicleImageBox.Image.Save(car_image, vehicleImageBox.Image.RawFormat);
            if (db.addNewCar(car_name, car_price, car_des, car_image))
                {
                MessageBox.Show("New Car Added");
            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowAvialable_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeAdmincs homeAdmincs = new HomeAdmincs();
            homeAdmincs.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddVehiclePage_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();

            ReservationMainPage mainPage = new ReservationMainPage();
            mainPage.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Hide();
           AdminNotifPage notif = new AdminNotifPage();
         notif.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeedbackPage feedbackPage = new FeedbackPage(); 
            feedbackPage.ShowDialog();
        }

        private void vehicleImageBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
