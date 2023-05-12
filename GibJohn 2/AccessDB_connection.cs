using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace GibJohn_2
{
    class AccessDB_connection
    {

        public static OleDbConnection con = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", con);
        public static OleDbDataAdapter rd;

        public static string currentFullName;
        public static string sql;

        public static string getConnectionString()
        {
            
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Application.StartupPath + "\\GibJohn Database.accdb;";

            return connectionString;


        }

      



    }
}
