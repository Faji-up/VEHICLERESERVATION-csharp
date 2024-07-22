using MySql.Data.MySqlClient;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.ShowDialog();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn AND `password`= @pass", db.getConnection);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                List<User> user = db.getUsers();

                foreach (User users in user)
                {
                    if (users.Username == textBoxUsername.Text && users.Password == textBoxPassword.Text)
                    {
                        ActiveUser.Id = users.Id;
                        ActiveUser.Username = users.Username;
                        ActiveUser.Password = users.Password;
                        ActiveUser.User_ref = users.User_ref;
                        
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                        break;
                    }
                }

                
                //this.DialogResult = DialogResult.OK;
                

            }else if(textBoxUsername.Text == "Admin" && textBoxPassword.Text == "Admin")
            {
                this.Hide();
                HomeAdmincs homeAdmincs = new HomeAdmincs();
                homeAdmincs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Log in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
