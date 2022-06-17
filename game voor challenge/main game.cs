using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Connection_DB;

namespace game_voor_challenge
{
    public partial class Form1 : Form
    {
        // String with password.
        string password;

        //Mysql Connection settings.
        string cs;

        // [0] = water
        // [1] = wood
        // [2] = coal
        // [3] = stone
        int[] itemAmounts = { 0, 0, 0, 0};
        string[] itemName = { "water", "coal", "wood", "stone" };

        string username;
        string uid;

        public Form1()
        {
            InitializeComponent();

            password = System.IO.File.ReadAllText(@"C:\Users\verst\source\repos\game voor challenge\game voor challenge\data\password.key");
            cs = @"server=gamedata.mysql.database.azure.com;userid=sven;password=" + password + ";database=data";

            connection connect = new connection();
            connect.Open();
            /*var con = new MySqlConnection(cs);
            con.Open();*/
            var stm = "SELECT username, uid, water, coal, wood, stone FROM userdata WHERE uid = " + 0 + ";";
            MySqlDataReader row;
            row = connect.ExecuteReader(stm);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    itemAmounts[0] = Int32.Parse(row["water"].ToString());
                    itemAmounts[1] = Int32.Parse(row["coal"].ToString());
                    itemAmounts[2] = Int32.Parse(row["wood"].ToString());
                    itemAmounts[3] = Int32.Parse(row["stone"].ToString());
                    uid = row["uid"].ToString();
                    username = row["username"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data not found", "Information");
            }
            itemTable21.Text = itemAmounts[0].ToString();
            itemTable22.Text = itemAmounts[1].ToString();
            itemTable23.Text = itemAmounts[2].ToString();
            itemTable24.Text = itemAmounts[3].ToString();
            labelUsernameText.Text = username;
        }

        private void sqlUidLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void labelUsernameText_Click(object sender, EventArgs e)
        {
            profileContextMenu.Show(MousePosition);
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            profileContextMenu.Show(MousePosition);
        }

        private void profileAbout_Click(object sender, EventArgs e)
        {
            about box = new about();
            box.ShowDialog();
        }

        private void profileSettings_Click(object sender, EventArgs e)
        {
            Settings settingsScreen = new Settings();
            settingsScreen.ShowDialog();
        }

        private void profileContextMenu_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
