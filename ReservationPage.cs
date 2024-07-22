
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
    public partial class ReservationPage : Form
    {
        public static string car_id;
        public ReservationPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // request btn
        {
            Database db = new Database();
            if (db.saveResrvation(car_id,dateTime.Value))
            {
                MessageBox.Show("Request send");
                this.Hide();
                            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setActive(string _id,string car_name,string car_price,string des,Image image)
        {
            car_id = _id;
            ResquestImage.Image = image;
            RequestDes.Text = des;
            RequestPrice.Text = car_price;
            ResquestName.Text = car_name;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
