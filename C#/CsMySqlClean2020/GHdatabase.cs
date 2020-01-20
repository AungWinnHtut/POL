using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp5
{
    class GHdatabase
    {
        String strCon;
        String strServer;
        String strDbName;
        String strDbUname;
        String strDbPassword;
        String strPort;
        DataSet ds;
        String strErr;

        public GHdatabase(String server, String dbname, String dbuname, String dbpassword, String port = "3306")
        {
            strServer = server;
            strDbName = dbname;
            strDbUname = dbuname;
            strDbPassword = dbpassword;
            strPort = port;

            strCon = "datasource='" + strServer + "';port='" + strPort + "';username='" + strDbUname + "';password='" + strDbPassword + "'";
        }

        public DataTable  funSELECT(String query,String tbname)
        {
            DataSet lds = new DataSet();
            try
            {
                MySqlConnection con = new MySqlConnection(strCon );
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                con.Open();                
                adapter.Fill(lds, tbname);
                con.Close();
                return lds.Tables[0]; //ds.Tables["user_tb"];                 
            }
            catch (Exception ex)
            {
                //Send Error Message here
                strErr = ex.ToString();
                return null;
            }            
        }


    }
}
