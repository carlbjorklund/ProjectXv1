using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YatzyCarl.ViewModels;

namespace ProjectX.ViewModels
{
    public class HomeViewModel: Conductor<object>
    {
        public void LoadMainGameWindow()
        {
            ActivateItem(new MainGameViewModel());
        }
        public void LoadHelp()
        {
            ActivateItem(new HelpViewModel());
        }
        public void LoadStatistics()
        {
            ActivateItem(new StatisticsViewModel());
        }
        public void LoadHome()
        {
            ActivateItem(new HomeViewModel());
        }

    }

}
