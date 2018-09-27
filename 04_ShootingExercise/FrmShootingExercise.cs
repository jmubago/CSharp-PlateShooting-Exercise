using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ShootingExercise
{
    public partial class FrmShootingExercise : Form
    {
        public FrmShootingExercise()
        {
            InitializeComponent();
        }


        //A man runs a shooting gallery.He charges 25 cents for 3 shots at some clay plates which
        //break when hit. If a person breaks 3 plates with his 3 shots he wins a prize which costs the man 1 dollar.
        //Each broken plate costs the man 4 cents to replace.The probability that a person hits a
        //plate on a single shot is ½. Write a program to simulate 1000 people playing the game and
        //determine the average amount of money the man makes/loses per player.

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double money = -0.12; //initialize with the cost of first 3 plates
            double platesCost = 0.04;


            for (int x = 1; x <= 1000; x++)
            {
                money += 0.25; //New game of 3 rounds pays 25 cents
                int countHits = 0; //Count each time a hit is made
                for (int i=1; i <= 3; i++)
                {
                    int shoot = r.Next(1, 3);
                    if (shoot == 1)
                    {
                        //Hits the target
                        money -= platesCost;
                        countHits += 1;
                    }
                    if(countHits == 3)
                    {
                        //If 3 hits per game, player gets one dollar
                        money -= 1;
                    }
                }
            }
            
            TxtResult.Text="Shooting gallery has: " + Math.Floor(money).ToString() + " dollars after 1000 games";
        }
    }
}
