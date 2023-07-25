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

namespace PenteGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
   
            InitializeComponent();
        }

        private void OpenBoard(object sender, RoutedEventArgs e)
        {


            if (txtplayerOneName.Text.ToString() == null || txtplayerOneName.Text.ToString() == "" || txtplayerTwoName.Text.ToString() == null || txtplayerTwoName.Text.ToString() == "")
            {
                txtWarning.Content = "Please fill in all fields";
            }
            else
            {

                GlobalVariables.playerOne = new Player(txtplayerOneName.Text);
                GlobalVariables.playerTwo = new Player(txtplayerTwoName.Text);

                this.Hide();
                Board board = new Board();
                board.Show();
            }
        }
    }
}
