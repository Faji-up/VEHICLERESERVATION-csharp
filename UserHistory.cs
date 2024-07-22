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
    public partial class UserHistory : Form
    {
        public UserHistory()
        {
            InitializeComponent();
            createCard();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void historyCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createCard()
        {

            Database database = new Database(); 
            foreach(ReservationObject rev in database.getReservationsList())
            {
                //MessageBox.Show($"{rev.Date.GetDateTime()} ==  {rev.End.GetDateTime()} == {rev.End.IsNull}");
                if (rev.User_ref == ActiveUser.User_ref)
                {
                    if(rev.Date.GetDateTime() >= rev.End.GetDateTime() && rev.End.IsNull == false)
                    {
                        Panel panel = new Panel();
                        panel.MinimumSize = new Size(859, 35);
                        panel.MaximumSize = new Size(859, 35);
                        panel.Size = new Size(859, 35);
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        Label text = new Label();
                        text.MinimumSize = new Size(739, 20);
                        text.MaximumSize = new Size(739, 20);
                        text.Size = new Size(739, 20);
                        text.Font = new Font("Arial",8,FontStyle.Regular);
                        text.Location = new Point(3, 5);
                        text.Text = $"Vehicle Name: {rev.get_car_name()} Start Date: {rev.Date.ToString()} End Date: {rev.End.ToString()}";


                        Button feedback  = new Button();
                        feedback.Text = "FeedBack";
                        feedback.Location = new Point(768, 5);
                        feedback.MouseClick += (x, b) =>
                        {
                            FeedbackForm feedbackForm = new FeedbackForm();
                            feedbackForm.ShowDialog();
                        };


                        panel.Controls.Add(text);
                        panel.Controls.Add(feedback);

                        historyCon.Controls.Add(panel);
                    }
                }
            }
            //MessageBox.Show("save");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();    
            UserSetting userSetting = new UserSetting();
            userSetting.ShowDialog();
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
