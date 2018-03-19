using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES_DB
{
    class Player
    {
        public String name;
        private int score_value;

        public int score
        {
            set
            {
                score_value = value;
            }

            get
            {
                return score_value;
            }
        }

    }
}
