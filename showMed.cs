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
using DatabaseConnection;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Security.RightsManagement;


namespace PHARMACY_SYSTEM
{
    public partial class showMed : Form
    {
        public static int count = 1;
        public static int labelSize = count * 3 ;
        public static int[] heightArray = { 5, 20, 35, 50, 65, 80, 95, 110, 125, 140, 155, 170 };
        public Label[] labelArray = new Label[3];
        public static showMed instance;
        public int Pquantity;
        public string Pname;
        public double Pprice;
        public int TotalQuantity = 0;
        public double TotalPrice = 0;

        public int acc_id;
        public int shift_id;

        public showMed()
        {
            InitializeComponent();
            instance = this;
            acc_id = getAcc_id();
            shift_id = getshift_id();

        }

        private void showMed_Load(object sender, EventArgs e)
        {
            timer1.Start();
            count = 1;
            Random rand = new Random();
            idRandLabel.Text = Convert.ToString(rand.Next(1001,4953));
            refRLabel.Text = Convert.ToString(rand.Next(1001, 4953));
            appRandLabel.Text = Convert.ToString(rand.Next(1001, 4953));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }


        // FOR SEARCHING MEDICINE 
        private void searchMed(string cmd)
        {
            dbConnection.connectionFunc();
            dbConnection.conn.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter() ;
            mda.SelectCommand = new MySqlCommand(cmd,dbConnection.conn);

            DataTable dta = new DataTable();
            mda.Fill(dta);


            BindingSource bda = new BindingSource();
            bda.DataSource = dta;

            medData.DataSource = dta;

            dbConnection.conn.Close();
        }
        private void searchAll()
        {
          if (gen_name.Text == "" && brand_name.Text == "" && desc_input.Text == "")
            {
                string query = "SELECT * FROM medicine ;";
                searchMed(query);
            }
        }
        private void searchByinput()
        {

            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string tempGen = gen_name.Text;
                string tempBrand = brand_name.Text;

                if (gen_name.Text == "" && brand_name.Text != "" && desc_input.Text == "")
                {
                    string query = "SELECT * FROM medicine where branded_name = '" + tempBrand + "' ; ";
                    searchMed(query);
                }
                else if (gen_name.Text != "" && brand_name.Text == "" && desc_input.Text == "")
                {
                    string query = "SELECT * FROM medicine where generic_name = '" + tempGen + "'; ";
                    searchMed(query);
                }
                else if (gen_name.Text == "" && brand_name.Text == "" && desc_input.Text != "")
                {
                    string query = "SELECT * FROM medicine where description LIKE '%" + desc_input.Text + "%' ";
                    searchMed(query);
                }


                else if (gen_name.Text != "" && brand_name.Text != "" && desc_input.Text == "")
                {
                    string query = "SELECT * FROM medicine where generic_name = '" + gen_name.Text + "' AND branded_name = '" + brand_name.Text + "'   ";
                    searchMed(query);
                }
                else if (gen_name.Text == "" && brand_name.Text != "" && desc_input.Text != "")
                {
                    string query = "SELECT * FROM medicine where branded_name = '" + brand_name.Text + "' AND description LIKE '%" + desc_input.Text + "%' ";
                    searchMed(query);
                }
                else if (gen_name.Text != "" && brand_name.Text == "" && desc_input.Text != "")
                {
                    string query = "SELECT * FROM medicine where generic_name = '" + gen_name.Text + "' AND description LIKE '%" + desc_input.Text + "%' ";
                    searchMed(query);
                }

                dbConnection.conn.Close();






            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message.ToString());
            }

         
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {

            if(gen_name.Text == "" && brand_name.Text == "" && desc_input.Text == "")
            {
                MessageBox.Show("Please fill at least one of the inputs","Error has occured");
            } else
            {
                searchByinput();
            }
        }
        private void all_Click(object sender, EventArgs e)
        {
            searchAll();
        }
        

