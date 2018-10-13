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

        public int[] dices = new int[5] { 0, 0, 0, 0, 0 };
        public int[] diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };

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
        public ScoreCardProp PropScoreCard { get; private set; }

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

            PropScoreCard = new ScoreCardProp();

            // create the Dicepanel
            Dicepanel = new DicePanel();
        }

        public void Enable()
        {
        
            RollDices();
            SaveDicesToEvaluationArray();
            EvaluateProposal();

           
            GameSet.GameName = "Game Round 1";
            DateTime today = DateTime.Now;
            
            GameSet.Started_At = today;
            GameSet.Started_At.ToShortDateString();
            

        }

        private void EvaluateProposal()
        {
            if (One(diceValues) > 0)
            {
                PropScoreCard.PropOnes = 0;
                PropScoreCard.PropOnes = One(diceValues);
            }
            if (Two(diceValues) > 0)
            {
                PropScoreCard.PropTwos = 0;
                PropScoreCard.PropTwos = Two(diceValues);
               
            }
            if (Three(diceValues) > 0)
            {
                PropScoreCard.PropThrees = 0;
                PropScoreCard.PropThrees = Three(diceValues);
            }
            if (Four(diceValues) > 0)
            {
                PropScoreCard.PropFours = 0;
                PropScoreCard.PropFours = Four(diceValues);
            }
            if (Five(diceValues) > 0)
            {
                PropScoreCard.PropFives = 0;
                PropScoreCard.PropFives = Five(diceValues);
            }
            if (Six(diceValues) > 0)
            {
                PropScoreCard.PropSixes = 0;
                PropScoreCard.PropSixes = Six(diceValues);
            }
            if (Pair(diceValues) > 0)
            {
                PropScoreCard.PropSixes = 0;
                PropScoreCard.PropPair = Pair(diceValues);
            }
            if (TwoPair(diceValues) > 0)
            {
                PropScoreCard.PropTwoPairs = 0;
                PropScoreCard.PropTwoPairs = TwoPair(diceValues);
            }
            if (ThreeOfKind(diceValues) > 0)
            {
                PropScoreCard.PropThreeOfAKind = 0;
                PropScoreCard.PropThreeOfAKind = ThreeOfKind(diceValues);
            }
            if (FourOfKind(diceValues) > 0)
            {
                PropScoreCard.PropFourOfAKind = 0;
                PropScoreCard.PropFourOfAKind = FourOfKind(diceValues);
            }
            if (SmallStraight(diceValues) > 0)
            {
                PropScoreCard.SmallStraightprop = 0;
                PropScoreCard.SmallStraightprop = SmallStraight(diceValues);
            }
            if (BigStraight(diceValues) > 0)
            {
                PropScoreCard.PropLargeStraight = 0;
                PropScoreCard.PropLargeStraight = BigStraight(diceValues);
            }
            if (FullHouse(diceValues) > 0)
            {
                PropScoreCard.PropFullHouse = 0;
                PropScoreCard.PropFullHouse = FullHouse(diceValues);
            }
            if (Chance(diceValues) > 0)
            {
                PropScoreCard.PropChance = 0;
                PropScoreCard.PropChance = Chance(diceValues);
            }
            if (Yatzee(diceValues) > 0)
            {
                PropScoreCard.PropYatzy = 0;
                PropScoreCard.PropYatzy = Yatzee(diceValues);
            }


        }
        public int One(int[] diceValue)

        {

            int result = 0;

            result += diceValue[0];

            return result;

        }
        public int Two(int[] diceValues)

        {

            int result = 0;

            result += diceValues[1] * 2;

            return result;

        }
        public int Three(int[] diceValues)

        {

            int result = 0;

            result += diceValues[2] * 3;

            return result;

        }
        public int Four(int[] diceValues)

        {

            int result = 0;

            result += diceValues[3] * 4;

            return result;

        }
        public int Five(int[] diceValues)

        {

            int result = 0;

            result += diceValues[4] * 5;

            return result;

        }
        public int Six(int[] diceValues)

        {

            int result = 0;

            result += diceValues[5] * 6;

            return result;

        }
        public int Pair(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[5] >= 2)

                {

                    result = 12;

                }

                else if (diceValues[4] >= 2)

                {

                    result = 10;

                }

                else if (diceValues[3] >= 2)

                {

                    result = 8;

                }

                else if (diceValues[2] >= 2)

                {

                    result = 6;

                }

                else if (diceValues[1] >= 2)

                {

                    result = 4;

                }

                else if (diceValues[0] >= 2)

                {

                    result = 2;

                }

                else result = 0;

            }

            return result;

        }
        public int TwoPair(int[] diceValues)
        {
            int result = 0;

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] >= 2 && diceValues[1] == 2)
                    result = 6;
                if (diceValues[0] >= 2 && diceValues[2] == 2)
                    result = 8;
                if (diceValues[0] >= 2 && diceValues[3] == 2)
                    result = 10;
                if (diceValues[0] >= 2 && diceValues[4] == 2)
                    result = 12;
                if (diceValues[0] >= 2 && diceValues[5] == 2)
                    result = 14;
                if (diceValues[1] >= 2 && diceValues[0] == 2)
                    result = 6;
                if (diceValues[1] >= 2 && diceValues[2] == 2)
                    result = 10;
                if (diceValues[1] >= 2 && diceValues[3] == 2)
                    result = 12;
                if (diceValues[1] >= 2 && diceValues[4] == 2)
                    result = 14;
                if (diceValues[1] >= 2 && diceValues[5] == 2)
                    result = 16;
                if (diceValues[2] >= 2 && diceValues[0] == 2)
                    result = 8;
                if (diceValues[2] >= 2 && diceValues[1] == 2)
                    result = 10;
                if (diceValues[2] >= 2 && diceValues[3] == 2)
                    result = 14;
                if (diceValues[2] >= 2 && diceValues[4] == 2)
                    result = 16;
                if (diceValues[2] >= 2 && diceValues[5] == 2)
                    result = 18;
                if (diceValues[3] >= 2 && diceValues[0] == 2)
                    result = 10;
                if (diceValues[3] >= 2 && diceValues[1] == 2)
                    result = 12;
                if (diceValues[3] >= 2 && diceValues[2] == 2)
                    result = 14;
                if (diceValues[3] >= 2 && diceValues[4] == 2)
                    result = 18;
                if (diceValues[3] >= 2 && diceValues[5] == 2)
                    result = 20;
                if (diceValues[4] >= 2 && diceValues[0] == 2)
                    result = 12;
                if (diceValues[4] >= 2 && diceValues[1] == 2)
                    result = 14;
                if (diceValues[4] >= 2 && diceValues[2] == 2)
                    result = 16;
                if (diceValues[4] >= 2 && diceValues[3] == 2)
                    result = 18;
                if (diceValues[4] >= 2 && diceValues[5] == 2)
                    result = 22;
                if (diceValues[5] >= 2 && diceValues[0] == 2)
                    result = 14;
                if (diceValues[5] >= 2 && diceValues[1] == 2)
                    result = 16;
                if (diceValues[5] >= 2 && diceValues[2] == 2)
                    result = 18;
                if (diceValues[5] >= 2 && diceValues[3] == 2)
                    result = 20;
                if (diceValues[5] >= 2 && diceValues[4] == 2)
                    result = 22;
            }
            return result;
        } // ingen vacker lösning men fungerar!

        public int ThreeOfKind(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] >= 3)

                    result = 3;

                else if (diceValues[1] >= 3)

                    result = 6;

                else if (diceValues[2] >= 3)

                    result = 9;

                else if (diceValues[3] >= 3)

                    result = 12;

                else if (diceValues[4] >= 3)

                    result = 15;

                else if (diceValues[5] >= 3)

                    result = 18;

                else result = 0;

            }

            return result;

        }
        public int FourOfKind(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] >= 4)

                    result = 4;

                else if (diceValues[1] >= 4)

                    result = 8;

                else if (diceValues[2] >= 4)

                    result = 12;

                else if (diceValues[3] >= 4)

                    result = 16;

                else if (diceValues[4] >= 4)

                    result = 20;

                else if (diceValues[5] >= 4)

                    result = 24;

                else result = 0;

            }

            return result;

        }
        public int BigStraight(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[1] == 1 && diceValues[2] == 1 && diceValues[3] == 1 && diceValues[4] == 1 && diceValues[5] == 1)

                {

                    result = 20;

                }

                else result = 0;

            }





            return result;



        }
        public int SmallStraight(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                if (diceValues[0] == 1 && diceValues[1] == 1 && diceValues[2] == 1 && diceValues[3] == 1 && diceValues[4] == 1)

                {

                    result = 15;

                }

            }

            return result;



        }
        public int Chance(int[] diceValues)

        {

            int result = 0;



            for (int i = 0; i < diceValues.Length; i++)

            {

                result = (diceValues[0] + diceValues[1] * 2 + diceValues[2] * 3 + diceValues[3] * 4 + diceValues[4] * 5 + diceValues[5] * 6);

            }

            return result;

        }
        public int FullHouse(int[] diceValues)
        {
            int result = 0;

            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] == 3 && diceValues[1] == 2)
                    result = 7;
                if (diceValues[0] == 3 && diceValues[2] == 2)
                    result = 9;
                if (diceValues[0] == 3 && diceValues[3] == 2)
                    result = 11;
                if (diceValues[0] == 3 && diceValues[4] == 2)
                    result = 13;
                if (diceValues[0] == 3 && diceValues[5] == 2)
                    result = 15;
                if (diceValues[1] == 3 && diceValues[0] == 2)
                    result = 8;
                if (diceValues[1] == 3 && diceValues[2] == 2)
                    result = 12;
                if (diceValues[1] == 3 && diceValues[3] == 2)
                    result = 14;
                if (diceValues[1] == 3 && diceValues[4] == 2)
                    result = 16;
                if (diceValues[1] == 3 && diceValues[5] == 2)
                    result = 18;
                if (diceValues[2] == 3 && diceValues[0] == 2)
                    result = 11;
                if (diceValues[2] == 3 && diceValues[1] == 2)
                    result = 13;
                if (diceValues[2] == 3 && diceValues[3] == 2)
                    result = 17;
                if (diceValues[2] == 3 && diceValues[4] == 2)
                    result = 19;
                if (diceValues[2] == 3 && diceValues[5] == 2)
                    result = 21;
                if (diceValues[3] == 3 && diceValues[0] == 2)
                    result = 14;
                if (diceValues[3] == 3 && diceValues[1] == 2)
                    result = 16;
                if (diceValues[3] == 3 && diceValues[2] == 2)
                    result = 18;
                if (diceValues[3] == 3 && diceValues[4] == 2)
                    result = 22;
                if (diceValues[3] == 3 && diceValues[5] == 2)
                    result = 24;
                if (diceValues[4] == 3 && diceValues[0] == 2)
                    result = 17;
                if (diceValues[4] == 3 && diceValues[1] == 2)
                    result = 19;
                if (diceValues[4] == 3 && diceValues[2] == 2)
                    result = 21;
                if (diceValues[4] == 3 && diceValues[3] == 2)
                    result = 23;
                if (diceValues[4] == 3 && diceValues[5] == 2)
                    result = 27;
                if (diceValues[5] == 3 && diceValues[0] == 2)
                    result = 20;
                if (diceValues[5] == 3 && diceValues[1] == 2)
                    result = 22;
                if (diceValues[5] == 3 && diceValues[2] == 2)
                    result = 24;
                if (diceValues[5] == 3 && diceValues[3] == 2)
                    result = 26;
                if (diceValues[5] == 3 && diceValues[4] == 2)
                    result = 28;
            }
            return result;
        } // ingen vacker lösning men fungerar!
        public int Yatzee(int[] diceValues)
        {
            int result = 0;
            for (int i = 0; i < diceValues.Length; i++)
            {
                if (diceValues[0] == 5)
                    result = 50;
                else if (diceValues[1] == 5)
                    result = 50;
                else if (diceValues[2] == 5)
                    result = 50;
                else if (diceValues[3] == 5)
                    result = 50;
                else if (diceValues[4] == 5)
                    result = 50;
                else if (diceValues[5] == 5)
                    result = 50;

                else result = 0;
            }

            return result;
        }


        /// <summary>
        /// Save the faces on the dices in an array..
        /// </summary>
        private void SaveDicesToEvaluationArray()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                switch (dices[i])
                {
                    case 1:
                        diceValues[0]++;
                        break;
                    case 2:
                        diceValues[1]++;
                        break;
                    case 3:
                        diceValues[2]++;
                        break;
                    case 4:
                        diceValues[3]++;
                        break;
                    case 5:
                        diceValues[4]++;
                        break;
                    case 6:
                        diceValues[5]++;
                        break;
                }


            }

        }

        /// <summary>
        /// RollDices, get the dices rolling. Assign to the object and the gameset. 
        /// </summary>

        private void RollDices()
        {
            int temp1, temp2, temp3, temp4, temp5;
            if (dice.Keep == false)
            {
                
                temp1 = r.Next(1, 7);
                dices[0] = temp1;
                dice.DiceValue = temp1;
                dice.Img = new BitmapImage(new Uri(@"\" + dice.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice1 = dice;
               
            }
            if (dice1.Keep == false)
            {
                
                temp2= r.Next(1, 7);
                dices[1] = temp2;
                dice1.DiceValue = temp2;
                dice1.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice2 = dice1;
                
            }
            if (dice2.Keep == false)
            {
                temp3 = r.Next(1, 7);
                dices[2] = temp3;
                dice2.DiceValue = temp3;
                dice2.Img = new BitmapImage(new Uri(@"\" + dice2.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice3 = dice2;
                
            }
            if (dice3.Keep == false)
            {
                temp4 = r.Next(1, 7);
                dices[3] = temp4;
                dice3.DiceValue = temp4;
                dice3.Img = new BitmapImage(new Uri(@"\" + dice3.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice4 = dice3;
                
            }
            if (dice4.Keep == false)
            {
                temp5 = r.Next(1, 7);
                dices[4] = temp5;
                dice4.DiceValue = temp5;
                dice4.Img = new BitmapImage(new Uri(@"\" + dice4.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice5 = dice4;
               
            }
        }
        /// <summary>
        /// Set Keep on or off
        /// </summary>
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
    



   


