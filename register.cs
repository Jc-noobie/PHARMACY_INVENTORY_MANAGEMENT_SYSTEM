using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;
using DatabaseConnection; 

namespace PHARMACY_SYSTEM
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
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

        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    
       

        private void InsertAcc()
        {

            try
           {

                dbConnection.connectionFunc();

                if (emailInput.Text != "" && passInput.Text != "")
                {
                    bool checker = checkIfemailUnique();
                    if (checker)
                    {
                        dbConnection.conn.Open();
                        string query = "INSERT INTO account(acc_email,acc_password) values (@email,  aes_encrypt(@pass, @key )  ) ;";
                        MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                        cmd.Parameters.AddWithValue("@email", this.emailInput.Text);
                        cmd.Parameters.AddWithValue("@pass", this.passInput.Text);
                        cmd.Parameters.AddWithValue("@key", "passwordkey");
                        cmd.Prepare();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("REGISTERED!");
                        dbConnection.conn.Close();

                    } else
                    {
                        MessageBox.Show("The email you entered is already registered!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill everything up");
                }

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private bool checkIfemailUnique()
        {

            try
            {

                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT * FROM account where acc_email = @email;  ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                cmd.Parameters.AddWithValue("@email", this.emailInput.Text);
                cmd.Prepare();

                if (cmd.ExecuteScalar() == null)
                {
                    dbConnection.conn.Close();
                    return true;
                }
                else
                {
                    dbConnection.conn.Close();
                    return false;
                }


            }
            catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return true; 
        }



        private void registerBtn_Click(object sender, EventArgs e)
        {
           InsertAcc();

        }



        private void loginLoader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                passInput.UseSystemPasswordChar = false;
            } else
            {
                passInput.UseSystemPasswordChar = true;
            }
        }



    }
}
