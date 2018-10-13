using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class ScoreCard:Screen
    {
        private int ones;
        public int Ones
        {
            get { return ones; }
            set
            {
                ones = value;

                NotifyOfPropertyChange(() => Ones);
            }
        }
        private int twos;
        public int Twos
        {
            get { return twos; }
            set
            {
                twos = value;

                NotifyOfPropertyChange(() => Twos);
            }
        }

        private int threes;
        public int Threes
        {
            get { return threes; }
            set
            {
                threes = value;

                NotifyOfPropertyChange(() => Threes);
            }
        }


        private int fours;
        public int Fours
        {
            get { return fours; }
            set
            {
                fours = value;

                NotifyOfPropertyChange(() => Fours);
            }
        }


        private int fives;
        public int Fives
        {
            get { return fives; }
            set
            {
                fives = value;

                NotifyOfPropertyChange(() => Fives);
            }
        }



        private int sixes;
        public int Sixes
        {
            get { return sixes; }
            set
            {
                sixes = value;

                NotifyOfPropertyChange(() => Sixes);
            }
        }

        private int sum;
        public int Sum
        {
            get { return sum; }
            set
            {
                sum = value;

                NotifyOfPropertyChange(() => Sum);
            }
        }


        private int bonus;
        public int Bonus
        {
            get { return bonus; }
            set
            {
                bonus = value;

                NotifyOfPropertyChange(() => Bonus);
            }
        }



        private int pair;
        public int Pair
        {
            get { return pair; }
            set
            {
                pair = value;

                NotifyOfPropertyChange(() => Pair);
            }
        }
        private int twoPairs;
        public int TwoPairs
        {
            get { return twoPairs; }
            set
            {
                twoPairs = value;

                NotifyOfPropertyChange(() => TwoPairs);
            }
        }
        private int threeOfAKind;
        public int ThreeOfAKind
        {
            get { return threeOfAKind; }
            set
            {
                threeOfAKind = value;

                NotifyOfPropertyChange(() => ThreeOfAKind);
            }
        }
        private int fourOfAKind;
        public int FourOfAKind
        {
            get { return fourOfAKind; }
            set
            {
                fourOfAKind = value;

                NotifyOfPropertyChange(() => FourOfAKind);
            }
        }
        private int smallStraight;
        public int SmallStraight
        {
            get { return smallStraight; }
            set
            {
                smallStraight = value;

                NotifyOfPropertyChange(() => SmallStraight);
            }
        }
        private int largeStraight;
        public int LargeStraight
        {
            get { return largeStraight; }
            set
            {
                largeStraight = value;

                NotifyOfPropertyChange(() => LargeStraight);
            }
        }
        private int fullHouse;
        public int FullHouse
        {
            get { return fullHouse; }
            set
            {
                fullHouse = value;

                NotifyOfPropertyChange(() => FullHouse);
            }
        }
        private int chance;
        public int Chance
        {
            get { return chance; }
            set
            {
                chance = value;

                NotifyOfPropertyChange(() => Chance);
            }
        }
        private int yatzy;
        public int Yatzy
        {
            get { return yatzy; }
            set
            {
                yatzy = value;

                NotifyOfPropertyChange(() => Yatzy);
            }
        }
        private int total;
        public int Total
        {
            get { return total; }
            set
            {
                total = value;

                NotifyOfPropertyChange(() => Total);
            }
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
        private int foursprop=-1;
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
        private int fivesprop=-1;
        public int PropFives
        {
            get { return fivesprop; }
            set
            {
                fivesprop = value; isfivesprop = true;

                NotifyOfPropertyChange(() => PropFives);
            }
        }
        public bool Issixesprop { get { return sixesprop != -1; } }
        private bool issixesprop;
        private int sixesprop=-1;
        public int PropSixes
        {
            get { return sixesprop; }
            set
            {
                sixesprop = value; issixesprop = true;

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
        private int pairprop;
        public int PropPair
        {
            get { return pairprop; }
            set
            {
                pairprop = value;

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
                twoPairsprop = value;

                NotifyOfPropertyChange(() => PropTwoPairs);
            }
        }
        public bool IsthreeOfAKindprop;
        private int threeOfAKindprop;
        public int PropThreeOfAKind
        {
            get { return threeOfAKindprop; }
            set
            {
                threeOfAKindprop = value;

                NotifyOfPropertyChange(() => PropThreeOfAKind);
            }
        }
        public bool IsfourOfAKindprop;
        private int fourOfAKindprop;
        public int PropFourOfAKind
        {
            get { return fourOfAKindprop; }
            set
            {
                fourOfAKindprop = value;

                NotifyOfPropertyChange(() => PropFourOfAKind);
            }
        }
        public bool IssmallStraightprop;
        private int smallStraightprop;
        public int SmallStraightprop
        {
            get { return smallStraightprop; }
            set
            {
                smallStraightprop = value;

                NotifyOfPropertyChange(() => SmallStraightprop);
            }
        }
        public bool IsslargeStraightprop;
        private int largeStraightprop;
        public int PropLargeStraight
        {
            get { return largeStraightprop; }
            set
            {
                largeStraightprop = value;

                NotifyOfPropertyChange(() => PropLargeStraight);
            }
        }
        public bool IsfullHouseprop;
        private int fullHouseprop;
        public int PropFullHouse
        {
            get { return fullHouseprop; }
            set
            {
                fullHouseprop = value;

                NotifyOfPropertyChange(() => PropFullHouse);
            }
        }

        public bool Ischanceprop;
        private int chanceprop;
        public int PropChance
        {
            get { return chanceprop; }
            set
            {
                chanceprop = value;

                NotifyOfPropertyChange(() => PropChance);
            }
        }
        public bool Issyatzyprop;
        private int yatzyprop;
        public int PropYatzy
        {
            get { return yatzyprop; }
            set
            {
                yatzyprop = value;

                NotifyOfPropertyChange(() => PropYatzy);
            }
        }
        public bool Istotalprop;
        private int totalprop;
        public int PropTotal
        {
            get { return totalprop; }
            set
            {
                totalprop = value;

                NotifyOfPropertyChange(() => PropTotal);
            }
        }
    }

}
