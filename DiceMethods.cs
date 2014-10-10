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
    class DiceMethods
    {
        public int[] GetDiceArray(Random inputRandom)
        {
            int[] randArray = { inputRandom.Next(1, 7), inputRandom.Next(1, 7), inputRandom.Next(1, 7), inputRandom.Next(1, 7) };            

            return randArray;
        }

        public List<int[]> GetRollsList()
        {
            var ListIntArray = new List<int[]>();
            int[] IntArray;
            Random Random = new Random();

            for (int i = 0; i < 6; i++)
            {
                IntArray = GetDiceArray(Random);
                Array.Sort(IntArray);
                ListIntArray.Add(IntArray);
            }

            return ListIntArray;
        }

        public void PrintDiceList(ListBox InputListBox)
        {
            List<int[]> ListIntArray = new List<int[]>();

            ListIntArray = GetRollsList();

            for (int i = 0; i < ListIntArray.Count; i++)
            {
                for (int j = 0; i < ListIntArray.Count; j++)
                {
                    //InputListBox.Items.Add(ListIntArray[i, j]);
                }
            }

        }

        public void PrintDiceArray(ListBox InputListbox)
        {            
            int[] DiceArray;
            int Total = 0;
            Random Random = new Random();
            InputListbox.Items.Clear();            

            for (int count = 0; count < 6; count++)
            {                
                DiceArray = GetDiceArray(Random);
                Array.Sort(DiceArray);
                Total = (DiceArray[1] + DiceArray[2] + DiceArray[3]);
                InputListbox.Items.Add("Roll " + (count + 1) + " :");
                InputListbox.Items.Add(DiceArray[0] + " ," + DiceArray[1] + " ," + DiceArray[2] + " ," + DiceArray[3] + " =" + Total);
                InputListbox.Items.Add("");
            }
        }

        public List<int> GetAbilityScores()
        {
            List<int> DiceList = new List<int>();

            return DiceList;
        }
    }
}
