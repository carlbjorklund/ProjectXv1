using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectX.Models.ScoreCard;

namespace ProjectX.Models
{
    public class Player:Screen
    {
        private int _rolles=3;
        public int Rolles
        {
            get { return _rolles; }
            set
            {
                _rolles = value;
                NotifyOfPropertyChange(() => Rolles);
            }

        }

        private string _name;
        public string Name
        {
                get { return _name; }
                set
                {
                _name = value;
                NotifyOfPropertyChange(() => Name);
                }
            
        }
        private int _playerId;
        public int PlayerID
        {
            get { return _playerId; }
            set
            {
                _playerId = value;
                NotifyOfPropertyChange(() => PlayerID);
            }

        }

        private string _nickname;
        public string NickName
        {
            get { return _nickname; }
            set
            {
                _nickname = value;
                NotifyOfPropertyChange(() => NickName);
            }

        }
        public ScoreCard ScoreCard;
        public ScoreCardProp ScoreCardProp;

        public Player()
        {
            ScoreCard = new ScoreCard();
            ScoreCardProp = new ScoreCardProp();
        }


    }
}
