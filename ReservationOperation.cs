
using MySql.Data.MySqlClient;
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
    class ReservationOperation
    {
        public string car_id;
        public string car_name;
        public string car_price;
        public string car_des;
        public Image image;
        public ReservationOperation(string car_id, string car_name, string car_price, string des, Image image)
        {


            this.car_id = car_id;
            this.car_name = car_name;
            this.car_price = car_price;
            this.car_des = des;
            this.image = image;
        }


        public void reserve()
        {

            DateTime date = DateTime.Now.Date;

            ReservationPage page = new ReservationPage();
            page.setActive(this.car_id, this.car_name, this.car_price, this.car_des, this.image);
            page.ShowDialog();
        }



    }

}
