using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES_DB
{
    class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();

        public void Match()
        {

        }

        public void infoGame()
        {
            System.Windows.Forms.MessageBox.Show("Player 1 name is: " + player1.name + Environment.NewLine
                                                  + "Player 2 name is: " + player2.name);
        }
    }
}
