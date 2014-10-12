using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;


namespace DungeonsAndDragons_0623_2014
{
    class DatabaseMethods
    {        
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Duders\\Documents\\DungeonsAndDragons_0624_2014.accdb; Persist Security Info=False");

        public void OpenConnection()
        {
            try
            {                            
                conn.Open();                
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        public void FillComboBox(string tblNameInput, string colNameInput, ComboBox cbNameInput)
        {         
            DatabaseMethods dbMethods = new DatabaseMethods();
            dbMethods.OpenConnection();    
            OleDbCommand cm = new OleDbCommand("SELECT " + tblNameInput + " FROM " + colNameInput + " ORDER BY " + colNameInput + " ASC", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbNameInput.Items.Add(dr[colNameInput]);
            }

            conn.Close();
        }
    }
}
