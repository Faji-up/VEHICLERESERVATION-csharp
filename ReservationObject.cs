using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleReservation;

namespace VehicleReservation
{
    internal class ReservationObject
    {
        public int Id_ { get; set; }
        public int Card_id { get; set; }
        public string User_ref { get; set; }
        public MySqlDateTime Date { get; set; }
        public string Bill { get; set; }
        public string Status { get; set; }
        public MySqlDateTime End { get; set; }


        public string get_car_name()
        {
            Database db = new Database();
            List<Car> car = db.getCar1(Card_id);
            if (car.Count > 0)
            {
                return car[0].CarName;

            }
            return "Vehicle Deleted";
        }

        public User get_user()
        {
            Database db = new Database();
            List<User> users = db.getUsers();
            foreach (User user in users)
            {
                if (user.User_ref == this.User_ref)
                {
                    return user;

                }
            }
            return null;

        }
        public bool isApproved()
        {
            if (Convert.ToBoolean(this.Status))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public Car get_car()
        {
            Database db = new Database();
            List<Car> cars = db.getCars();
            foreach (Car car in cars)
            {
                if (car.Id == this.Card_id)
                {
                    return car;
                }
            }
            return null;
        }

        public void delete_from_db()
        {
            Database db = new Database();
            db.delete_Reservation_Object(this.Id_);
        }

        public void setApproval()
        {
            Database db = new Database();

            if (db.update_reservation("true", this.Id_))
            {
                MessageBox.Show("Upadated Successful");
            }
            else
            {
                MessageBox.Show("Error to update");
            }
        }
    }
}
