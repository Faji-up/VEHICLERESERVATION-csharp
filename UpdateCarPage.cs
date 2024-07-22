
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
    public partial class UpdateCarPage : Form
    {
        public int VehicleID { get; set; }
        public UpdateCarPage()
        {
            InitializeComponent();
            
          
        }

        private void UpdateCarPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();

                string car_name = nameText.Text;
                string price = priceText.Text;
                string des = desText.Text;
                MemoryStream car_image = new MemoryStream();

                imageCon.Image.Save(car_image, imageCon.Image.RawFormat);
                MessageBox.Show($"{VehicleID}");
                if (database.updateVehicle(car_name, price, des, car_image, VehicleID))
                {
                    MessageBox.Show("Updated Successful");
                    HomeAdmincs homeAdmincs = new HomeAdmincs();
                    homeAdmincs.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Updating Error");
                }
            }catch(Exception)
            {
                MessageBox.Show("PLease Choose New Image","Required");
            }
        }
        public void setData(int _id)
        {
            VehicleID = _id;
            Database database = new Database();
            foreach(Car car in database.getCars()){
                MessageBox.Show($"{car.Id} == {_id}");
                if(car.Id == _id) {

                    imageCon.Image = new ByteToImage(car.Image).convert();
                    nameText.Text = car.CarName;
                    priceText.Text = car.Price;
                    desText.Text = car.Description;
                    break;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageCon.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
