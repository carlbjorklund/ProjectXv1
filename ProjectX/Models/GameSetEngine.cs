using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Models
{
    public class GameSetEngine:Screen
    {
        private int playerRoundCount=3;
        public int PlayerRoundCount
        {
            get
            {
                return playerRoundCount;

            }
            set
            {
                playerRoundCount = value;
                NotifyOfPropertyChange(() => Game_ID);


            }
        }
        private int gameID;
        public int Game_ID
        {
            get
            {
                return gameID;

            }
            set
            {
                gameID = value;
                NotifyOfPropertyChange(() => Game_ID);


            }
        }
        private DateTime _started_At;
        public DateTime Started_At
        {
            get
            {
                return _started_At;

            }
            set
            {
                _started_At = value;
                NotifyOfPropertyChange(() => Started_At);


            }
        }
        private DateTime _endedAt;
        public DateTime EndedAt
        {
            get
            {
                return _endedAt;

            }
            set
            {
                _endedAt = value;
                NotifyOfPropertyChange(() => EndedAt);


            }
        }

        private string gameName;
        public string GameName
        {
            get
            {
                return gameName;

            }
            set
            {
                gameName = value;
                NotifyOfPropertyChange(() => GameName);


            }
        }

        public int _GameType_Id { get; set; }
       
        public enum GameTypeEnum { Classic, Restricted }
        public enum GamteTypeEnum { getSetUp, InGame, GameOver }

        public List<Player> Players;
        public DicePanel DicePanel;
     
       
        public GameSetEngine()
        {
           DicePanel = new DicePanel();
           Players = new List<Player>();
        }

    }
}

