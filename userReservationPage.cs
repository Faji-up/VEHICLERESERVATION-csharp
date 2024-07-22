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
    public partial class userReservationPage : Form
    {
        public userReservationPage()
        {
            InitializeComponent();
            createPanel("pending");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createPanel(string type)
        {

            
            userReservationCon.Controls.Clear();
            Database db = new Database();
            List<ReservationObject> reservations = db.getReservationsList();
            List<ReservationObject> myrev = new List<ReservationObject>();

            foreach (ReservationObject reserv in reservations)
            {
                //MessageBox.Show($"user:{ActiveUser.User_ref} == {reserv.User_ref}");
                if(ActiveUser.User_ref == reserv.User_ref)
                {
                    myrev.Add(reserv);
                }
            }
            if(type == "approved")
            {
                foreach(ReservationObject res in myrev)
                {
                    if(res.Status == "true")
                    {
                        Panel con = new Panel();
                        con.Size = new Size(860, 197);
                        con.MaximumSize = new Size(860, 197);
                        con.MinimumSize = new Size(860, 197);
                        con.BackColor = System.Drawing.Color.Beige;


                        PictureBox image = new PictureBox();
                        image.Location = new Point(15, 16);
                        image.BorderStyle = BorderStyle.FixedSingle;
                        image.MinimumSize = new Size(242, 160);
                        image.MaximumSize = new Size(242, 160);
                        image.Size = new Size(242, 160);
                        image.Image = new ByteToImage(res.get_car().Image).convert();

                        Label content = new Label();
                        content.Size = new Size(470, 120);
                        content.MaximumSize = new Size(470, 120);
                        content.MinimumSize = new Size(470, 120);
                        content.Font = new Font("Gadugi", 14, FontStyle.Bold);
                        content.Location = new Point(263, 16);
                        content.Text = $"{res.get_car().CarName}\nPrice: {res.get_car().Price}\nDate: {res.Date.ToString()}\nEnd Date: {res.End.ToString()}";

                        Label status = new Label();
                        status.Location = new Point(746, 155);
                        status.MinimumSize = new Size(100, 30);
                        status.MaximumSize = new Size(100, 30);
                        status.Size = new Size(100, 30);
                        status.Font = new Font("Gadugi", 14, FontStyle.Bold);
                        status.Text = $"Apprved";
                        status.BackColor = Color.Green;

                        con.Controls.Add(image);
                        con.Controls.Add(content);
                        con.Controls.Add(status);


                        userReservationCon.Controls.Add(con);
                    }
                }

                
            }
            else if(type == "pending")
            {
               
                foreach (ReservationObject res in myrev)
                {
                  //  MessageBox.Show($"{res.Status}");
                    if (res.Status == "false")
                    {
                        
                        Panel con = new Panel();
                        con.Size = new Size(860, 197);
                        con.MaximumSize = new Size(860, 197);
                        con.MinimumSize = new Size(860, 197);
                        con.BackColor = System.Drawing.Color.Beige;


                        PictureBox image = new PictureBox();
                        image.Location = new Point(15, 16);
                        image.BorderStyle = BorderStyle.FixedSingle;
                        image.MinimumSize = new Size(242, 160);
                        image.MaximumSize = new Size(242, 160);
                        image.Size = new Size(242, 160);
                        image.Image = new ByteToImage(res.get_car().Image).convert();

                        Label content = new Label();
                        content.Size = new Size(470, 120);
                        content.MaximumSize = new Size(470, 120);
                        content.MinimumSize = new Size(470, 120);
                        content.Font = new Font("Gadugi", 14, FontStyle.Bold);
                        content.Location = new Point(263, 16);
                        content.Text = $"{res.get_car().CarName}\nPrice: {res.get_car().Price}\nDate: {res.Date.ToString()}";

                        Label status = new Label();
                        status.Location = new Point(746, 155);
                        status.MinimumSize = new Size(100, 30);
                        status.MaximumSize = new Size(100, 30);
                        status.Size = new Size(100, 30);
                        status.Font = new Font("Gadugi", 14, FontStyle.Bold);
                        status.Text = $"Pending";
                        status.BackColor = Color.Orange;

                        con.Controls.Add(image);
                        con.Controls.Add(content);
                        con.Controls.Add(status);


                        userReservationCon.Controls.Add(con);
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createPanel("approved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createPanel("pending");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void profileBtn_Click(object sender, EventArgs e)
        {

            this.Hide();

            UserSetting userSetting = new UserSetting();
            userSetting.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHistory userHistory = new UserHistory();
            userHistory.ShowDialog();
        }
    }
}
