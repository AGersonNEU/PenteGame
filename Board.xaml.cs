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
            //J10 is center of Board
            Button A19 = (Button)BoardOfButtons.FindName("A19");
            A19.Opacity = 0;
            A19.IsEnabled = true;

            Button A18 = (Button)BoardOfButtons.FindName("A18");
            A18.Opacity = 0;
            A18.IsEnabled = true;

            Button A17 = (Button)BoardOfButtons.FindName("A17");
            A17.Opacity = 0;
            A17.IsEnabled = true;

            Button A16 = (Button)BoardOfButtons.FindName("A16");
            A16.Opacity = 0;
            A16.IsEnabled = true;

            Button A15 = (Button)BoardOfButtons.FindName("A15");
            A15.Opacity = 0;
            A15.IsEnabled = true;

            Button A14 = (Button)BoardOfButtons.FindName("A14");
            A14.Opacity = 0;
            A14.IsEnabled = true;

            Button A13 = (Button)BoardOfButtons.FindName("A13");
            A13.Opacity = 0;
            A13.IsEnabled = true;

            Button A12 = (Button)BoardOfButtons.FindName("A12");
            A12.Opacity = 0;
            A12.IsEnabled = true;
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
            button.Opacity = 100;
            if (playerTurn == GlobalVariables.playerOne.Name)
            {
                //make the image on the button clicked white
                
                button.Background = Brushes.Black;
                playerTurn = GlobalVariables.playerOne.Name;

            }else if (playerTurn == GlobalVariables.playerTwo.Name)
            {
                //make the image on the button clicked black
               button.Background = Brushes.White;
                playerTurn = GlobalVariables.playerOne.Name;
            }

            //making the image seen for the button but they can't click on this button again
            
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
