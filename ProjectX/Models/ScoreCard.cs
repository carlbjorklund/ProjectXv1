using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class ScoreCard : Screen
    {
        /// <summary>
        /// Need to check if this logic is valid;
        /// </summary>
        //public bool HasUpperScore { get { return hasupperscore == IsOnes && Istwos && Isthrees && Isfours && Isfives && Issixes; } }
       
        public bool HasUpperScore { get; private set; }

        public bool Checkhasupperscore()
        {
            if (IsOnes && Istwos && Isthrees && Isfours && Isfives && Issixes == true)
            {
                return HasUpperScore= true;
            }
            else
            { 
                return HasUpperScore=false;

            }
        }
        /// <summary>
        /// test is upper and lower score is populated
        /// </summary>
        //public bool HasLowerScore { get { return hasupperscore == Ispair && Istwospair && IsThreeOfAKind && IsFourOfAKind && IsLargeStraight && Ismallstraight && IsFullHouse && IsChance && IsYatzy; } }
        public bool HasLowerScore { get; private set; }
        public bool Checkhaslowerscore()
        {
            if (Ispair && Istwospair && IsThreeOfAKind && IsFourOfAKind && IsLargeStraight && Ismallstraight && IsFullHouse && IsChance && IsYatzy == true)
            {
                return HasLowerScore =true;
            }
            else
            {
                return HasLowerScore= false;
            }
        }

        public bool GameHasEnded { get; private set; }

        public bool CheckhasgameEnded()
        {
            if (HasLowerScore && HasUpperScore == true)
            {
                return GameHasEnded=true;
            }
            else
            {
                return GameHasEnded=false;
            }
        }

        //private bool haslowerscore
        //{
        //    get { return hasupperscore; }
        //    set
        //    {
        //        if (Ispair && Istwospair && IsThreeOfAKind && IsFourOfAKind && IsLargeStraight && Ismallstraight && IsFullHouse && IsChance && IsYatzy == true)
        //        {
        //            hasupperscore = true;
        //        }
        //        else
        //            hasupperscore = false;

        //    }
        //}
        //public bool HasLowerScorev2 { get { return haslowerscorev2; } }
        //private bool haslowerscorev2
        //{
        //    get { return haslowerscorev2; }
        //    set
        //    {
        //        if (Ispair && Istwospair && IsThreeOfAKind && IsFourOfAKind && IsLargeStraight && Ismallstraight && IsFullHouse && IsChance && IsYatzy == true)
        //        {
        //            haslowerscorev2 = true;
        //        }
        //        else
        //            haslowerscorev2 = false;

        //    }
        //}
  




        private bool hasgameended
        {
            get { return hasgameended; }
            set
            {
                if (HasLowerScore && HasUpperScore == true)
                {
                    hasgameended = true;
                }
                else
                    hasgameended = false;

            }
        }

        /// <summary>
        /// Scorecard and its values, such as ones, twos three of a kind....
        /// </summary>

        public bool IsOnes { get { return ones != -1; } }
        private bool isones;
        private int ones = -1;
        public int Ones
        {
            get { return ones; }
            set
            {
                ones = value; isones = true;

                NotifyOfPropertyChange(() => Ones);
            }
        }
        public bool Istwos { get { return twos != -1; } }
        private bool istwos;
        private int twos = -1;
        public int Twos
        {
            get { return twos; }
            set
            {
                twos = value; istwos = true;

                NotifyOfPropertyChange(() => Twos);
            }
        }
        public bool Isthrees { get { return threes != -1; } }
        public bool isthrees;
        private int threes = -1;
        public int Threes
        {
            get { return threes; }
            set
            {
                threes = value; isthrees = true;

                NotifyOfPropertyChange(() => Threes);
            }
        }

        public bool Isfours { get { return fours != -1; } }
        private bool isfours;
        private int fours = -1;
        public int Fours
        {
            get { return fours; }
            set
            {
                fours = value; isfours = true;

                NotifyOfPropertyChange(() => Fours);
            }
        }

        public bool Isfives { get { return fives != -1; } }
        private bool isfives;
        private int fives = -1;
        public int Fives
        {
            get { return fives; }
            set
            {
                fives = value; isfives = true;

                NotifyOfPropertyChange(() => Fives);
            }
        }


        public bool Issixes { get { return sixes != -1; } }
        private bool issixes;
        private int sixes = -1;
        public int Sixes
        {
            get { return sixes; }
            set
            {
                sixes = value; issixes = true;

                NotifyOfPropertyChange(() => Sixes);
            }
        }
        public bool Issum { get { return sum != -1; } }
        private bool issum;
        private int sum = -1;
        public int Sum
        {
            get { return sum; }
            set
            {
                sum = value; issum = true;

                NotifyOfPropertyChange(() => Sum);
            }
        }

        public bool Isbonus { get { return bonus != -1; } }
        private bool isbonus;
        private int bonus = -1;
        public int Bonus
        {
            get { return bonus; }
            set
            {
                bonus = value;

                NotifyOfPropertyChange(() => Bonus);
            }
        }


        public bool Ispair { get { return pair != -1; } }
        private bool ispair;
        private int pair = -1;
        public int Pair
        {
            get { return pair; }
            set
            {
                pair = value; ispair = true;

                NotifyOfPropertyChange(() => Pair);
            }
        }
        public bool Istwospair { get { return twoPairs != -1; } }
        private bool istwopair;
        private int twoPairs = -1;
        public int TwoPairs
        {
            get { return twoPairs; }
            set
            {
                twoPairs = value; istwopair = true;

                NotifyOfPropertyChange(() => TwoPairs);
            }
        }
        public bool IsThreeOfAKind { get { return threeOfAKind != -1; } }
        private bool isthreeofakind;
        private int threeOfAKind = -1;
        public int ThreeOfAKind
        {
            get { return threeOfAKind; }
            set
            {
                threeOfAKind = value; isthreeofakind = true;

                NotifyOfPropertyChange(() => ThreeOfAKind);
            }
        }
        public bool IsFourOfAKind { get { return fourOfAKind != -1; } }
        private bool isfoursofakind;
        private int fourOfAKind = -1;
        public int FourOfAKind
        {
            get { return fourOfAKind; }
            set
            {
                fourOfAKind = value;

                NotifyOfPropertyChange(() => FourOfAKind);
            }
        }
        public bool Ismallstraight { get { return smallStraight != -1; } }
        private bool issmallstraight;
        private int smallStraight = -1;
        public int SmallStraight
        {
            get { return smallStraight; }
            set
            {
                smallStraight = value; issmallstraight = true;

                NotifyOfPropertyChange(() => SmallStraight);
            }
        }
        public bool IsLargeStraight { get { return largeStraight != -1; } }
        private bool islargestraight;
        private int largeStraight = -1;
        public int LargeStraight
        {
            get { return largeStraight; }
            set
            {
                largeStraight = value; islargestraight = true;

                NotifyOfPropertyChange(() => LargeStraight);
            }
        }
        public bool IsFullHouse { get { return fullHouse != -1; } }
        private bool isfullhouse;
        private int fullHouse = -1;
        public int FullHouse
        {
            get { return fullHouse; }
            set
            {
                fullHouse = value; isfullhouse = true;

                NotifyOfPropertyChange(() => FullHouse);
            }
        }
        public bool IsChance { get { return chance != -1; } }
        private bool ischance;
        private int chance = -1;
        public int Chance
        {
            get { return chance; }
            set
            {
                chance = value; ischance = true;

                NotifyOfPropertyChange(() => Chance);
            }
        }
        public bool IsYatzy { get { return yatzy != -1; } }
        private bool isyatzy;
        private int yatzy = -1;
        public int Yatzy
        {
            get { return yatzy; }
            set
            {
                yatzy = value; isyatzy = true;

                NotifyOfPropertyChange(() => Yatzy);
            }
        }
        public bool IsTotal { get { return total != -1; } }
        private bool istotal;
        private int total = -1;
        public int Total
        {
            get { return total; }
            set
            {
                total = value; istotal = true;

                NotifyOfPropertyChange(() => Total);
            }
        }

   

        public class ScoreCardProp : Screen
        {
            public ScoreCardProp()
            {

            }
            public bool IsOnesProp { get { return onesprop != -1; } }
            private bool isonesprop;
            private int onesprop = -1;
            public int PropOnes
            {
                get { return onesprop; }
                set
                {
                    onesprop = value; isonesprop = true;

                    NotifyOfPropertyChange(() => PropOnes);
                }
            }
            public bool Istwosprop { get { return twosprop != -1; } }
            private bool istwoprop;
            private int twosprop = -1;
            public int PropTwos
            {
                get { return twosprop; }
                set
                {
                    twosprop = value; istwoprop = true;

                    NotifyOfPropertyChange(() => PropTwos);
                }
            }
            public bool Isthreesprop { get { return threesprop != -1; } }
            private bool isthreespop;
            private int threesprop = -1;
            public int PropThrees
            {
                get { return threesprop; }
                set
                {
                    threesprop = value; isthreespop = true;

                    NotifyOfPropertyChange(() => PropThrees);
                }
            }
            public bool Isfoursprop { get { return foursprop != -1; } }
            private bool isfourprop;
            private int foursprop = -1;
            public int PropFours
            {
                get { return foursprop; }
                set
                {
                    foursprop = value; isfourprop = true;

                    NotifyOfPropertyChange(() => PropFours);
                }
            }
            public bool Isfivesprop { get { return fivesprop != -1; } }
            private bool isfivesprop;
            private int fivesprop = -1;
            public int PropFives
            {
                get { return fivesprop; }
                set
                {
                    fivesprop = value; isfivesprop = true;

                    NotifyOfPropertyChange(() => PropFives);
                }
            }
            public bool Isixesprop { get { return sixesprop != -1; } }
            private bool isixesprop;
            private int sixesprop = -1;
            public int PropSixes
            {
                get { return sixesprop; }
                set
                {
                    sixesprop = value; isixesprop = true;

                    NotifyOfPropertyChange(() => PropSixes);
                }
            }
            public bool Issumprop { get { return fivesprop != -1; } }
            private bool issumprop;
            private int sumprop;
            public int PropSum
            {
                get { return sumprop; }
                set
                {
                    sumprop = value; issumprop = true;

                    NotifyOfPropertyChange(() => PropSum);
                }
            }

            public bool Isbonusprop;
            private int bonusprop;
            public int Bonusprop
            {
                get { return bonusprop; }
                set
                {
                    bonusprop = value;

                    NotifyOfPropertyChange(() => Bonusprop);
                }
            }
            public bool Ispairprop { get { return pairprop != -1; } }
            private bool ispair;
            private int pairprop = -1;
            public int PropPair
            {
                get { return pairprop; }
                set
                {
                    pairprop = value; ispair = true;

                    NotifyOfPropertyChange(() => PropPair);
                }
            }
            public bool IstwoPairsprop { get { return twoPairsprop != -1; } }
            private int twoPairsprop = -1;
            public int PropTwoPairs
            {
                get { return twoPairsprop; }
                set
                {
                    twoPairsprop = value; istwoprop = true;

                    NotifyOfPropertyChange(() => PropTwoPairs);
                }
            }
            public bool IsthreeOfAKindprop { get { return threeOfAKindprop != -1; } }
            private bool isthreeofakindprop;
            private int threeOfAKindprop = -1;
            public int PropThreeOfAKind
            {
                get { return threeOfAKindprop; }
                set
                {
                    threeOfAKindprop = value; isthreeofakindprop = true;

                    NotifyOfPropertyChange(() => PropThreeOfAKind);
                }
            }
            public bool IsfourOfAKindprop { get { return fourOfAKindprop != -1; } }
            private bool isfourofakindpop;
            private int fourOfAKindprop = -1;
            public int PropFourOfAKind
            {
                get { return fourOfAKindprop; }
                set
                {
                    fourOfAKindprop = value; isfourofakindpop = true;

                    NotifyOfPropertyChange(() => PropFourOfAKind);
                }
            }
            public bool IssmallStraightprop { get { return smallStraightprop != -1; } }
            private bool issmallstraightprop;
            private int smallStraightprop = -1;
            public int SmallStraightprop
            {
                get { return smallStraightprop; }
                set
                {
                    smallStraightprop = value; issmallstraightprop = true;

                    NotifyOfPropertyChange(() => SmallStraightprop);
                }
            }
            public bool IslargeStraightprop { get { return largeStraightprop != -1; } }
            private bool islargeStraightprop;
            private int largeStraightprop = -1;
            public int PropLargeStraight
            {
                get { return largeStraightprop; }
                set
                {
                    largeStraightprop = value; islargeStraightprop = true;

                    NotifyOfPropertyChange(() => PropLargeStraight);
                }
            }
            public bool IsfullHouseprop { get { return fullHouseprop != -1; } }
            private bool isfullhouseprop;
            private int fullHouseprop = -1;
            public int PropFullHouse
            {
                get { return fullHouseprop; }
                set
                {
                    fullHouseprop = value; isfullhouseprop = true;

                    NotifyOfPropertyChange(() => PropFullHouse);
                }
            }

            public bool Ischanceprop { get { return chanceprop != -1; } }
            private bool ischanceprop;
            private int chanceprop = -1;
            public int PropChance
            {
                get { return chanceprop; }
                set
                {
                    chanceprop = value; ischanceprop = true;

                    NotifyOfPropertyChange(() => PropChance);
                }
            }
            public bool Isyatzyprop { get { return yatzyprop != -1; } }
            private bool isyatzyprop;
            private int yatzyprop = -1;
            public int PropYatzy
            {
                get { return yatzyprop; }
                set
                {
                    yatzyprop = value; isyatzyprop = true;

                    NotifyOfPropertyChange(() => PropYatzy);
                }
            }
            public bool Istotalprop { get { return totalprop != -1; } }
            private bool istotalprop;
            private int totalprop = -1;
            public int PropTotal
            {
                get { return totalprop; }
                set
                {
                    totalprop = value; istotalprop = true;

                    NotifyOfPropertyChange(() => PropTotal);
                }
            }
        }
    }
}


