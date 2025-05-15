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
using DatabaseConnection;


namespace PHARMACY_SYSTEM
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            username_lbl.Text = login.instance.usernameTxt.Text;
            getAllInfo();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();


        }





        private void insertAccId(int acc_id)
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();


            string query = "SELECT acc_id FROM employee where acc_id = @id  ; ";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
            cmd.Parameters.AddWithValue("@id", acc_id);
            cmd.Prepare();
            if (cmd.ExecuteScalar() == null)
            {
                string query2 = "INSERT INTO employee (acc_id) VALUES(@acc_id) ;";
                MySqlCommand cmd2 = new MySqlCommand(query2, dbConnection.conn);
                cmd2.Parameters.AddWithValue("@acc_id", acc_id);
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
             }

            dbConnection.conn.Close();
        }


        private void insertEmployeeinfo()
        {

            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            try
            {

                int acc_id;
                string query = "SELECT acc_id FROM account where acc_email = @username";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                cmd.Parameters.AddWithValue("@username", login.instance.usernameTxt.Text);

                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    acc_id = reader.GetInt32("acc_id");
                    insertAccId(acc_id);
                }


            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }



            dbConnection.conn.Close();
        }


        private void getAccID()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT acc_id FROM account where acc_email = @username";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            cmd.Parameters.AddWithValue("@username", login.instance.usernameTxt.Text);

            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int acc_id = reader.GetInt32("acc_id");
                acc_id_lbl.Text =  Convert.ToString(acc_id);
            }

            dbConnection.conn.Close();
        }

        private void getFirstName()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT first_name FROM employee where acc_id = @id ; ";
            MySqlCommand cmd = new MySqlCommand(query , dbConnection.conn ) ;

            cmd.Parameters.AddWithValue("@id", acc_id_lbl.Text);
            cmd.Prepare();


            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                fname_lbl.Text = reader.GetString("first_name");
            }




            dbConnection.conn.Close();
        }

        private void getLastName()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT last_name FROM employee where acc_id = @id ; ";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            cmd.Parameters.AddWithValue("@id", acc_id_lbl.Text);
            cmd.Prepare();


            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                last_namelbl.Text = reader.GetString("last_name");
            }




            dbConnection.conn.Close();
        }

        private void getMiddleName()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT middle_name FROM employee where acc_id = @id ; ";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            cmd.Parameters.AddWithValue("@id", acc_id_lbl.Text);
            cmd.Prepare();


            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                middle_namelbl.Text = reader.GetString("middle_name");
            }




            dbConnection.conn.Close();
        }

        private void getAge()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT age FROM employee where acc_id = @id ; ";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            cmd.Parameters.AddWithValue("@id", acc_id_lbl.Text);
            cmd.Prepare();


            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int age = reader.GetInt32("age");
                age_lbl.Text = Convert.ToString(age);
            }




            dbConnection.conn.Close();
        }

        private void getGender()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT gender FROM employee where acc_id = @id ; ";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

            cmd.Parameters.AddWithValue("@id", acc_id_lbl.Text);
            cmd.Prepare();


            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                genderlbl.Text = reader.GetString("gender");
            }




            dbConnection.conn.Close();
        }

        private void getAllInfo()
        {
            getAccID();
            insertEmployeeinfo();
            getFirstName();
            getLastName();
            getMiddleName();
            getAge();
            getGender();
        }



        public string updateColumn = "";    

        private void pickUpdateBtn_Click(object sender, EventArgs e)
        {
            updateMenu.Show(pickUpdateBtn, 1, pickUpdateBtn.Height);
        }

        private void updateMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            updateColumn = e.ClickedItem.Text;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {


            try
            {

                if(!string.IsNullOrEmpty(updaterInput.Text) && !string.IsNullOrEmpty(accId_input.Text) )
                {
                    dbConnection.connectionFunc();
                    dbConnection.conn.Open();

                    string query = "UPDATE employee SET " + updateColumn + " =  '"+updaterInput.Text+"'  WHERE employee_id = "+ accId_input.Text + " ;   ";
                    MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);

                    cmd.ExecuteNonQuery();

                    getAllInfo();
                    dbConnection.conn.Close();

                } else
                {
                    MessageBox.Show("Please put the right inputs");
                }


            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }




    }
}
