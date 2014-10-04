using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDragons_0623_2014
{
    class FillMethods
    {
        public void cbAutoFill(int[] inputArray, ComboBox inputComboBox)
        {
            inputComboBox.Items.Clear();

            for (int count = 0; count < 6; count++)
            {
                inputComboBox.Items.Add(inputArray[count]);
            }
        }

        public void cbAutoFillAbilityScores(int[] inputArray, ComboBox inputCBstr, ComboBox inputCBcon, ComboBox inputCBdex, ComboBox inputCBint, 
            ComboBox inputCBwis, ComboBox inputCBcha)
        {
            cbAutoFill(inputArray, inputCBcha);
            cbAutoFill(inputArray, inputCBcon);
            cbAutoFill(inputArray, inputCBdex);
            cbAutoFill(inputArray, inputCBint);
            cbAutoFill(inputArray, inputCBwis);
            cbAutoFill(inputArray, inputCBstr);            
        }
    }
}
