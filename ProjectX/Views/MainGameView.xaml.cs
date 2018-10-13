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
        GameSetEngine gameSet = new GameSetEngine();
        public Dice dice;
        


        Random r = new Random();
        public MainGameView()
        {
            InitializeComponent();
           


        }

        private void Rolldice_Click(object sender, RoutedEventArgs e)
        {
            //int value, value2, value100, value200;
            //value = r.Next(1, 7);
            //value2 = r.Next(1, 7);
            //value100 = r.Next(1, 7);
            //value200 = r.Next(1, 7);

            ////Dicepanel.Dice1.DiceValue = value200;

            ////dice.DiceValue = value200;
            //BitmapImage Img = new BitmapImage(new Uri(@"\" + dice.DiceValue.ToString() + ".png", UriKind.Relative));
            //image1.Source = Img;


        }
    }
}
