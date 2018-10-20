using ProjectX.Models;
using ProjectX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectX.Views
{
    /// <summary>
    /// Interaction logic for MainGameView.xaml
    /// </summary>
    public partial class MainGameView : UserControl

    {
        public GameSetEngine GameSet { get; private set; }

        public MainGameView()
        {
            InitializeComponent();

            

        }


        public void checkgametyp()
        {
            if (GameSet.GameTypeRestricted == true)
            {
                PickPair.IsEnabled = false;
                PickTwoPair.IsEnabled = false;
            }

        }

        private void Enable_Click(object sender, RoutedEventArgs e)
        {
            checkgametyp();
        }
    }
}
