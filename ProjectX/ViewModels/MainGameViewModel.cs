﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Caliburn.Micro;
using ProjectX.Models;
using ProjectX.Views;
using static System.Net.Mime.MediaTypeNames;
using static ProjectX.Models.ScoreCard;

namespace ProjectX.ViewModels
{

    public class MainGameViewModel : Screen
    {
        public GameSetEngine GameSetEngine;

        public int[] dices = new int[5] { 0, 0, 0, 0, 0 };
        public int[] diceValues = new int[6] { 0, 0, 0, 0, 0, 0 };

        public bool Isbuttonrolldicespushed { get; private set; }
        int rolles = 3;



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
        int position = 0;



        public ScoreCard ScoreCardp1 { get; private set; }
        public ScoreCard ScoreCardp2 { get; private set; }
        public ScoreCard ScoreCardp3 { get; private set; }
        public ScoreCard ScoreCardp4 { get; private set; }

        public Player CurrentPlayer { get; set; }

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
            player3.Name = "Daniel";
            player4 = new Player();
            player4.Name = "Carl";

            CurrentPlayer = new Player();


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

            int size = GameSet.Players.Count;
            GameSet.GameName = "Game Round 1";
            DateTime today = DateTime.Now;

            //GameSet.GameTypeRestricted = true;

            GameSet.Started_At = today;
            GameSet.Started_At.ToShortDateString();


        }
        /// <summary>
        /// need to check logic for this one
        /// </summary>

        public void CheckUpperScoore()
        {
            if (ScoreCardp1.Checkhasupperscore() == true/* && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp3.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true*/)
            {

                CanPickPair();
                CanPickTwoPair();
                CanPickThreeOfKind();
                CanPickFourOfKind();
                CanPickFullHouse();
                CanPickSmallStraight();
                CanPickLargeStraight();
                CanPickChance();
                CanPickYatzy();

            }
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

        /// <summary>
        /// need to check logic for this one
        /// </summary>
        /// <returns></returns>

        public bool CanPickPair()
        {

            

            if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true/* && ScoreCardp2.HasUpperScore == true && ScoreCardp4.HasUpperScore == true && ScoreCardp4.HasUpperScore == true*/)
            {
                /*MessageBox.Show(" upper score found first "); // this fires when all scorecard 1 upper is done..*/
                return true;
            }
            if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false)
            {
                return true;
            }
            else return false;

            //else if (ScoreCardp1.HasUpperScore==false /*== true*//* && ScoreCardp2.HasUpperScore == true && ScoreCardp4.HasUpperScore == true && ScoreCardp4.HasUpperScore == true*/)
            //{
            //    //MessageBox.Show("No upper score first");
            //    return false;
            //}

            //if (ScoreCardp1.Checkhasupperscore() == true)
            //{
            //    //MessageBox.Show(" upper score found sencond");
            //    return true;
            //}
            //else if (ScoreCardp1.Checkhasupperscore() == false)

            //{
            //    //MessageBox.Show("No upper score second");
            //    return false;

            //}

            //if (ScoreCardp1.Checkhasupperscore() == true/* && ScoreCardp2.HasUpperScore == true && ScoreCardp4.HasUpperScore == true && ScoreCardp4.HasUpperScore == true*/)
            //{
            //    return true;
            //}

