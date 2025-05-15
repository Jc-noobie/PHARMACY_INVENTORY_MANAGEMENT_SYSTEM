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
using DatabaseConnection;

namespace PHARMACY_SYSTEM
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

  
        
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void dashboard_Load(object sender, EventArgs e)
        {
            loadForm(new showMed());
            WindowState = FormWindowState.Maximized;
                



             
        }



        // THIS FUNCTION IS FOR DRAGGING THE FORM
        private void tabPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
   

        // THIS FUNCTION IS FOR LOADING THE FORMS IN THE DASHBOARD
        public void loadForm(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f= Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f); 
            this.mainPanel.Tag = f;
            f.Show();
        }


        // THIS FUNCTIONS IS THE BUTTONS TO PICK THE FORMS 
        private void showBtn_Click(object sender, EventArgs e)
        {
            loadForm(new showMed());
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            loadForm(new insertMed());
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            loadForm(new profile());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? (your shift would be logged out)", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                logout(); 
                this.Close();
            }  
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)  {
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }
        }




        private int getShift_id()
        {
            int acc_id = getAcc_id();
            int shift_id;  
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT max(shift_id) as shift_id FROM shift_tracker WHERE acc_id = @id ;";
                MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);
                cmd.Parameters.AddWithValue("@id", acc_id);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader(); 
                while(reader.Read())
                {
                    shift_id = reader.GetInt32("shift_id");
                    return shift_id; 
                }


                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return 0;
        }


        private int getAcc_id()
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT acc_id FROM account where acc_email = '" + login.instance.usernameTxt.Text + "'  ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int acc_id = reader.GetInt32("acc_id");
                    reader.Close();
                    return acc_id;
                }


                dbConnection.conn.Close();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return 0;
        }

        private void insertHoursWorked(string hoursworked, int shift_id, int acc_id)
        {
            try
            {

                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string update = "UPDATE shift_tracker SET hours_worked = '"+ hoursworked + "' where shift_id = "+shift_id+" and acc_id = " + acc_id + "   ";
                MySqlCommand cmd = new MySqlCommand(update, dbConnection.conn);

                cmd.ExecuteNonQuery(); 

                dbConnection.conn.Close();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void calcHoursworked()
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                int shift_id = getShift_id();
                int acc_id = getAcc_id();
                string hoursworked; 

                string queryForHours = "select time(abs(timediff(hour_started,hour_ended))) as worked from shift_tracker where shift_id = "+shift_id+"   and acc_id = "+acc_id+"";
                MySqlCommand cmd = new MySqlCommand(queryForHours, dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    hoursworked = Convert.ToString( reader.GetTimeSpan("worked"));
                    insertHoursWorked(hoursworked, shift_id, acc_id);
                }

                dbConnection.conn.Close();
                
            }catch(MySqlException err) {  
                MessageBox.Show(err.Message.ToString());
            }


        }


        private void logout()
        {
            login.instance.loggedin = false;
            int acc_id = getAcc_id();
            int shift_id = getShift_id();
            try
            {

                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "UPDATE shift_tracker SET hour_ended = current_time() WHERE acc_id = @id AND shift_id = @shiftId ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                cmd.Parameters.AddWithValue("@id", acc_id);
                cmd.Parameters.AddWithValue("@shiftId", shift_id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                calcHoursworked();

                dbConnection.conn.Close();

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?" ,"Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                logout();
            }
        }

    }
}
