using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class DicePanel : Screen
    {
        Random Randomator = new Random();

        public Dice Dice1;
        public Dice Dice2;
        public Dice Dice3;
        public Dice Dice4;
        public Dice Dice5;

        public DicePanel()
        {

         Dice1 = new Dice();
         Dice2 = new Dice();
         Dice3 = new Dice();
         Dice4 = new Dice();
         Dice5 = new Dice();

        }

        //public void RollDice()
        //{
        //    if (!Dice1.Keep)
        //    {
        //        Dice1.DiceValue = Randomator.Next(1, 7);
        //    }
        //    if (!Dice2.Keep)
        //    {
        //        Dice2.DiceValue = Randomator.Next(1, 7);
        //    }
        //    if (!Dice3.Keep)
        //    {
        //        Dice3.DiceValue = Randomator.Next(1, 7);
        //    }
        //    if (!Dice4.Keep)
        //    {
        //        Dice4.DiceValue = Randomator.Next(1, 7);
        //    }
        //    if (!Dice5.Keep)
        //    {
        //        Dice5.DiceValue = Randomator.Next(1, 7);
        //    }
        //}
     }
 } 