using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public string language;
        public int languageID;

        /// <summary>
        /// Sets up initial language configurations, as well as window size.
        /// </summary>
        /// <param name="_languageID">Integer ID value setting the game's default value.</param>
        public HomePage(int _languageID)
        {
            InitializeComponent();
            this.languages.SelectionChanged += new SelectionChangedEventHandler(Click_Language_Change);
            languageID = _languageID;
            this.languages.SelectedIndex = languageID;
            Language_Change(languageID);

            Window_Set_Size();
        }

        /// <summary>
        /// Sets the window size to a hardcoded size.
        /// </summary>
        void Window_Set_Size()
        {
            this.WindowWidth  = 215;
            this.WindowHeight = 338;
        }

        /// <summary>
        /// Changes the page to Game Grid and gives it information about player's Grid Size/Language configuration.
        /// </summary>
		private void Start_Click (object sender, RoutedEventArgs e)
		{

        }

        private void Game_Start(bool simulateOpponent)
        {
            Grid_9 grid_9 = new Grid_9(gameMode.SelectedIndex + 3, languageID, simulateOpponent);
            grid_9.language = language;
            grid_9.languageID = languageID;
            this.NavigationService.Navigate(grid_9);
        }

        private void StartPvP_Click(object sender, RoutedEventArgs e)
        {
            Game_Start(false);
        }

        private void StartPvE_Click(object sender, RoutedEventArgs e)
        {
            Game_Start(true);
        }


        /// <summary>
        /// Properly shuts the application down without creating "ghost processes".
        /// </summary>
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        
        /// <summary>
        /// Gains information about selected language and then sets all translate-able strings to a new language if needed.
        /// </summary>
        /// <param name="targetLanguage">Integer ID value of value set by drop-down menu.</param>
        private void Language_Change(int targetLanguage)
        {
            switch(targetLanguage)
            {
                case 0:
                    language = "en_US";

                    string_Language.Content = "Language:";
                    string_mode.Content = "Grid Size:";
                    string_playGamePvP.Content = "Player vs Player";
                    string_playGamePvE.Content = "Player vs Computer";
                    string_exit.Content = "Exit";

                    languageID = 0;
                    break;

                case 1:
                    language = "pl_PL";

                    string_Language.Content = "Język:";
                    string_mode.Content = "Rozmiar Pola:";
                    string_playGamePvP.Content = "Dwóch graczy";
                    string_playGamePvE.Content = "Graj z komputerem";
                    string_exit.Content = "Wyjście";

                    languageID = 1;
                    break;
            }
        }

        /// <summary>
        /// Triggers language switch when necessary.
        /// </summary>
        private void Click_Language_Change(object sender, SelectionChangedEventArgs e)
        {
            Language_Change(this.languages.SelectedIndex);
        }
	}
}
