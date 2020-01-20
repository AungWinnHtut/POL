using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;


//Show data from database to DataGridView 
// 1-Connection String
        // 2-MySqlConnection
        // 3-MySqlDataAdapter
        // 4-Con open
        // 5-DataSet
        // 6-adapter,table -> Dataset
        // 7-Dataset,table[index] -> dataGridView,DataSource
        private void btnConnect_Click(object sender, EventArgs e)
        {          
            
          try 
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from student.user_tb", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "user_tb");
                dataGridView1.DataSource = ds.Tables[0]; //ds.Tables["user_tb"]; 
                con.Close();             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



      //To clear Datagridview, set Datasource to ""
        private void btnClose_Click(object sender, EventArgs e)
        {              
            dataGridView1.DataSource = "";
        }
        


// Test whether data exists!
        // 1-Connection String
        // 2-MySqlConnection
        // 3-Query String
        // 4-MySqlCommand
        // 5-MySqlDataReader -> ExecuteReader
        // 6-Getting each row of data by while loop and reader.Read ()
        // 7-Getting desired colunm by reader.GetString("uname") or reader.GetInt("id"), etc
        private void btnRead_Click(object sender, EventArgs e)
        {
            string sUname = txtUname.Text.ToString();
            string sPass = txtPass.Text.ToString();
            string sU = "";
            string sP = "";
            Boolean status = false; //no ok

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
            con.Open();
            string query = "SELECT * from student.user_tb";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();  //id uname password

            while(reader.Read ())
            {
                sU = reader.GetString("uname").ToString();
                sP = reader.GetString("password").ToString();

                //Checking user name and password
                if(sU == sUname && sP == sPass )
                {
                    status = true;  //found password
                    //break;        //to immediate exit from testing
                }

                //How to add combo box element
                cboUname.Items.Add(sU);
                cboPass .Items.Add(sP);                
            }
            con.Close();

            //Default selection of combobox item
            cboUname.SelectedIndex = 0;
            cboPass.SelectedIndex = 0;

            //check status whether login success or not
            if (status)
            {
                MessageBox.Show ("User Login Successfully!");
                status = false;
            }
            else
            {
                MessageBox.Show("Try Again!");
            }

        }



//Update with variable parameters
        // 1-Connection String
        // 2-MySqlConnection
        // 3-Connection Open
        // 4-Query String with variable parameters @uname
        // 5-MySqlCommand
        // 6-Query -> CommandText
        // 7-Parameters.AddWithValue("@uname", user)
        // 8-Connection
        // 9-ExecuteNonQuery
        // 10-Connection Close
        public void funUpdatePassword(String user,String pass)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();             
                   
                string query = "UPDATE student.user_tb SET password=@password WHERE uname =@uname";               
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@uname", user);
                cmd.Parameters.AddWithValue("@password", pass);                                  
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success!");       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
