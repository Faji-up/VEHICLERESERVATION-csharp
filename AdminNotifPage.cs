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
    public partial class AdminNotifPage : Form
    {
        public AdminNotifPage()
        {
            InitializeComponent();
            createCard();
        }

        private void AdminNotifPage_Load(object sender, EventArgs e)
        {

        }

        private void AvailableVehicleFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createCard()
        {
            Database database = new Database();

            foreach (ReservationObject rev in database.getReservationsList())
            {
                if (rev.isApproved() == false)
                {
                    Panel con = new Panel();
                    con.MinimumSize = new Size(733, 100);
                    con.MaximumSize = new Size(733, 100);
                    con.Size = new Size(733, 100);
                    con.BackColor = Color.Gainsboro;
                    con.BorderStyle = BorderStyle.FixedSingle;


                    Button acceptBtn = new Button();
                    acceptBtn.BackColor = Color.Blue;
                    acceptBtn.Location = new Point(637, 29);
                    acceptBtn.Text = "Accept";
                    acceptBtn.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    acceptBtn.MouseClick += (s, r) =>
                    {
                        rev.setApproval();
                        resquestCon.Controls.Clear();
                        createCard();
                    };


                    Button rejectBtn = new Button();
                    rejectBtn.BackColor = Color.Red;
                    rejectBtn.Location = new Point(637, 61);
                    rejectBtn.Text = "Reject";
                    rejectBtn.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    rejectBtn.MouseClick += (s, r) =>
                    {
                        rev.delete_from_db();
                        resquestCon.Controls.Clear();
                        createCard();
                    };


                    Label conten1 = new Label();
                    conten1.MinimumSize = new Size(280, 80);
                    conten1.MaximumSize = new Size(280, 80);
                    conten1.Size = new Size(280, 80);
                    conten1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    conten1.Text = $"Request From: {rev.get_user().Username}\nRequest For: {rev.get_car().CarName}\nDate of Request: {rev.Date}";

                    con.Controls.Add(acceptBtn);
                    con.Controls.Add(rejectBtn);
                    con.Controls.Add(conten1);
                    

                    resquestCon.Controls.Add(con);
                }

            }

        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationMainPage reservationMainPage = new ReservationMainPage();
            reservationMainPage.ShowDialog();
        }

        private void AddTo_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddVehiclePage addVehiclePage = new AddVehiclePage();
            addVehiclePage.ShowDialog();
        }

        private void ShowAvialable_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmincs homeAdmincs = new HomeAdmincs();
           homeAdmincs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            FeedbackPage feedbackPage = new FeedbackPage();
            feedbackPage.ShowDialog();
        }
    }
}
