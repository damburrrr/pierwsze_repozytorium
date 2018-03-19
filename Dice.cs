using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICES_DB
{
    class Dice:Button
    {
        public int value { get; set; }
        private int test =999;
        
        public int Roll()
        {
            Random rand = new Random();
            value = rand.Next(1, 6);

            return value;
        }

    }
}
