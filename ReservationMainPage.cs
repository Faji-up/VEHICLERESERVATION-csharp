
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
    public partial class ReservationMainPage : Form
    {
        public ReservationMainPage()
        {
            InitializeComponent();
            createReservationCard();
        }

        private void ReservationMainPage_Load(object sender, EventArgs e)
        {

        }

        private void ShowAvialable_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmincs homeAdmincs = new HomeAdmincs();
            homeAdmincs.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReservedTrueFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void createReservationCard()
        {
            ReservedTrueFrame.Controls.Clear();
            Database db = new Database();
            List<ReservationObject> reservationObjects = db.getReservationsList();

            if(reservationObjects.Count > 0)
            {
                foreach(ReservationObject obj in reservationObjects)
                {
                    if(obj.Status == "true")
                    {
                        Panel card = new Panel();
                        card.BackColor = System.Drawing.Color.Gold;
                        card.MinimumSize = new Size(395, 173);
                        card.BorderStyle = BorderStyle.FixedSingle;


                        Label vehicleName = new Label();
                        vehicleName.MinimumSize = new Size(359, 20);
                        vehicleName.MaximumSize = new Size(359, 20);
                        vehicleName.Size = new Size(359, 20);
                        vehicleName.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                        vehicleName.Location = new Point(13, 19);
                        vehicleName.Text = "Vehicle: " + obj.get_car_name();

                        Label date = new Label();
                        date.MinimumSize = new Size(359, 20);
                        date.MaximumSize = new Size(359, 20);
                        date.Size = new Size(359, 20);
                        date.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                        date.Location = new Point(13, 48);
                        date.Text = "Date start: " + Convert.ToString(obj.Date.ToString());


                        Label user = new Label();
                        user.MinimumSize = new Size(359, 20);
                        user.MaximumSize = new Size(359, 20);
                        user.Size = new Size(359, 20);
                        user.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                        user.Location = new Point(13, 78);
                        user.Text = "User: " + obj.get_user().Username;

                        Label end = new Label();
                        end.MinimumSize = new Size(359, 20);
                        end.MaximumSize = new Size(359, 20);
                        end.Size = new Size(359, 20);
                        end.Font = new Font("Swis721 Blk BT, 9.75pt", 10, FontStyle.Bold);
                        end.Location = new Point(13, 115);
                        end.Text = "End: " + Convert.ToString(obj.End.ToString());

                        Button remind = new Button();
                        remind.MinimumSize = new Size(92, 32);
                        remind.MaximumSize = new Size(92, 32);
                        remind.Size = new Size(92, 32);
                        remind.BackColor = System.Drawing.Color.Green;
                        remind.Font = new Font("SansSerif, 9.749999pt", 10, FontStyle.Regular);
                        remind.Location = new Point(300, 138);
                        remind.Text = "Remind";
                        
                        remind.MouseClick += (s, r) =>
                        {

                            RemindPage remindPage = new RemindPage();
                            remindPage.set_reservation_id(obj.Id_);
                            remindPage.ShowDialog();
                            createReservationCard();

                        };

                        card.Controls.Add(vehicleName);
                        card.Controls.Add(date);
                        card.Controls.Add(user);
                        card.Controls.Add(end);
                        card.Controls.Add(remind);


                        ReservedTrueFrame.Controls.Add(card);

                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           AdminNotifPage notif = new AdminNotifPage();
           notif.ShowDialog();
        }

        private void AddTo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVehiclePage addVehicle = new AddVehiclePage();
            addVehicle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            ReservationMainPage mainPage = new ReservationMainPage();
            mainPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeedbackPage feedbackPage = new FeedbackPage();
            feedbackPage.ShowDialog();
        }
    }
}
