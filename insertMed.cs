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
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using DatabaseConnection; 

namespace PHARMACY_SYSTEM
{
    public partial class insertMed : Form
    {
        public insertMed()
        {
            InitializeComponent();
        }


        public static insertMed instance; 

        private void dataBind()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT * FROM medicine ; ";
            MySqlDataAdapter mda = new MySqlDataAdapter();
            mda.SelectCommand = new MySqlCommand(query, dbConnection.conn);

            DataTable dt = new DataTable();
            mda.Fill(dt);

            BindingSource bd = new BindingSource();
            bd.DataSource = dt;

            viewMed.DataSource = dt;

            dbConnection.conn.Close();
        }
        private void insertMed_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataBind();
            loadForm(new update());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }
        private void alterTable()
        {

            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                try
                {

                    string alter = "ALTER TABLE medicine AUTO_INCREMENT = 1";
                    MySqlCommand newCmd = new MySqlCommand(alter, dbConnection.conn);
                    newCmd.ExecuteNonQuery();

                }catch (MySqlException err)
                {
                    MessageBox.Show(err.Message);
                }


                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }
        private bool checkTextbox()
        {
            instance = this;

            TextBox txt = new TextBox();

            foreach (Control ctrl in instance.Controls)
            {
                if (ctrl.GetType().Equals(typeof(TextBox)))
                {
                    txt = (TextBox)ctrl;
                    if (txt.Text == "")
                    {
                        return false; 
                    }
                }
            }
            return true;
        }

        public void loadForm(object Form)
        {
            if (this.updatePanel.Controls.Count > 0)
            {
                this.updatePanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.updatePanel.Controls.Add(f);
            this.updatePanel.Tag = f;
            f.Show();
        }


        private bool checkIfMedUnique()
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT * from medicine WHERE generic_name = '"+gen_Input.Text+"' OR branded_name = '"+brand_Input.Text+"';  ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);


                if(cmd.ExecuteScalar() != null )
                {
                    return false;
                }




                dbConnection.conn.Close();
            }
            catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }



            return true;
        }


        // FOR THE MEDICINE 
        public static string medtypeName = ""; 
        private void insertMedicine()
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            try
            {

                string query = "INSERT INTO medicine values(@id,@medtypeName ,@gen_name,@brand_name,@description,@price,@quantity,@expire,@arrived) ; ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);

                cmd.Parameters.AddWithValue("@id", this.medID_input.Text);
                cmd.Parameters.AddWithValue("@medtypeName", medtypeName);
                cmd.Parameters.AddWithValue("@gen_name", this.gen_Input.Text);
                cmd.Parameters.AddWithValue("@brand_name", this.brand_Input.Text);
                cmd.Parameters.AddWithValue("@description", this.descriptionInput.Text);

                cmd.Parameters.AddWithValue("@price", this.price_Input.Text);
                cmd.Parameters.AddWithValue("@quantity",quantity_input.Text);

                cmd.Parameters.AddWithValue("@expire", this.expiry_input.Value);
                cmd.Parameters.AddWithValue("@arrived", this.arrived_input.Value);

                
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine Successfully added");


            } catch(MySqlException err)
            {
                MessageBox.Show(err.Message);
            }


            dbConnection.conn.Close();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            if(medID_input.Text == "" && gen_Input.Text == "" && brand_Input.Text == "" && descriptionInput.Text == "" && price_Input.Text == "" && quantity_input.Text == "" )
            {
                MessageBox.Show("Please input the information of the medicine","Error has occured");
            } else
            {

                if (checkIfMedUnique())
                {
                   insertMedicine();
                   dataBind();

                }else
                {
                    MessageBox.Show("The medicine is already in the inventory", "Error occured");
                }

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string temp = medID_input.Text;

            try
            {
                if (medID_input.Text == "")
                {
                    MessageBox.Show("Please input the medicine id first", "Error has occured");
                }
                else
                {
                    dbConnection.connectionFunc();
                    dbConnection.conn.Open();

                    string query = "DELETE FROM medicine where med_id = '" + medID_input.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    dbConnection.conn.Close();


                    alterTable();
                    dataBind();
                    MessageBox.Show("Successfully Deleted");

                }
            }
            catch(MySqlException err)
            {
                MessageBox.Show(err.Message);
            }

            
        }

        private void medtypeBtn_Click(object sender, EventArgs e)
        {
            typemenu.Show(medtypeBtn, 1 ,medtypeBtn.Height);
        }

        private void typemenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            medtypeName = e.ClickedItem.ToString();
            medtypeBtn.Text = medtypeName;
        }

        private void databind(string cmd)
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            MySqlDataAdapter mda = new MySqlDataAdapter();
            mda.SelectCommand = new MySqlCommand(cmd, dbConnection.conn);

            DataTable dta = new DataTable() ;
            mda.Fill(dta);

            BindingSource bda = new BindingSource();
            bda.DataSource = dta ;

            viewMed.DataSource = dta;

            dbConnection.conn.Close();
        }

        private void showmedicine_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM medicine;";
            databind(cmd);
        }




        // FOR THE MEDICINE TYPE 
        private bool checkInput(string text)
        {


            for(int i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(text[i]) )
                {
                    return false;
                }
            }


            return true;
        }

        private void addType_Click(object sender, EventArgs e)
        {


            try {  
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                if(!string.IsNullOrEmpty(medtype_input.Text))
                {
                    string query = "INSERT INTO medicine_type(medtype_name) values(@type);";
                    MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);

                    cmd.Parameters.AddWithValue("@type", this.medtype_input.Text);
                    cmd.Prepare(); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Type Added","Operation Successful");
                    databind("SELECT * FROM medicine_type order by(medtype_id) ASC");

                } else
                {
                    MessageBox.Show("Put a medicine type first","ERROR");
                }

                dbConnection.conn.Close();
            
            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

        private void updateType_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                if(!string.IsNullOrEmpty(updateTypeInput.Text) && !string.IsNullOrEmpty(updateNameInput.Text) && checkInput(updateTypeInput.Text)  && !checkInput(updateNameInput.Text))
                {


                    string query = "UDPATE medicine_type SET medtype_name = @name WHERE medtype_id = @id ;";
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                    cmd.Parameters.AddWithValue("@name", this.updateNameInput.Text);
                    cmd.Parameters.AddWithValue("@id",this.updateTypeInput.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated","Success");


                } else
                {
                    MessageBox.Show("Please put the right inputs and put the right values ", "ERROR");
                }



                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString() );
            }
        }

        private void deleteType_Click(object sender, EventArgs e)
        {

            try
            {

                dbConnection.connectionFunc();
                dbConnection.conn.Open();


                if(!string.IsNullOrEmpty(deleteTypeID.Text))
                {
                    string query = "DELETE FROM medicine_type where medtype_id = @id ; ";
                    MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);
                    cmd.Parameters.AddWithValue("@id",this.deleteTypeID.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    string alterTable = "ALTERT TABLE medicine_type AUTO_INCREMENT = 1 ;";
                    MySqlCommand altercmd = new MySqlCommand(alterTable,dbConnection.conn);
                    altercmd.ExecuteNonQuery();

                } else
                {
                    MessageBox.Show("Please put a medicine type ID first","ERROR");
                }


                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }
        
        private void viewTypeBtn_Click(object sender, EventArgs e)
        {
            databind("SELECT * FROM medicine_type order by(medtype_id) ASC");
        }





    }
}
