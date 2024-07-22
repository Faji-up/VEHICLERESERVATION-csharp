
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
    public partial class FeedbackPage : Form
    {
        public FeedbackPage()
        {
            InitializeComponent();
            createPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void feedbackCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createPanel()
        {

            Database database = new Database();

            List<FeedbackObj> feedbacks = database.get_feedbacks();
            foreach (FeedbackObj feedback in feedbacks)
            {
                Panel con = new Panel();
                con.Size = new Size(447, 282);
                con.MaximumSize = new Size(447, 282);
                con.MinimumSize = new Size(447, 282);
                con.BorderStyle = BorderStyle.FixedSingle;
                con.BackColor = System.Drawing.Color.White;


                Label userName = new Label();
                userName.BackColor = System.Drawing.Color.WhiteSmoke;
                userName.MinimumSize = new Size(250, 25);
                userName.Size = new Size(250, 25);
                userName.MaximumSize = new Size(250, 25);
                userName.Location = new Point(14, 25);
                userName.Text = $"From:{feedback.get_user().Username}";

                Label rating = new Label();
                rating.BackColor = System.Drawing.Color.WhiteSmoke;
                rating.MinimumSize = new Size(160, 25);
                rating.Size = new Size(160, 25);
                rating.MaximumSize = new Size(160, 25);
                rating.Location = new Point(270, 25);
                rating.Text = $"Ratings: {feedback.rating}";

                Label comment = new Label();
                comment.BackColor = System.Drawing.Color.WhiteSmoke;
                comment.MinimumSize = new Size(420, 200);
                comment.Size = new Size(420, 200);
                comment.MaximumSize = new Size(420, 200);
                comment.Location = new Point(14, 70);
                comment.Text = feedback.Comment;


                con.Controls.Add(userName);

                con.Controls.Add(rating);
                con.Controls.Add(comment);

                feedbackCon.Controls.Add(con);
            }


            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void feedbackCon_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
