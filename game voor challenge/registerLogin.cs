using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using Connection_DB;
using game_voor_challenge.data;

namespace game_voor_challenge
{
    public partial class registerLogin : Form
    {
        string username;
        string password;
        string uid;
        string cs;

        public registerLogin()
        {
            InitializeComponent();
            textboxUsername.Left = (this.ClientSize.Width - textboxUsername.Width) / 2;
            textboxUsername.Top = (this.ClientSize.Height - textboxUsername.Height) / 2;

            textboxPassword.Left = (this.ClientSize.Width - textboxUsername.Width) / 2;
            textboxPassword.Top = (this.ClientSize.Height - textboxUsername.Height) / 2 + 65;

            labelLogo.Left = (this.ClientSize.Width - labelLogo.Width) / 2;
            labelLogo.Top = (this.ClientSize.Height - labelLogo.Height) / 2 - 100;

            password = System.IO.File.ReadAllText(@"C:\Users\verst\source\repos\game voor challenge\game voor challenge\data\password.key");
            cs = @"server=gamedata.mysql.database.azure.com;userid=sven;password=" + password + ";database=data";



        }

        private void registerLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            connection connect = new connection();
            connect.Open();
            /*var con = new MySqlConnection(cs);
            con.Open();*/
            var stm = "SELECT username, password, uid FROM userdata WHERE username = '" + textboxUsername.Text + "';";
            MySqlDataReader row;
            row = connect.ExecuteReader(stm);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    username = row["username"].ToString();
                    password = row["password"].ToString();
                    uid = row["uid"].ToString();
                }

            }
            else
            {
                MessageBox.Show("Data not found", "Information");
            }

            if (username == textboxUsername.Text & password == textboxPassword.Text)
            {
                var MainGameForm = new Form1();
                MainGameForm.Location = this.Location;
                MainGameForm.StartPosition = FormStartPosition.Manual;
                MainGameForm.FormClosing += delegate { this.Show(); };
                MainGameForm.Show();
                this.Hide();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Password or username is wrong");
            }
        }
    }
}