            //if (ScoreCardp1.Checkhasupperscore() /* && ScoreCardp2.HasUpperScore == true && ScoreCardp4.HasUpperScore == true && ScoreCardp4.HasUpperScore == true*/)
            //{
            //    return true;
            //}

            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //&& ScoreCardp2.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false /*&& ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            //{
            //    return false;
            //}


        }

        public bool CanPickTwoPair()
        {
            
            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true)
            {
                return true;
            }

            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //&& ScoreCardp2.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp3.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false/* && ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }

        public bool CanPickThreeOfKind()
        {

            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }

            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //&& ScoreCardp2.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp3.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false /*&& ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// don't know why is not working....to disble it
        /// </summary>
        /// <returns></returns>
        public bool CanPickFourOfKind()
        {

            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //&& ScoreCardp2.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false/* && ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        } 

       public bool CanPickSmallStraight()
        {

            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true  && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }

            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //   && ScoreCardp2.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false)
            {
                return true;
            }
            else return false;
        }

        public bool CanPickLargeStraight()
        {

            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //&& ScoreCardp2.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true
            //&& ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false /*&& ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }

        public bool CanPickFullHouse()
        {
            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //   && ScoreCardp2.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp3.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false /*&& ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }

        public bool CanPickChance()
        {
            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //   && ScoreCardp2.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true) { return true; }
            ////if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp3.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            //if (GameSet.GameTypeRestricted == false && ScoreCardp1.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp2.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp3.HasUpperScore == false) { return true; }
            //if (GameSet.GameTypeRestricted == false && ScoreCardp4.HasUpperScore == false) { return true; }
            //else return false;

            if (GameSet.GameTypeRestricted == false/* && ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Dont know why this is not working....the code is almost identical to the others of the same type...
        /// </summary>
        /// <returns></returns>
        public bool CanPickYatzy()
        {
            if (GameSet.GameTypeRestricted == true && ScoreCardp1.Checkhasupperscore() == true && ScoreCardp2.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true && ScoreCardp4.Checkhasupperscore() == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true
            //   && ScoreCardp2.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true
            //   && ScoreCardp4.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp1.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp2.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp3.HasUpperScore == true) { return true; }
            //if (GameSet.GameTypeRestricted == true && ScoreCardp4.HasUpperScore == true) { return true; }

            if (GameSet.GameTypeRestricted == false /*&& ScoreCardp1.HasUpperScore == false && ScoreCardp2.HasUpperScore == false && ScoreCardp3.HasUpperScore == false && ScoreCardp4.HasUpperScore == false*/)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        ///
        /// </summary>
        public void Enable()
        {

            CurrentPlayer.Name = GameSet.Players[0].Name;
            CurrentPlayer = GameSet.Players[position];
           


        }
     

        public void Next()
        {

            position++;
            if (position > 4 - 1) position = 4 - 1;
           
            CurrentPlayer.Name = GameSet.Players[position].Name;
            CurrentPlayer = GameSet.Players[position];
            CurrentPlayer.Rolles = 3;
            ClearDice();
            ClearKeepDices();
            CanPickPair();
            CanPickTwoPair();
            CanPickThreeOfKind();
            CanPickFourOfKind();
            CanPickFullHouse();
            CanPickLargeStraight();
            CanPickSmallStraight();
            CanPickChance();
            CanPickYatzy();



        }
        public void Back()
        {
            position--;
            if (position < 0) position = 0;
            CurrentPlayer = GameSet.Players[position];
            CurrentPlayer.Name = GameSet.Players[position].Name;
           
            
        }


        


        /// <summary>
        /// Checking what score the end user can obtain based upon current dice values
        /// </summary>
        /// 
        private void EvaluateProposal()
        {
            

            if (One(diceValues) > 0)
            {
                PropScoreCard.PropOnes = -1;
                PropScoreCard.PropOnes = One(diceValues);
            }
            if (Two(diceValues) > 0)
            {
                PropScoreCard.PropTwos = -1;
                PropScoreCard.PropTwos = Two(diceValues);
               
            }
            if (Three(diceValues) > 0)
            {
                PropScoreCard.PropThrees = -1;
                PropScoreCard.PropThrees = Three(diceValues);
            }
            if (Four(diceValues) > 0)
            {
                PropScoreCard.PropFours = -1;
                PropScoreCard.PropFours = Four(diceValues);
            }
            if (Five(diceValues) > 0)
            {
                PropScoreCard.PropFives = -1;
                PropScoreCard.PropFives = Five(diceValues);
            }
            if (Six(diceValues) > 0)
            {
                PropScoreCard.PropSixes = -1;
                PropScoreCard.PropSixes = Six(diceValues);
            }
            if (Pair(diceValues) > 0)
            {
                PropScoreCard.PropPair = -1;
                PropScoreCard.PropPair = Pair(diceValues);
            }
            if (TwoPair(diceValues) > 0)
            {
                PropScoreCard.PropTwoPairs = -1;
                PropScoreCard.PropTwoPairs = TwoPair(diceValues);
            }
            if (ThreeOfKind(diceValues) > 0)
            {
                PropScoreCard.PropThreeOfAKind = -1;
                PropScoreCard.PropThreeOfAKind = ThreeOfKind(diceValues);
            }
            if (FourOfKind(diceValues) > 0)
            {
                PropScoreCard.PropFourOfAKind = -1;
                PropScoreCard.PropFourOfAKind = FourOfKind(diceValues);
            }
            if (SmallStraight(diceValues) > 0)
            {
                PropScoreCard.SmallStraightprop = -1;
                PropScoreCard.SmallStraightprop = SmallStraight(diceValues);
            }
            if (BigStraight(diceValues) > 0)
            {
                PropScoreCard.PropLargeStraight = -1;
                PropScoreCard.PropLargeStraight = BigStraight(diceValues);
            }
            if (FullHouse(diceValues) > 0)
            {
                PropScoreCard.PropFullHouse = -1;
                PropScoreCard.PropFullHouse = FullHouse(diceValues);
            }
            if (Chance(diceValues) > 0)
            {
                PropScoreCard.PropChance = -1;
                PropScoreCard.PropChance = Chance(diceValues);
            }
            if (Yatzee(diceValues) > 0)
            {
                PropScoreCard.PropYatzy = -1;
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
        /// <summary>
        /// take the ones option,populating the scorecard, depening on player and scorecard
        /// </summary>
        public void PickOne()
        {
            // have to put it twice in order to get the results not duplicated...

            if (!ScoreCardp1.IsOnes && CurrentPlayer == player1)
            {

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Ones = One(diceValues);
                ClearDice();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Ones = One(diceValues);
                player1.ScoreCard.Ones = ScoreCardp1.Ones;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
                cheackplayerposition();
            



            }
            if (!ScoreCardp2.IsOnes && CurrentPlayer == player2)
            {

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Ones = One(diceValues);
                ClearDice();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Ones = One(diceValues);
                player2.ScoreCard.Ones = ScoreCardp2.Ones;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
                cheackplayerposition();

            }
            if (!ScoreCardp3.IsOnes && CurrentPlayer == player3)
            {

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Ones = One(diceValues);
                ClearDice();
                ClearKeepDices();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Ones = One(diceValues);
                player3.ScoreCard.Ones = ScoreCardp3.Ones;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
                cheackplayerposition();
            }
        
            if (!ScoreCardp4.IsOnes && CurrentPlayer == player4)
            {

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Ones = One(diceValues);
                ClearDice();
                ClearKeepDices();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Ones = One(diceValues);
                player4.ScoreCard.Ones = ScoreCardp4.Ones;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
                cheackplayerposition();



            }
            //if(ScoreCardp1.IsOnes || ScoreCardp2.IsOnes || ScoreCardp3.IsOnes || ScoreCardp4.IsOnes)
            //{
            //    MessageBox.Show("Du har tagit ettor");
            //}

            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();
            CheckUpperScoore();
        
            }

        private void cheackplayerposition()
        {
            if (position == 3)
            {
                position = -1;
            }
        }

        /// <summary>
        /// take the two options
        /// </summary>

        public void PickTwo()
            {

            if (!ScoreCardp1.Istwos && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Twos = Two(diceValues);
                ClearDice();
                ClearKeepDices();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Twos = Two(diceValues);
                player1.ScoreCard.Twos = ScoreCardp1.Twos;                
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();

            }
            if (!ScoreCardp2.Istwos && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Twos = Two(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Twos = Two(diceValues);
                player2.ScoreCard.Twos = ScoreCardp2.Twos;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp3.Istwos && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Twos = Two(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Twos = Two(diceValues);
                player3.ScoreCard.Twos = ScoreCardp3.Twos;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp4.Istwos && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Twos = Two(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Twos = Two(diceValues);
                player4.ScoreCard.Twos = ScoreCardp4.Twos;
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            //else
            //{
            //    MessageBox.Show("Du har tagit tvåor");
            //}
            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();


        }
        /// <summary>
        /// take the three options
        /// </summary>
        public void PickThree()
        {
            if (!ScoreCardp1.Isthrees && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp2.Isthrees && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp3.Isthrees && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp4.Isthrees && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Threes = Three(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();
        }
        /// <summary>
        /// take the fours option
        /// </summary>
        public void PickFour()
        {
            if (!ScoreCardp1.Isfours && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp2.Isfours && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp3.Isfours && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp4.Isfours && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Fours = Four(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();
        }
        /// <summary>
        /// take the fives option
        /// </summary>
        public void PickFive()
        {
            if (!ScoreCardp1.Isfives && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp2.Isfives && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp3.Isfives && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp4.Isfives && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Fives = Five(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();
        }

        /// <summary>
        /// take the sixes option
        /// </summary>
        public void PickSix()
        {
            if (!ScoreCardp1.Issixes && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp2.Issixes && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp3.Issixes && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }
            if (!ScoreCardp4.Issixes && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Sixes = Six(diceValues);
                ClearDice();
                ClearKeepDices();
                UpperScore();
                Bonus();
                TotalScore();
            }

            Next();
            ResetDices();
            ClearKeepDices();
            cheackplayerposition();
        }

        /// <summary>
        /// Calculates the upper score...
        /// </summary>
        public void UpperScore()
        {
            ScoreCardp1.Sum = ScoreCardp1.Ones + ScoreCardp1.Twos + ScoreCardp1.Threes + ScoreCardp1.Fours + ScoreCardp1.Fives + ScoreCardp1.Sixes;
            ScoreCardp2.Sum = ScoreCardp2.Ones + ScoreCardp2.Twos + ScoreCardp2.Threes + ScoreCardp2.Fours + ScoreCardp2.Fives + ScoreCardp2.Sixes;
            ScoreCardp3.Sum = ScoreCardp3.Ones + ScoreCardp3.Twos + ScoreCardp3.Threes + ScoreCardp3.Fours + ScoreCardp3.Fives + ScoreCardp3.Sixes;
            ScoreCardp4.Sum = ScoreCardp4.Ones + ScoreCardp4.Twos + ScoreCardp4.Threes + ScoreCardp4.Fours + ScoreCardp4.Fives + ScoreCardp4.Sixes;
        }

        /// <summary>
        /// Calculates if there is a bonus
        /// </summary>
        public void Bonus()
        {
            if (ScoreCardp1.Ones != -1 && ScoreCardp1.Twos != -1 && ScoreCardp1.Threes != -1 && ScoreCardp1.Fours != -1 && ScoreCardp1.Fives != -1 && ScoreCardp1.Sixes != -1)
            {
                if (ScoreCardp1.Sum >= 63)
                    ScoreCardp1.Bonus = 50;
                else ScoreCardp1.Bonus = 0;
            }
            if (ScoreCardp2.Ones != -1 && ScoreCardp2.Twos != -1 && ScoreCardp2.Threes != -1 && ScoreCardp2.Fours != -1 && ScoreCardp2.Fives != -1 && ScoreCardp2.Sixes != -1)
            {
                if (ScoreCardp2.Sum >= 63)
                    ScoreCardp2.Bonus = 50;
                else ScoreCardp2.Bonus = 0;
            }
            if (ScoreCardp3.Ones != -1 && ScoreCardp3.Twos != -1 && ScoreCardp3.Threes != -1 && ScoreCardp3.Fours != -1 && ScoreCardp3.Fives != -1 && ScoreCardp3.Sixes != -1)
            {
                if (ScoreCardp3.Sum >= 63)
                    ScoreCardp3.Bonus = 50;
                else ScoreCardp3.Bonus = 0;
            }
            if (ScoreCardp4.Ones != -1 && ScoreCardp4.Twos != -1 && ScoreCardp4.Threes != -1 && ScoreCardp4.Fours != -1 && ScoreCardp4.Fives != -1 && ScoreCardp4.Sixes != -1)
            {
                if (ScoreCardp4.Sum >= 63)
                    ScoreCardp4.Bonus = 50;
                else ScoreCardp4.Bonus = 0;
            }


        }
        /// <summary>
        /// Take pair option
        /// </summary>
        public void PickPair()
        {
            if (!ScoreCardp1.Ispair && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
               
            }
            if (!ScoreCardp1.Ispair && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.Ispair && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();


            }
            if (!ScoreCardp4.Ispair && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Pair = Pair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            else
            {
                MessageBox.Show("Du har redan två par");
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }

        /// <summary>
        /// take two pair option
        /// </summary>
        public void PickTwoPair()
        {
            if (!ScoreCardp1.Istwospair && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.TwoPairs = TwoPair(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.TwoPairs = TwoPair(diceValues);
                ClearDice();
                ClearKeepDices();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.Istwospair && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.TwoPairs = TwoPair(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.TwoPairs = TwoPair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.Istwospair && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.TwoPairs = TwoPair(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.TwoPairs = TwoPair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp4.Istwospair && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.TwoPairs = TwoPair(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.TwoPairs = TwoPair(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }/// <summary>
        /// Take the three of a kind option
        /// </summary>
        public void PickThreeOfKind()
        {
            if (!ScoreCardp1.IsThreeOfAKind && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();


                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.IsThreeOfAKind && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();


                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.IsThreeOfAKind && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();


                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();

            }
            if (!ScoreCardp4.IsThreeOfAKind && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();


                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.ThreeOfAKind = ThreeOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }
        /// <summary>
        /// take four of a kind option
        /// </summary>
        public void PickFourOfKind()
        {
            if (!ScoreCardp1.IsFourOfAKind && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.FourOfAKind = FourOfKind(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.FourOfAKind = FourOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.IsFourOfAKind && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.FourOfAKind = FourOfKind(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.FourOfAKind = FourOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.IsFourOfAKind && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.FourOfAKind = FourOfKind(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.FourOfAKind = FourOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp4.IsFourOfAKind && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.FourOfAKind = FourOfKind(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.FourOfAKind = FourOfKind(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }
        /// <summary>
        /// Take small straight function
        /// </summary>
        public void PickSmallStraight()
        {
            if (!ScoreCardp1.Ismallstraight && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.SmallStraight = SmallStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.SmallStraight = SmallStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.Ismallstraight && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.SmallStraight = SmallStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.SmallStraight = SmallStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.Ismallstraight && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.SmallStraight = SmallStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.SmallStraight = SmallStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp4.Ismallstraight && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.SmallStraight = SmallStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.SmallStraight = SmallStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }
        /// <summary>
        /// Take large straight, function
        /// </summary>
        public void PickLargeStraight()
        {
            if (!ScoreCardp1.Ismallstraight && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.LargeStraight = BigStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.LargeStraight = BigStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.Ismallstraight && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.LargeStraight = BigStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.LargeStraight = BigStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.Ismallstraight && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.LargeStraight = BigStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.LargeStraight = BigStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp4.Ismallstraight && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.LargeStraight = BigStraight(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.LargeStraight = BigStraight(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }
        /// <summary>
        /// Take the fullhousse, function
        /// </summary>
        public void PickFullHouse()
        {
            if (!ScoreCardp1.IsFullHouse && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.FullHouse = FullHouse(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.FullHouse = FullHouse(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.IsFullHouse && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.FullHouse = FullHouse(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.FullHouse = FullHouse(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.IsFullHouse && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.FullHouse = FullHouse(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.FullHouse = FullHouse(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();

            }
            if (!ScoreCardp4.IsFullHouse && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.FullHouse = FullHouse(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.FullHouse = FullHouse(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }
        /// <summary>
        /// Take the chance option function
        /// </summary>
        public void PickChance()
        {
            if (!ScoreCardp1.IsChance && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Chance = Chance(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Chance = Chance(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.IsChance && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Chance = Chance(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Chance = Chance(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp3.IsChance && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Chance = Chance(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Chance = Chance(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp4.IsChance && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Chance = Chance(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Chance = Chance(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();
        }

        public void PickYatzy()
        {
            if (!ScoreCardp1.IsYatzy && CurrentPlayer == player1)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Yatzy = Yatzee(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp1.Yatzy = Yatzee(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp2.IsYatzy && CurrentPlayer == player2)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Yatzy = Yatzee(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp2.Yatzy = Yatzee(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp1.IsYatzy && CurrentPlayer == player3)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Yatzy = Yatzee(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp3.Yatzy = Yatzee(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            if (!ScoreCardp1.IsYatzy && CurrentPlayer == player4)
            {
                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Yatzy = Yatzee(diceValues);
                ClearDice();

                SaveDicesToEvaluationArrayForScoreCard();
                ScoreCardp4.Yatzy = Yatzee(diceValues);
                ClearDice();
                ClearKeepDices();
                TotalScore();
            }
            Next();
            ResetDices();
            ClearKeepDices();

        }


        /// <summary>
        /// Calculates total score
        /// </summary>
        public void TotalScore()
        {
            ScoreCardp1.Total = ScoreCardp1.Sum + ScoreCardp1.Pair + ScoreCardp1.TwoPairs + ScoreCardp1.ThreeOfAKind + ScoreCardp1.FourOfAKind + ScoreCardp1.SmallStraight + ScoreCardp1.LargeStraight + ScoreCardp1.Chance + ScoreCardp1.Yatzy;
            ScoreCardp2.Total = ScoreCardp2.Sum + ScoreCardp2.Pair + ScoreCardp2.TwoPairs + ScoreCardp2.ThreeOfAKind + ScoreCardp2.FourOfAKind + ScoreCardp2.SmallStraight + ScoreCardp2.LargeStraight + ScoreCardp2.Chance + ScoreCardp2.Yatzy;
            ScoreCardp3.Total = ScoreCardp3.Sum + ScoreCardp3.Pair + ScoreCardp3.TwoPairs + ScoreCardp3.ThreeOfAKind + ScoreCardp3.FourOfAKind + ScoreCardp3.SmallStraight + ScoreCardp3.LargeStraight + ScoreCardp3.Chance + ScoreCardp3.Yatzy;
            ScoreCardp4.Total = ScoreCardp4.Sum + ScoreCardp4.Pair + ScoreCardp4.TwoPairs + ScoreCardp4.ThreeOfAKind + ScoreCardp4.FourOfAKind + ScoreCardp4.SmallStraight + ScoreCardp4.LargeStraight + ScoreCardp4.Chance + ScoreCardp4.Yatzy;
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
        /// 
        public void ResetDices()
        {
            dice.DiceValue = 0;
            dice.Img = new BitmapImage(new Uri(@"\" + dice.DiceValue.ToString() + ".png", UriKind.Relative));
            GameSet.DicePanel.Dice1 = dice;

            dice1.DiceValue = 0;
            dice1.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
            GameSet.DicePanel.Dice2 = dice1;

            dice2.DiceValue = 0;
            dice2.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
            GameSet.DicePanel.Dice3 = dice2;

            dice3.DiceValue = 0;
            dice3.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
            GameSet.DicePanel.Dice4 = dice3;

            dice4.DiceValue = 0;
            dice4.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
            GameSet.DicePanel.Dice5 = dice4;
        }

        public void RollDices()
        {
            
            int temp1, temp2, temp3, temp4, temp5;
            if (dice.Keep == false && CurrentPlayer.Rolles != 0) /// test 
                //if (dice.Keep == false)
                {
                
                temp1 = r.Next(1, 7);
                dices[0] = temp1;
                dice.DiceValue = temp1;
                dice.Img = new BitmapImage(new Uri(@"\" + dice.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice1 = dice;
               
            }
            if(dice1.Keep == false && CurrentPlayer.Rolles != 0) //test
            //if (dice1.Keep == false)
            {
                
                temp2= r.Next(1, 7);
                dices[1] = temp2;
                dice1.DiceValue = temp2;
                dice1.Img = new BitmapImage(new Uri(@"\" + dice1.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice2 = dice1;
                
            }
            if (dice2.Keep == false && CurrentPlayer.Rolles != 0) //test
                //if (dice2.Keep == false)
            {
                temp3 = r.Next(1, 7);
                dices[2] = temp3;
                dice2.DiceValue = temp3;
                dice2.Img = new BitmapImage(new Uri(@"\" + dice2.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice3 = dice2;
                
            }
            if (dice3.Keep == false && CurrentPlayer.Rolles != 0) //test
                //if (dice3.Keep == false)
            {
                temp4 = r.Next(1, 7);
                dices[3] = temp4;
                dice3.DiceValue = temp4;
                dice3.Img = new BitmapImage(new Uri(@"\" + dice3.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice4 = dice3;
                
            }
            if (dice4.Keep == false && CurrentPlayer.Rolles != 0) //test
                //if (dice4.Keep == false)
            {
                temp5 = r.Next(1, 7);
                dices[4] = temp5;
                dice4.DiceValue = temp5;
                dice4.Img = new BitmapImage(new Uri(@"\" + dice4.DiceValue.ToString() + ".png", UriKind.Relative));
                GameSet.DicePanel.Dice5 = dice4;
            }
            else
            {
                MessageBox.Show("Du har slagit tre slag. Välj poäng!");
            }
            CurrentPlayer.Rolles -= 1;
            SaveDicesToEvaluationArray();
            EvaluateProposal();
            CheckUpperScoore();



            ClearDice();
            





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
        public void ClearKeepDices()
        {
                        //dice.Keep = false;            
            //dice1.Keep = false;
            //dice2.Keep = false;
            //dice3.Keep = false;
            //dice4.Keep = false;

            //Dicepanel.Dice1.Keep = false;
            //Dicepanel.Dice2.Keep = false;
            //Dicepanel.Dice3.Keep = false;
            //Dicepanel.Dice4.Keep = false;
            //Dicepanel.Dice5.Keep = false;

            //GameSet.DicePanel.Dice1.Keep = false;
            //GameSet.DicePanel.Dice2.Keep = false;
            //GameSet.DicePanel.Dice3.Keep = false;
            //GameSet.DicePanel.Dice4.Keep = false;
            //GameSet.DicePanel.Dice5.Keep = false;


        }
        #endregion

    }
}
    



   


