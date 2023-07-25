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
using System.Windows.Shapes;

namespace PenteGame
{
    /// <summary>
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : Window
    {
        public static String playerTurn = GlobalVariables.playerOne.Name;
        public Board()
        {
            InitializeComponent();
        }

        private void MainMenu(object sender, RoutedEventArgs e)
        {
            
            MainWindow menu = new MainWindow();
            this.Close();
            menu.Show();
        }

        private void PlacePiece(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (playerTurn == GlobalVariables.playerOne.Name)
            {
                //make the image on the button clicked white

            }else if (playerTurn == GlobalVariables.playerTwo.Name)
            {
                //make the image on the button clicked black
            }

            //making the image seen for the button but they can't click on this button again
            button.Visibility = Visibility.Visible;
            button.IsEnabled = false;

            //save method to something
            IsMoveValid();
        }

        public bool IsMoveValid()
        {
            //check direction for this button move
            return true;
        }
    }
}