        // FOR GENERATING THE LABELS IN THE RECIEPT
        private void GenerateLabel(object Label, int width, int height , string name )
        {
            Label l = Label as Label;
            this.recPanel.Controls.Add(l);
            l.AutoSize = true;
            l.Location = new System.Drawing.Point(width, height);
            l.Size = new System.Drawing.Size(20, 20);
            l.Text = name;
        }
        private void CallGenerate(int quantity, string name, double price)
        {
            for (int i = 0; i < labelArray.Length; i++)
            {
                labelArray[i] = new Label();
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        GenerateLabel(labelArray[i], 5, heightArray[count - 1], Convert.ToString(quantity));
                    }
                    else if (i == 1)
                    {
                        GenerateLabel(labelArray[i], 50, heightArray[count - 1] , name);
                    }
                    else if (i == 2)
                    {
                        GenerateLabel(labelArray[i], 175, heightArray[count - 1], Convert.ToString(price));
                    }

                }
                catch (IndexOutOfRangeException err)
                {
                    MessageBox.Show(err.Message.ToString());
                }
            }
        }
        private void removeLabels()
        {
            foreach(System.Windows.Forms.Control control in this.recPanel.Controls)
            {
                if (control.GetType().Equals(typeof(Label)))
                {
                    recPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

        }




        // FOR GETTING THE NECCESSARY VALUES IN THE DATABASE
        private int getAcc_id()
        {
            int acc_id = 0;
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT acc_id FROM account where acc_email = '" + login.instance.usernameTxt.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    acc_id = reader.GetInt32("acc_id");
                    return acc_id;
                }


                dbConnection.conn.Close();
            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }


            return 0;
        }
        private int getshift_id()
        {
            int shift_id = 0;
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT MAX(shift_id) as shift_id FROM shift_tracker WHERE acc_id = " + acc_id + "  ";
                MySqlCommand cmd = new MySqlCommand(query,dbConnection.conn);
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
        private int getQuantity(int id)
        {

            int quantity = 0;

            dbConnection.connectionFunc();
            dbConnection.conn.Open();

            string query = "SELECT quantity FROM medicine where med_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                quantity = reader.GetInt32("quantity");
            }

            dbConnection.conn.Close(); 

            return quantity; 

        }
        private double getPrice(int med_id)
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

               double price; 

                string query = "SELECT price FROM medicine WHERE med_id = " + med_id + " ";
                MySqlCommand cmd = new MySqlCommand(@query, dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    price = reader.GetDouble("price");
                    return price;
                }

                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return 0;
        }
        private string getName(int med_id)
        {
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string name;

                string query = "SELECT generic_name FROM medicine WHERE med_id = " + med_id + " ";
                MySqlCommand cmd = new MySqlCommand(@query, dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name = reader.GetString("generic_name");
                    return name;
                }

                dbConnection.conn.Close();

            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            return "";
        }
        private int getPurchase_id()
        {
            int purchase_id;
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "SELECT max(purchase_id) as purchase_id FROM sales ; ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    purchase_id = reader.GetInt32("purchase_id");
                    return purchase_id; 
                }




                dbConnection.conn.Close();
            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString() );
            }



            return 0;
        }








        // FOR CONTROL STRUCTURES
        private bool checkIfValid(string  temp )
        {


            for(int i = 0; i < temp.Length; i++ )
            {
                if (!Char.IsDigit(temp[i]))
                {
                    return false;
                } 
            }
            return true;
        }
        private int medicineCounter()
        {

            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();
                int count;
                string query = "SELECT COUNT(med_id) as med_id FROM medicine ;";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader() ;

                while(reader.Read())
                {
                    count = reader.GetInt32("med_id");
                    return count;
                }

                dbConnection.conn.Close();
            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }


            return 0; 
        }
        private void refreshRecieptBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < labelSize; i++ )
            {
                removeLabels();
            }
            removeLabels();


            count = 1;
            TotalPrice = 0;
            TotalQuantity = 0;
            TotalItemLabel.Text = "0";
            TotalPriceLabel.Text = "0";
        }



        // INSERTING sales table and shift_sales table
        private void insertsales(int med_id)
        {
            int inputedQuantity = Convert.ToInt32(this.quantity_input.Text);
            int quantity = getQuantity(med_id);
            double price = getPrice(med_id);
            string name = getName(med_id);
            int acc_id = getAcc_id();
            double totalAmount;

            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();
                totalAmount = price * inputedQuantity;


                string query = "INSERT INTO sales(med_id ,acc_id, med_name , quantity_sold , price,total_amount ) values (@med_id,@acc_id, @med_name, @quantity_sold, @price,@total_amount);";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                cmd.Parameters.AddWithValue("@med_id"  , med_id);
                cmd.Parameters.AddWithValue("@acc_id", acc_id);
                cmd.Parameters.AddWithValue("@med_name", name);
                cmd.Parameters.AddWithValue("@quantity_sold", inputedQuantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                cmd.Prepare();

                cmd.ExecuteNonQuery();



                dbConnection.conn.Close();

            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }
        private void insertShiftSales()
        {
            int shift_id = getshift_id();
            int purchase_id = getPurchase_id();
            try
            {
                dbConnection.connectionFunc();
                dbConnection.conn.Open();

                string query = "INSERT INTO shift_sales VALUES( @purchase_id,@shift_id) ;  ";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.conn);
                cmd.Parameters.AddWithValue("@purchase_id", purchase_id);
                cmd.Parameters.AddWithValue("@shift_id", shift_id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();  


                dbConnection.conn.Close();
            }catch(MySqlException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            

        }
        private void sellBtn_Click(object sender, EventArgs e)
        {
           

            if(!string.IsNullOrEmpty(med_idInput.Text) && !string.IsNullOrEmpty(quantity_input.Text) && checkIfValid(med_idInput.Text) && checkIfValid(quantity_input.Text) )
            {

                try
                {
                    int med_id = Convert.ToInt32( this.med_idInput.Text);
                    if(med_id <= medicineCounter())
                    {
                        int  inputedQuantity = Convert.ToInt32(this.quantity_input.Text);
                        int quantity = getQuantity(med_id);
                        int updateQuantity = quantity - inputedQuantity;
                        double price = getPrice(med_id);
                        string name = getName(med_id);
                            
                        if(inputedQuantity <= quantity)
                        {
                            insertsales(med_id);
                            insertShiftSales();

                            dbConnection.connectionFunc();
                            dbConnection.conn.Open();


                            string updtQuantityquery = "UPDATE medicine SET quantity = @quantity WHERE med_id = @med_id  ; ";
                            MySqlCommand cmd = new MySqlCommand(updtQuantityquery, dbConnection.conn);
                            cmd.Parameters.AddWithValue("@quantity", updateQuantity);
                            cmd.Parameters.AddWithValue("@med_id", med_id);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();

                            int inputQuantity = Convert.ToInt32(quantity_input.Text);
                            Pquantity = inputQuantity;
                            Pname = name;
                            Pprice = price;
                            


                            TotalQuantity = TotalQuantity + inputQuantity;
                            TotalPrice = TotalPrice + price;
                       
                            CallGenerate(Pquantity, Pname, Pprice);
                            count += 1;

                            MessageBox.Show("Medicine Added");
                            searchMed("SELECT * FROM medicine");


                            dbConnection.conn.Close();

                        }    else
                        {
                            MessageBox.Show("The quantity input can't accomodate the stocks", "Error");
                        }
                        
                    } else
                    {
                        MessageBox.Show("Make sure that the medicine id is correct","ERROR");
                    }
                        
                }catch(MySqlException err)
                {
                    MessageBox.Show(err.Message.ToString());
                }

            } else
            {
                MessageBox.Show("Fill all in the inputs and make sure your inputs are valid");
            }



            
        }
        private void transactionBtn_Click(object sender, EventArgs e)
        {
            TotalItemLabel.Text = Convert.ToString(TotalQuantity);
            TotalPriceLabel.Text = Convert.ToString(TotalPrice);
        }








    }
}
