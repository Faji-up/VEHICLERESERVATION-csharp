using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleReservation
{
    class Car
    {
        //INSERT INTO `cars`(`car_name`, `price`, `description`, `image`) VALUES (@car_name,@price,@description,@image)
        public int Id { get; set; }
        public string CarName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }


    }
}
