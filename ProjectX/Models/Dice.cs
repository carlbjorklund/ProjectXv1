using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Caliburn.Micro;

namespace ProjectX.Models
{
    public class Dice : Screen
    {
        public Dice()
        {
        }

        private int _diceValue;
        public int DiceValue
        {
            get { return _diceValue; }
            set
            {
                _diceValue = value;
                NotifyOfPropertyChange(() => DiceValue);


            }
        }

        private bool _keep;
        public bool Keep
        {
            get { return _keep; }
            set
            {
                _keep = value;
                NotifyOfPropertyChange(() => Keep);


            }
        }

        private BitmapImage img;
        public BitmapImage Img
        {
            get { return img; }
            set
            {
                img = value;
                NotifyOfPropertyChange(() => Img);
            }
        }



    }


}
