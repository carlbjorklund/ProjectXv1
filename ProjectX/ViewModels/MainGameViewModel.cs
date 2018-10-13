﻿using System;
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

        public ScoreCard ScoreCardp1 { get; private set; }
        public ScoreCard ScoreCardp2 { get; private set; }
        public ScoreCard ScoreCardp3 { get; private set; }
        public ScoreCard ScoreCardp4 { get; private set; }

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

                   
            // Create the dices.
            dice = new Dice();
            dice1 = new Dice();
            dice2 = new Dice();
            dice3 = new Dice();
            dice4 = new Dice();

            //creating the proposal scorecard
            PropScoreCard = new ScoreCardProp();

            // Creating players scorecards
            ScoreCardp1 = new ScoreCard();
            ScoreCardp2 = new ScoreCard();
            ScoreCardp3 = new ScoreCard();
            ScoreCardp4 = new ScoreCard();

            //giving players their scorecards
            player1.ScoreCard = ScoreCardp1;
            player2.ScoreCard = ScoreCardp2;
            player3.ScoreCard = ScoreCardp3;
            player4.ScoreCard = ScoreCardp4;

            // create the Dicepanel
            Dicepanel = new DicePanel();

            // Adding players to the Gamest
            GameSet.Players.Add(player1);
            GameSet.Players.Add(player2);
            GameSet.Players.Add(player3);
            GameSet.Players.Add(player4);
        }
        public void Revaluate()
        {
            ClearDice();
        }

        public void ClearDice()
        {         
            
            for (int i = 0; i < diceValues.Length; i++)
            {
                diceValues[i] = 0;
            }

        }
        public void Enable()
        {
            GameSet.GameName = "Game Round 1";
            DateTime today = DateTime.Now;

            GameSet.Started_At = today;
            GameSet.Started_At.ToShortDateString();

            ClearDice();
            RollDices();
            SaveDicesToEvaluationArray();
            EvaluateProposal();         


        }
        /// <summary>
        /// Checking what score the end user can obtain based upon current dice values
        /// </summary>
        /// 
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

        #region 
        /// <summary>
        /// Calculate dice values based upon ones, twos, threes etc....
        /// </summary>
        /// <param name="diceValue"></param>
        /// <returns></returns>
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
        } 

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
        } 
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

        #endregion

        #region Populating scorecards
        public void PickOne()
        {
            //make an if to see which player it is? and then fire the functions for each players scorecard???? how to do it???
            // have to put it twice in order to get the results not duplicated...
            // sixes does not display proparly, they seem to disapear.

         
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Ones = One(diceValues);
            ClearDice();
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Ones = One(diceValues);
            ClearDice();
            //PickOne();

        }

        public void PickTwo()
        {
            //SaveDicesToEvaluationArrayForScoreCard();

            //ScoreCardp1.Twos = One(diceValues);
            //ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Twos = Two(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Twos = Two(diceValues);
            ClearDice();

        }
        public void PickThree()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Threes = Three(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Threes = Three(diceValues);
            ClearDice();
        }
        public void PickFour()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Fours = Four(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Fours = Four(diceValues);
            ClearDice();
        }
        public void PickFive()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Fives = Five(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Fives = Five(diceValues);
            ClearDice();
        }
        public void PickSix()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Sixes = Six(diceValues);
            ClearDice();


            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Sixes = Six(diceValues);
            ClearDice();
        }
        public void PickPair()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Pair = Pair(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Pair = Pair(diceValues);
            ClearDice();
        }
        public void PickTwoPair()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.TwoPairs = TwoPair(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.TwoPairs = TwoPair(diceValues);
            ClearDice();
        }
        public void PickThreeOfKind()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.ThreeOfAKind = ThreeOfKind(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.ThreeOfAKind = ThreeOfKind(diceValues);
            ClearDice();
        }
        public void PickFourOfKInd()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.FourOfAKind = FourOfKind(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.FourOfAKind = FourOfKind(diceValues);
            ClearDice();
        }
        public void PickSmallStraight()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.SmallStraight = SmallStraight(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.SmallStraight = SmallStraight(diceValues);
            ClearDice();
        }
        public void PickLargeStraight()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.LargeStraight =BigStraight(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.LargeStraight = BigStraight(diceValues);
            ClearDice();
        }
        public void PickFullHouse()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.FullHouse = FullHouse(diceValues);
            ClearDice();

            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.FullHouse = FullHouse(diceValues);
            ClearDice();
        }
        public void PickChance()
        {
            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Chance = Chance(diceValues);
            ClearDice();


            SaveDicesToEvaluationArrayForScoreCard();
            ScoreCardp1.Chance = Chance(diceValues);
            ClearDice();
        }
        #endregion

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
        private void SaveDicesToEvaluationArrayForScoreCard()
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

        #region //Functions
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

        #endregion

    }
}
    



   


