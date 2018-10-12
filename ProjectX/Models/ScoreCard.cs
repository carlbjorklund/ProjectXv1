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
        public bool _isonesprop;
        public bool _istwosprop;
        public bool _isthreesprop;
        public bool _isfoursprop;
        public bool _isfivesprop;
        public bool _issixesprop;
        public bool _issumprop;
        public bool _isbonusprop;
        public bool _ispairprop;
        public bool _istwoPairsprop;
        public bool _isthreeOfAKindprop;
        public bool _isfourOfAKindprop;
        public bool _issmallStraightprop;
        public bool _islargeStraightprop;
        public bool _isfullHouseprop;
        public bool _ischanceprop;
        public bool _isyatzyprop;
        public bool _istotalprop;

        private int onesprop;
        public int PropOnes
        {
            get { return onesprop; }
            set
            {
                onesprop = value;

                NotifyOfPropertyChange(() => PropOnes);
            }
        }
        private int twosprop;
        public int PropTwos
        {
            get { return twosprop; }
            set
            {
                twosprop = value;

                NotifyOfPropertyChange(() => PropTwos);
            }
        }
        private int threesprop;
        public int PropThree
        {
            get { return threesprop; }
            set
            {
                threesprop = value;

                NotifyOfPropertyChange(() => PropThree);
            }
        }
        private int foursprop;
        public int PropFour
        {
            get { return foursprop; }
            set
            {
                foursprop = value;

                NotifyOfPropertyChange(() => PropFour);
            }
        }
        private int fivesprop;
        public int PropFive
        {
            get { return fivesprop; }
            set
            {
                fivesprop = value;

                NotifyOfPropertyChange(() => PropFive);
            }
        }
        private int sixesprop;
        public int PropSixes
        {
            get { return sixesprop; }
            set
            {
                sixesprop = value;

                NotifyOfPropertyChange(() => PropSixes);
            }
        }
        private int sumprop;
        public int PropSum
        {
            get { return sumprop; }
            set
            {
                sumprop = value;

                NotifyOfPropertyChange(() => PropSum);
            }
        }
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
        private int twoPairsprop;
        public int PropTwoPairs
        {
            get { return twoPairsprop; }
            set
            {
                twoPairsprop = value;

                NotifyOfPropertyChange(() => PropTwoPairs);
            }
        }
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
