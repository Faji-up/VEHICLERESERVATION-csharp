
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleReservation;

namespace VehicleReservation
{
    internal class FeedbackObj
    {
        public string User_ref { get; set; }
        public string Comment { get; set; }
        public string rating { get; set; }


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
    }
}
