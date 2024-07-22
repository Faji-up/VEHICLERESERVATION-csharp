using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;
using VehicleReservation;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using MySql.Data.Types;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
namespace VehicleReservation
{
    class Database
    {
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=CarReservation");

        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public bool addNewUser(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `user_ref`) VALUES (@username,@password,@user_ref)", getConnection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@user_ref", MySqlDbType.VarChar).Value = generateRef();


            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }
        }
        public static string generateRef()
        {
            string code = "";
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            Random random = new Random();
            for (int i = 0; i < 40; i++)
            {
                code += chars[random.Next(0, chars.Length - 1)];
            }
            return code;
        }
        public List<User> getUsers()
        {
            Database db = new Database();
            List<User> users = new List<User>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand("SELECT id,username,password,user_ref FROM `users`", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int _id = reader.GetInt32("id");
                    string username = reader.GetString("username");
                    string password = reader.GetString("password");
                    string user_ref = reader.GetString("user_ref");

                    User user = new User();
                    user.Id = _id;
                    user.Username = username;
                    user.Password = password;
                    user.User_ref = user_ref;

                    users.Add(user);

                }

            }
            closeConnection();
            return users;
        }
        public bool addNewCar(string car_name, string price, string description, MemoryStream image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `cars`(`car_name`, `price`, `description`, `image`) VALUES (@car_name,@price,@description,@image)", getConnection);

            command.Parameters.Add("@car_name", MySqlDbType.VarChar).Value = car_name;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = image.ToArray();

            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }

        }
        public List<Car> getCars()
        {

            Database db = new Database();
            List<Car> cars = new List<Car>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand("SELECT id,car_name,price,description,image FROM `cars`", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int _id = reader.GetInt32("id");
                    string carName = reader.GetString("car_name");
                    string price = reader.GetString("price");
                    string description = reader.GetString("description");
                    byte[] image = (byte[])reader["image"];
                    Car car = new Car();
                    car.Id = _id;
                    car.CarName = carName;
                    car.Price = price;
                    car.Description = description;
                    car.Image = image;

                    cars.Add(car);
                }
            }
            closeConnection();
            return cars;

        }

        public List<ReservationObject> getRes(int _id)
        {

            // "SELECT username,password,user_ref FROM `users`"
            List<ReservationObject> reservations = new List<ReservationObject>();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `reservations` WHERE id={_id}", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int Id_ = reader.GetInt32("id");
                    string car_id = reader.GetString("car_id");
                    string user_ref = reader.GetString("user_ref");
                    MySqlDateTime date = reader.GetMySqlDateTime("date");
                    string bill = reader.GetString("bill");
                    string status = reader.GetString("status");
                    MySqlDateTime end = reader.GetMySqlDateTime("end");
                    ReservationObject rev = new ReservationObject();

                    rev.Id_ = Id_;
                    rev.Card_id = Convert.ToInt32(car_id);
                    rev.User_ref = user_ref;
                    rev.Date = date;
                    rev.Bill = bill;
                    rev.Status = status;
                    rev.End = end;
                    reservations.Add(rev);
                }
            }
            closeConnection();


            return reservations;

        }



        public List<Car> getCar1(int _id)
        {

            // "SELECT username,password,user_ref FROM `users`"
            List<Car> cars = new List<Car>();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `cars` WHERE id={_id}", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    Car car = new Car();
                    car.CarName = reader.GetString("car_name");

                    cars.Add(car);
                }
            }
            closeConnection();


            return cars;

        }


        public bool saveResrvation(string car_id, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `reservation`(`car_id`, `user_ref`, `date`, `bill`,`status`) VALUES (@car_id,@user_ref,@date,@bill,@status)", getConnection);

            command.Parameters.Add("@car_id", MySqlDbType.VarChar).Value = car_id;
            command.Parameters.Add("@user_ref", MySqlDbType.VarChar).Value = ActiveUser.User_ref;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = date;
            command.Parameters.Add("@bill", MySqlDbType.VarChar).Value = "N/A";
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "false";

            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }

        }

        public bool saveFeedBack(string feedback,string rating)
        {


            MySqlCommand command = new MySqlCommand("INSERT INTO `comments`(`user_ref`, `feedback`,`rating`) VALUES (@user_ref,@feedback,@rating)", getConnection);

            //command.Parameters.Add("@car_id", MySqlDbType.VarChar).Value = car_id;
            command.Parameters.Add("@user_ref", MySqlDbType.VarChar).Value = ActiveUser.User_ref;
            command.Parameters.Add("@feedback", MySqlDbType.VarChar).Value = feedback;
            command.Parameters.Add("@rating", MySqlDbType.VarChar).Value = rating;
            

            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;

            }
            else
            {
                closeConnection();
                return false;
            }
        }
        public List<ReservationObject> getReservationsList()
        {

            Database db = new Database();
            List<ReservationObject> reservations = new List<ReservationObject>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand("SELECT `id`,`car_id`,`user_ref`,`date`,`bill`,`status`,`end` FROM `reservation`", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int Id_ = reader.GetInt32("id");
                    string car_id = reader.GetString("car_id");
                    string user_ref = reader.GetString("user_ref");
                    MySqlDateTime date = reader.GetMySqlDateTime("date");
                    string bill = reader.GetString("bill");
                    string status = reader.GetString("status");
                    MySqlDateTime dateEnd = reader.GetMySqlDateTime("end");
                    ///DateTime date = reader.GetDateTime("date");
                    ReservationObject rev = new ReservationObject();

                    rev.Id_ = Id_;
                    rev.Card_id = Convert.ToInt32(car_id);
                    rev.User_ref = user_ref;
                    rev.Date = date;
                    rev.Bill = bill;
                    rev.Status = status;
                    rev.End = dateEnd;

                    reservations.Add(rev);
                }
            }
            closeConnection();


            return reservations;
        }

        public void delete_Reservation_Object(int _id)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM `reservation` WHERE id= {_id}", getConnection);
            openConnection();
            command.ExecuteNonQuery();

            closeConnection();
        }
        public bool delete_car(int _id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand($"DELETE FROM `cars` WHERE id= {_id}", getConnection);
                openConnection();
                command.ExecuteNonQuery();

                closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool update_reservation(string status, int _id)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `reservation` SET status = @status WHERE id = @id", getConnection);


                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@id", _id);
                command.ExecuteNonQuery();

                closeConnection();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateVehicle(string car_name,string price,string description,MemoryStream image,int _id)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `cars` SET car_name = @car_name,price = @price,description = @description,image = @image WHERE id = @id", getConnection);


                command.Parameters.AddWithValue("@car_name", car_name);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@image", image.ToArray());
                command.Parameters.AddWithValue("@id", _id);
                command.ExecuteNonQuery();

                closeConnection();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


            
        }

        public bool updateUser(string username, string password,int _id)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET username = @username, password=@password WHERE id = @id", getConnection);


                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                
                command.Parameters.AddWithValue("@id", _id);
                command.ExecuteNonQuery();

                closeConnection();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool update_reservation_end_date(DateTime end, int _id)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `reservation` SET end = @end WHERE id = @id", getConnection);


                command.Parameters.AddWithValue("@end", end);
                command.Parameters.AddWithValue("@id", _id);
                command.ExecuteNonQuery();

                closeConnection();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<FeedbackObj> get_feedbacks()
        {

            // "SELECT username,password,user_ref FROM `users`"
            List<FeedbackObj> feedbacks = new List<FeedbackObj>();
            // "SELECT username,password,user_ref FROM `users`"
            MySqlCommand command = new MySqlCommand("SELECT `user_ref`,`feedback`, `rating` FROM `comments`", getConnection);
            openConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //DateTime end = Convert.ToDateTime(reader.GetDateTime("end"));   
                    FeedbackObj com = new FeedbackObj();

                    FeedbackObj feedbackObj = new FeedbackObj();
                    feedbackObj.User_ref = reader.GetString("user_ref");
                    feedbackObj.Comment = reader.GetString("feedback");
                    feedbackObj.rating = reader.GetString("rating");
                    feedbacks.Add(feedbackObj);
                }
            }
            closeConnection();




            return feedbacks;
        }


    }
}