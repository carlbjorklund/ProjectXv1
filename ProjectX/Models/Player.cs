using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class Player
    {

        private string _name;
        private int _playerId;
        private string _nickname;
        
        public ScoreCardProp scoreCardProp;
        private ScoreCard scoreCard;

        internal ScoreCard ScoreCard { get => scoreCard; set => scoreCard = value; }
    }
}
