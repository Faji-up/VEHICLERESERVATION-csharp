
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
    public partial class HomeAdmincs : Form
    {
        public HomeAdmincs()
        {
            InitializeComponent();displayVehichles();
        }

        private void HomeAdmincs_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddVehiclePage addVehiclePage = new AddVehiclePage();
            addVehiclePage.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        public void displayVehichles()
        {  
            AvailableVehicleFrame.Controls.Clear();
            Database db = new Database();
            List<Car> cars = db.getCars();

            int panelC = 3;
            int panelW = 260;
            int panelH = 350;
            int panelS = 20;
            
            if(cars.Count > 0)
            {
                foreach(Car car in cars)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(panelW, panelH);
                    
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.MaximumSize = new Size(panelW, panelH);
                    panel.MinimumSize = new Size(panelW, panelH);
                    panel.BackColor = System.Drawing.Color.Cornsilk;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    
                    Label carNameLabel = new Label();
                    carNameLabel.Text = car.CarName;
                    carNameLabel.MinimumSize = new Size(120, 80);
                    carNameLabel.MaximumSize = new Size(120, 80);
                    carNameLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    carNameLabel.Location = new Point(5,5);
                    carNameLabel.BackColor = System.Drawing.Color.Yellow;
                    carNameLabel.Font = new Font("Swis721 Blk BT, 9.75pt",10,FontStyle.Bold);
                    
                    Label priceNameLabel = new Label();
                    priceNameLabel.Text = car.Price;
                    priceNameLabel.MinimumSize = new Size(120, 50);
                    priceNameLabel.MaximumSize = new Size(120, 50);
                    priceNameLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    priceNameLabel.Location = new Point(5, 85);
                    priceNameLabel.BackColor = System.Drawing.Color.Gold;
                    priceNameLabel.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                    priceNameLabel.Size = new Size(120, 50);
                    

                    Label desNameLabel = new Label();
                    desNameLabel.Text = car.Description;
                    desNameLabel.MinimumSize = new Size(120, 130);
                    desNameLabel.MaximumSize = new Size(120, 130);
                    desNameLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    desNameLabel.Location = new Point(130, 5);
                    desNameLabel.BackColor = System.Drawing.Color.Gold;
                    desNameLabel.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                    desNameLabel.Size = new Size(120, 130);
                   

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(8, 150);
                    pictureBox.Size = new Size(242, 160);
                    pictureBox.MaximumSize = new Size(242, 160);
                    pictureBox.MinimumSize = new Size(242, 160);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = new ByteToImage(car.Image).convert();
                   

                    Button delteBtn = new Button();
                    delteBtn.BackColor = Color.Red;
                    delteBtn.Text = "Delete";
                    delteBtn.Location = new Point(3, 320);
                    delteBtn.MouseClick += (s, f) =>
                    {
                        if (MessageBox.Show("Delete this vehicle?", "Delete", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            if (db.delete_car(car.Id))
                            {
                                displayVehichles();
                            }
                        }
                    };

                    Button openEdit = new Button();
                    openEdit.BackColor = Color.Blue;
                    openEdit.Text = "Edit";
                    openEdit.Location = new Point(120, 320);
                    openEdit.MouseClick += (s, f) =>
                    {
                        MessageBox.Show(Convert.ToString(car.Id));
                       UpdateCarPage updateCarPage = new UpdateCarPage();
                        updateCarPage.setData(car.Id);
                        updateCarPage.ShowDialog();
                    };

                    panel.Controls.Add(carNameLabel);
                    panel.Controls.Add(priceNameLabel);
                    panel.Controls.Add(desNameLabel);
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(delteBtn);
                    panel.Controls.Add(openEdit);


                    AvailableVehicleFrame.Controls.Add(panel);
                    
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void AvailableVehicleFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminNotifPage notif = new AdminNotifPage();
            notif.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReservationMainPage mainPage = new ReservationMainPage();   
            mainPage.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeedbackPage feedbackPage = new FeedbackPage(); 
            feedbackPage.ShowDialog();
        }
    }
}
