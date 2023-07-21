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

namespace HyperTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        /// <summary>
        /// Configuration page. Automatically changes into Home Page as soon as the game is booted.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            HomePage homepage = new HomePage(0);
            homepage.language = "en_US";
            this.NavigationService.Navigate(homepage);
        }
    }
}
