using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Caliburn.Micro;
using ProjectX.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectX.ViewModels
{

    public class MainGameViewModel : Screen
    {
        public GameSetEngine GameSetEngine;
     
        public GameSetEngine GameSet { get; private set; }
        public Dice dice { get; private set; }
        public Dice dice1 { get; private set; }
        public Dice dice2 { get; private set; }
        public Dice dice3 { get; private set; }
        public Dice dice4 { get; private set; }
        public Player player1 { get; private set; }
        public Player player2 { get; private set; }
        public Player player3 { get; private set; }
        public Player player4 { get; private set; }
        public DicePanel Dicepanel { get; private set; }

         Random r = new Random();

        public MainGameViewModel()
        {
            // create a new GameSet objekt
            GameSet = new GameSetEngine();

            // creating players
            player1 = new Player();
            player1.Name = "Cecelia";
            player2 = new Player();
            player2.Name = "Ulrich";
            player3 = new Player();
            player4 = new Player();

            // Adding players to the Gamest
            GameSet.Players.Add(player1);
            GameSet.Players.Add(player2);
            GameSet.Players.Add(player3);
            GameSet.Players.Add(player4);
            
            // Create the dices.
            dice = new Dice();
            dice1 = new Dice();
            dice2 = new Dice();
            dice3 = new Dice();
            dice4 = new Dice();
            
            // create the Dicepanel
            Dicepanel = new DicePanel();
        }

        public void Enable()
        {
        
            RollDices();

           
            GameSet.GameName = "Game Round 1";
            DateTime today = DateTime.Now;
            
            GameSet.Started_At = today;
            GameSet.Started_At.ToShortDateString();
            

        }

        private void RollDices()
        {
            if (dice.Keep == false)
            {
                dice.DiceValue = r.Next(1, 7);
                dice.Img = new BitmapImage(new Uri(@"\" + dice.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice1 = dice;
            }
            if (dice1.Keep == false)
            {
                dice1.DiceValue = r.Next(1, 7);
                dice1.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice2 = dice1;
            }
            if (dice2.Keep == false)
            {
                dice2.DiceValue = r.Next(1, 7);
                dice2.Img = new BitmapImage(new Uri(@"\" + dice2.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice3 = dice2;
            }
            if (dice3.Keep == false)
            {
                dice3.DiceValue = r.Next(1, 7);
                dice3.Img = new BitmapImage(new Uri(@"\" + dice3.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice4 = dice3;
            }
            if (dice4.Keep == false)
            {
                dice4.DiceValue = r.Next(1, 7);
                dice4.Img = new BitmapImage(new Uri(@"\" + dice4.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice5 = dice4;
            }
        }
            public void KeepDiceOne()
            {
            if (dice.Keep == false)
                dice.Keep = true;
            else
            {
                dice.Keep = false;
            }
       
            }
        public void KeepDiceTwo()
        {
            if (dice1.Keep == false)
                dice1.Keep = true;
            else
            {
                dice1.Keep = false;
            }

        }
        public void KeepDiceThree()
        {
            if (dice2.Keep == false)
                dice2.Keep = true;
            else
            {
                dice2.Keep = false;
            }

        }
        public void KeepDiceFour()
        {
            if (dice3.Keep == false)
                dice3.Keep = true;
            else
            {
                dice3.Keep = false;
            }

        }
        public void KeepDiceFive()
        {
            if (dice4.Keep == false)
                dice4.Keep = true;
            else
            {
                dice4.Keep = false;
            }

        }

    }
}
    



   


