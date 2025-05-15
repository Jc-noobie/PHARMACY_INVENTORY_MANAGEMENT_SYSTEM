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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



        public static string updateColumn = "";


        private void pickBtn_Click(object sender, EventArgs e)
        {
            updateMenu.Show(pickBtn, 1, pickBtn.Height);
        }

        private void updateMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            updateColumn = e.ClickedItem.Text;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(updateColumn)

            if (id_input.Text != "" && generic_input.Text == "" && brand_input.Text == "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput.Text + "' WHERE med_id = " + id_input.Text + " ;";
                command(query);

            }
            else if (id_input.Text == "" && generic_input.Text != "" && brand_input.Text == "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput.Text + "' WHERE generic_name =   '" + generic_input.Text + "' ;";
                command(query);

            }
            else if (id_input.Text == "" && generic_input.Text == "" && brand_input.Text != "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput.Text + "' WHERE branded_name = '" + brand_input.Text + "' ;";
                command(query);

            }





            else if (id_input.Text != "" && generic_input.Text != "" && brand_input.Text == "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput + "' WHERE branded_name = " + id_input.Text + "  AND generic_name = '" + generic_input.Text + "'  ;";
                command(query);

            }
            else if (id_input.Text == "" && generic_input.Text != "" && brand_input.Text != "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput + "' WHERE generic_name = '" + generic_input.Text + "  AND branded_name = '" + brand_input.Text + "'  ;";
                command(query);

            }
            else if (id_input.Text != "" && generic_input.Text == "" && brand_input.Text != "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput + "' WHERE med_id = " + id_input.Text + "  AND branded_name = '" + brand_input.Text + "'  ;";
                command(query);
            }



            else if (id_input.Text != "" && generic_input.Text != "" && brand_input.Text != "")
            {
                string query = "UPDATE medicine SET " + updateColumn + " = '" + updaterInput + "' WHERE med_id = " + id_input.Text + " AND generic_name  = '" + generic_input.Text + "'  AND branded_name = '" + brand_input.Text + "'  ;";
                command(query);
            }


            else if (id_input.Text == "" && generic_input.Text == "" && brand_input.Text == "") 
            {
                MessageBox.Show("Please put a value first","ERROR"); 
            }

        }

        private void command(string query )
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);   
                cmd.ExecuteNonQuery();

                MessageBox.Show("SUCCESSFULLY UPDATED");
                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }
    }
}
