﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
        public void LoadMainGameWindow()
        {
            ActivateItem(new MainGameViewModel());
        }
    }
}
