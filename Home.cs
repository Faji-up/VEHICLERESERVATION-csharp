
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            MessageBox.Show(ActiveUser.User_ref);
            createPanelCars();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openRegisterBtn_MouseCLick(int car_name)
        {
            MessageBox.Show(Convert.ToString(car_name));

         }
        public void createPanelCars()
        {
            Database db = new Database();
            List<Car> cars = db.getCars();

            int panelC = 3;
            int panelW = 260;
            int panelH = 345;
            int panelS = 20;

            if (cars.Count > 0)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(panelW, panelH);
                    panel.Location = new Point(panelS + (panelW + panelS) * i, panelS);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.MaximumSize = new Size(panelW, panelH);
                    panel.MinimumSize = new Size(panelW, panelH);
                    panel.BackColor = System.Drawing.Color.Cornsilk;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    

                    Label carNameLabel = new Label();
                    carNameLabel.Text = cars[i].CarName;
                    carNameLabel.MinimumSize = new Size(120, 80);
                    carNameLabel.MaximumSize = new Size(120, 80);
                    carNameLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    carNameLabel.Location = new Point(5, 5);
                    carNameLabel.BackColor = System.Drawing.Color.Yellow;
                    carNameLabel.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);

                    Label priceNameLabel = new Label();
                    priceNameLabel.Text = cars[i].Price;
                    priceNameLabel.MinimumSize = new Size(120, 50);
                    priceNameLabel.MaximumSize = new Size(120, 50);
                    priceNameLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    priceNameLabel.Location = new Point(5, 85);
                    priceNameLabel.BackColor = System.Drawing.Color.Gold;
                    priceNameLabel.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                    priceNameLabel.Size = new Size(120, 50);

                    Label desNameLabel = new Label();
                    desNameLabel.Text = cars[i].Description;
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
                    pictureBox.Image = new ByteToImage(cars[i].Image).convert();

                    Button openRegisterBtn = new Button();
                    openRegisterBtn.Dock = DockStyle.Bottom;
                    openRegisterBtn.Text = "Reserve";
                    openRegisterBtn.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                    openRegisterBtn.MinimumSize = new Size(panelW, 26);
                    openRegisterBtn.Name = "openReserveFrame";
                    openRegisterBtn.MaximumSize = new Size(panelW, 26);
                    openRegisterBtn.Name = Convert.ToString(cars[i].Id);
                    
                    openRegisterBtn.MouseClick += (s, e) => {
                        new ReservationOperation(openRegisterBtn.Name, carNameLabel.Text, priceNameLabel.Text, desNameLabel.Text, pictureBox.Image).reserve();
                    };

                    panel.Controls.Add(carNameLabel);
                    panel.Controls.Add(priceNameLabel);
                    panel.Controls.Add(desNameLabel);
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(openRegisterBtn);
                  

                    UserCarsCon.Controls.Add(panel);

                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void UserCarsCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showSearch_Click(object sender, EventArgs e)
        {
            this.Hide();

            SearchPage searchPage = new SearchPage();
            searchPage.ShowDialog();
        }

        private void UserCarsCon_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            userReservationPage _userReservationPage = new userReservationPage();    
            _userReservationPage.ShowDialog();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserSetting userSetting = new UserSetting();
            userSetting.ShowDialog();
        }

        private void showCars_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHistory userHistory = new UserHistory();
            userHistory.ShowDialog();
        }
    }
}
