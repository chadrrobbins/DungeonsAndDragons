using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace DungeonsAndDragons_0623_2014
{
    class Database_Connection
    {
        OleDbConnection conn = new OleDbConnection();        

        public void OpenConnection()
        {
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\users\\Users\\Documents\\"
                + "DungeonsAndDragons_0624_2014.accdb; Persist Security Info=False";
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}
