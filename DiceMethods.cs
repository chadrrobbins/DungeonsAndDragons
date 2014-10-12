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

        public int[] PrintDiceList(ListBox InputListBox)
        {
            InputListBox.Items.Clear();

            List<int[]> ListIntArray = new List<int[]>();
            int[] ListLine;
            int ListResult;
            int[] AbilityScores = {0,0,0,0,0,0};

            ListIntArray = GetRollsList();

            for (int i = 0; i < ListIntArray.Count; i++)
            {
                ListLine = ListIntArray[i];
                Array.Sort(ListLine);
                ListResult = (ListLine[1] + ListLine[2] + ListLine[3]);
                InputListBox.Items.Add("Roll " + (i + 1) + ":");
                InputListBox.Items.Add(ListLine[0] +  " + " + ListLine[1] + " + " + ListLine[2] + " + " + ListLine[3] + " = " + ListResult);
                InputListBox.Items.Add("");
                AbilityScores[i] = (ListResult); 
            }

            return AbilityScores;
        }

        public List<int> GetAbilityScores()
        {
            List<int> DiceList = new List<int>();

            return DiceList;
        }
    }
}
