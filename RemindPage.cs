
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleReservation
{
    public partial class RemindPage : Form
    {
        private int reservation_id = 0;
        private string panel;
        public RemindPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.update_reservation_end_date(dateEnd.Value, this.reservation_id))
            {
                
                MessageBox.Show("Reminder Send Sucessful");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Reminder Send Error");
            }

        }

        public void set_reservation_id(int reservation_id)
        {
            this.reservation_id = reservation_id;
         
        
        }

        
    }

}
