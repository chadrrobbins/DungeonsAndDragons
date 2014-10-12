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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Lines 27-33:Fill cb_Race
            DatabaseMethods dbMethods = new DatabaseMethods();
            
            dbMethods.FillComboBox("Race", "Race", cb_Race);
            dbMethods.FillComboBox("Class", "Class", cb_Class);

            rbAuto.Checked = true;            
            gbASmanual.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string startingLevel = null;
            string strRace = null;
            string strClass = null;            

            startingLevel = Convert.ToString(tbStartingLevel.Text);
            strRace = cb_Race.SelectedItem.ToString();
            strClass = cb_Class.SelectedItem.ToString();

            tbLevel.Text = startingLevel.ToString();
            tbRace.Text = strRace.ToString();
            tbClass.Text = strClass.ToString();            
        }

        private void btnASroll_Click(object sender, EventArgs e)
        {               
            DiceMethods DiceMethods = new DiceMethods();
            int[] AbilityScores = { };

            AbilityScores = DiceMethods.PrintDiceList(lbDiceAuto);

            cbASchaAuto.DataSource = AbilityScores;
            cbASconAuto.DataSource = AbilityScores;
            cbASdexAuto.DataSource = AbilityScores;
            cbASintAuto.DataSource = AbilityScores;
            cbASstrAuto.DataSource = AbilityScores;
            cbASwisAuto.DataSource = AbilityScores;
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked == true)
            {                
                gbASmanual.Visible = false;
                gbASauto.Visible = true;
            }
            else if (rbAuto.Checked == false)
            {                
                gbASmanual.Visible = true;
                gbASauto.Visible = false;
            }
        }

        private void cbASstrAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }                  
    }
}
