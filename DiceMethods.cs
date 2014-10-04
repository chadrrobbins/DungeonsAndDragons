using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons_0623_2014
{
    class DiceMethods
    {
        public int[] GetDiceArray()
        {
            Random rand = new Random();

            int[] randArray = { rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7) };            

            return randArray;
        }
    }
}
