using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICES_DB
{
    public partial class Form1 : Form
    {
        // Create the collection of 5 dices - the dices are modelled by Button objects
        List<Button> dices = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            

            dices.Add(but_k1);
            dices.Add(but_k2);
            dices.Add(but_k3);
            dices.Add(but_k4);
            dices.Add(but_k5);

            //set default Text on dices
            foreach (Button dice in dices)
            {
                dice.Text = "0";
            }

            label1.Text = "Gracz 1";
            label2.Text = "Gracz 2";

            textBox1.Text = "Wprowadz imie gracza 1";
            textBox2.Text = "Wprowadz imie gracza 2";

            
            MessageBox.Show("Wprowadz imiona graczy do Textbox1 i TextBox2");

            
        }

        enum GAME_STATE { NOT_STARTED, IN_PROGRESS, FINISHED}

        GAME_STATE state = GAME_STATE.NOT_STARTED;

        Player player1 = new Player();
        Player player2 = new Player();

        private void but_new_game_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;

            textBox1.Clear(); textBox2.Clear();            
            
            state = GAME_STATE.IN_PROGRESS;

            Form players_names = new Form();
            players_names.Show();

            TextBox txtbx_player1_name = new TextBox();
            txtbx_player1_name.Parent = players_names;
            txtbx_player1_name.Left = 25;
            txtbx_player1_name.Top = 25;

            Label label_player1 = new Label();
            label_player1.Parent = players_names;
            label_player1.Left = 25;
            label_player1.Top = 10;
            label_player1.Text = "Player1 name:";

            TextBox txtbx_player2_name = new TextBox();
            txtbx_player2_name.Parent = players_names;
            txtbx_player2_name.Left = 25;
            txtbx_player2_name.Top = 75;

            Label label_player2 = new Label();
            label_player2.Parent = players_names;
            label_player2.Top = 60;
            label_player2.Left = 25;
            label_player2.Text = "Player2 name:";

            player1.name = txtbx_player1_name.Text;
            player2.name = txtbx_player2_name.Text;

            Button btn_close = new Button();
            btn_close.Parent = players_names;
            btn_close.Text = "Apply and close window.";
            btn_close.Top = 110;
            btn_close.Left = 25;
            btn_close.Height = 50;
            btn_close.Width = 150;

            //btn_close.Click() += players_names.Close();


        }

        
        private void but_rzut_Click(object sender, EventArgs e)
        {
            Dice kosc = new Dice();
            Random rand = new Random();

            foreach (Button b in dices)
            {
                b.Text = rand.Next(1, 7).ToString();
            }
        }

        //button_testowy
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("player1 name is " + player1.name + "\r\n" +
                                "player2 name is " + player2.name);

        }

       

        
        

        

        
    }
}
