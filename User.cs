using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace VehicleReservation
{
    public class User

    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string User_ref { get; set; }

    }
}
