using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using DatabaseConnection;



namespace PHARMACY_SYSTEM
{
    public partial class login : Form
    {

        public static login instance;
        public static int acc_idtemp;


        public TextBox usernameTxt;


        public login()
        {
            InitializeComponent();
            instance = this;

            usernameTxt = userInput;
            acc_idtemp = getAcc_id();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        private void loginFRM_Load(object sender, EventArgs e)
        {

        }

        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void tabPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        public int userAccId;

        private int getAcc_id()
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT acc_id FROM account where acc_email = '"+userInput.Text+ "'  "; 
                MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);

                MySqlDataReader reader = cmd.ExecuteReader(); 
                if(reader.Read())
                {
                    int acc_id = reader.GetInt32("acc_id");
                    reader.Close();
                    return acc_id;
                }


                dbConnection.conn.Close();

            } catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return 0;
        }


        
        public bool loggedin = false;
        private void insertShift(int acc_id)
        {

            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                if(!loggedin)
                {
                    string query = "INSERT INTO shift_tracker (acc_id,shift_date,hour_started) VALUES (@acc_id, current_date(), current_time())" ;
                    MySqlCommand cmd = new MySqlCommand( query,dbConnection.conn);

                    cmd.Parameters.AddWithValue("@acc_id", acc_id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    loggedin = true;
                }

                dbConnection.conn.Close();

            }catch(MySqlException er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }


        private string getPassword(int acc_id  )
        {

            
            string temp_pass;
            try
            {
                string tempusername = userInput.Text;
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT cast(aes_decrypt(acc_password , 'passwordkey' ) AS varchar(255)) as password FROM account where acc_id = @id ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                cmd.Parameters.AddWithValue("@id", acc_id); 

                MySqlDataReader reader  = cmd.ExecuteReader();  
                while (reader.Read())
                {
                    temp_pass = reader.GetString("password");
                    return temp_pass;
                }


                dbConnection.conn.Close(); 
            }
            catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());    
            }


            return ""; 
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            userAccId = getAcc_id();
            //string passworddecrypted = getPassword(userAccId);

            string tempusername = userInput.Text;
            string temppass = passInput.Text;


            try
            {

                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "select acc_email, cast(aes_decrypt(acc_password, 'passwordkey' ) AS VARCHAR(255))  as password from account where acc_id = @id "; 
                MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);
                cmd.Parameters.AddWithValue("@id", userAccId);
                cmd.Prepare();

                if (cmd.ExecuteScalar() != null)
                {
                    MessageBox.Show("SUCCESSFULLY LOGGED IN!");
                    insertShift(userAccId);


                    this.Hide();
                    dashboard dsh = new dashboard();
                    dsh.ShowDialog();
                    dsh = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }




                dbConnection.conn.Close();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register rgForm = new register();
            rgForm.ShowDialog();
            rgForm = null;
            this.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) {
                passInput.UseSystemPasswordChar = false;

            } else
            {
                passInput.UseSystemPasswordChar = true;
            }
        }
















    }
}
