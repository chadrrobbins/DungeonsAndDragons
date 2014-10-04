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
    class ArrayMethods
    {
        public void PrintIntArray(int[] InputArray, ListBox InputListBox)
        {
            for (int count = 0; count < InputArray.Length; count++)
            {
                InputListBox.Items.Add(InputArray[count]);
            }
        }

        public void PrintDiceResults(int[] InputArray, int InputCount, ListBox InputListBox)
        {
            int total = 0; 
            Array.Sort(InputArray);
            total = (InputArray[1] + InputArray[2] + InputArray[3]);
            InputListBox.Items.Add("Roll " + (InputCount + 1) + " :");
            InputListBox.Items.Add(InputArray[0] + " ," + InputArray[1] + " ," + InputArray[2] + " ," + InputArray[3] + " = " + total);
            InputListBox.Items.Add("");
        }

        public int[] GetAbilityScores(ListBox InputListBox)
        {
            InputListBox.Items.Clear();
            int[] AbilityScores = {0,0,0,0,0,0};
            int total = 0;
            Random rand = new Random();

            for (int count = 0; count < 6; count++)
            {
                //Random rand = new Random();
                int[] DiceArray = { rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7) };
                PrintDiceResults(DiceArray, count, InputListBox);
                total = (DiceArray[1] + DiceArray[2] + DiceArray[3]);
                AbilityScores[count] = total;
            }

            return AbilityScores;
        }        
    }
}
