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

using HyperTicTacToe_Library;

namespace HyperTicTacToe
{
    /// <summary>
    /// Interaction logic for Grid_9.xaml
    /// </summary>
    public partial class Grid_9 : Page
    {
        Game Game = new Game();
        bool gameInProgress = true;

        int buttonCount = 0;
        Button[] buttonList = null;

        readonly int buttonSize = 100;
        readonly FontFamily buttonFont = new FontFamily("Corbel");
        readonly int buttonFontSize = 60;
        readonly Brush buttonColor_inactive = Brushes.NavajoWhite;
        readonly Brush buttonColor_X = Brushes.BlueViolet;
        readonly Brush buttonColor_O = Brushes.OrangeRed;

        public int languageID;
        public string language;

        bool simulateOpponent;

        int cellNumber;

        /// <summary>
        /// Creates a number of of empty Buttons horizontally and vertically equal to declared Grid Size, then starts the game in the library.
        /// </summary>
        /// <param name="gridSize">Integer value of target Grid Size.</param>
        public void CreateButtons(int gridSize)
        {
            cellNumber = (gridSize * gridSize);

            buttonList = new Button[cellNumber];

            for (int i = 0; i < gridSize; i++)
            for (int j = 0; j < gridSize; j++)
            {
                Button gameButton = new Button();

                gameButton.Width = buttonSize;
                gameButton.Height = buttonSize;
                gameButton.Click += GridElement_Click;
                gameButton.Tag = buttonCount;
                buttonCount++;

                Grid.SetRow(gameButton, i);
                Grid.SetColumn(gameButton, j);

                Grid_GameButtons.Children.Add(gameButton);

                buttonList[(i * gridSize) + j] = gameButton;
            }

            Grid.SetRow(GameResult, gridSize);
            Grid.SetRow(Return, gridSize);
            Grid.SetColumn(Return, gridSize - 1);

            Game.Start_Game(gridSize);
        }

        /// <summary>
        /// Changes window size to match board size with offsets. Based on Grid Size.
        /// </summary>
        /// <param name="gridSize">Integer value of game's current Grid Size.</param>
        void Window_Set_Size(int gridSize)
        {
            int buttonOffset = 20;
            int buttonSpacing = buttonSize + 20;

            int windowSize = buttonOffset + (gridSize * buttonSpacing);

            int heightOffset = 150;

            this.WindowWidth = windowSize;
            this.WindowHeight = windowSize + heightOffset;
        }

        /// <summary>
        /// Initializes the interface by creating buttons and setting language for currently visible text.
        /// </summary>
        /// <param name="gridSize">Integer value of target Grid Size.</param>
        /// <param name="_languageID">Integer ID value of currently used language.</param>
        public Grid_9(int gridSize, int _languageID, bool _simulateOpponent)
        {
            InitializeComponent();
            CreateButtons(gridSize);

            languageID = _languageID;
            simulateOpponent = _simulateOpponent;

            GameResult.Visibility = Visibility.Hidden;

            Window_Set_Size(gridSize);

            string text_return;

            switch (languageID)
            {
                case 0:
                default:
                    text_return = "Return";
                    break;

                case 1:
                    text_return = "Powrót";
                    break;
            }

            Return.Content = text_return;
        }

        /// <summary>
        /// Changes the current page to Home Page, allowing the player to essentially restart the application's cycle.
        /// </summary>
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage(languageID);
            homepage.language = language;
            this.NavigationService.Navigate(homepage);
        }

        /// <summary>
        /// Changes button style (such as font or coloring) after they're clicked to pre-configured style.
        /// </summary>
        /// <param name="button">Button to change.</param>
        void Button_Style_Clicked(Button button)
        {
            button.FontSize = buttonFontSize;
            button.FontFamily = buttonFont;
            button.Background = buttonColor_inactive;

            switch (button.Content)
            {
                case "X":
                default:
                    button.Foreground = buttonColor_X;
                break;

                case "O":
                    button.Foreground = buttonColor_O;
                break;
            }
        }

        /// <summary>
        /// Changes button Tag into integer, so it can be handled by arrays and such.
        /// </summary>
        /// <param name="button">Button object to get ID of.</param>
        /// <returns>Button Tag as integer.</returns>
        int Button_Get_ID(Button button)
        {
            return Int32.Parse(button.Tag.ToString());
        }

        /// <summary>
        /// Allows single-player gameplay by inputting computer's answer into unoccupied cell and locking it, like with player input.
        /// </summary>
        void ComputerOpponent_Select_Button()
        {
            Random computerAnswer = new Random();

            while(true)
            {
                int computerCellInput = computerAnswer.Next(cellNumber);

                if (Game.playerChoices[computerCellInput] == 0)
                {
                    Button computerButton = buttonList[computerCellInput];

                    computerButton.Content = Game.Button_Apply(Button_Get_ID(computerButton), true);
                    Button_Style_Clicked(computerButton);

                    break;
                }
            }
        }

        /// <summary>
        /// Calls the library to save new game data and then check if game ended. Displays message to play about it if it happened.
        /// </summary>
        public void GridElement_Click(object sender, System.EventArgs e)
        {
            var gameButton = sender as Button;

            if ((gameButton.Content == null) && (gameInProgress))
            {
                gameButton.Content = Game.Button_Apply(Button_Get_ID(gameButton), true);

                Button_Style_Clicked(gameButton);

                if ((Game.CheckWinner() == -1) && simulateOpponent)
                {
                    ComputerOpponent_Select_Button();
                }

                int winner = Game.CheckWinner();

                string text_gameOver;
                string text_win;
                string text_draw;

                switch(language)
                {
                    case "en_US":
                    default:
                        text_gameOver = "GAME OVER! ";
                        text_win = "The winner is: ";
                        text_draw = "It's a draw!";
                    break;

                    case "pl_PL":
                        text_gameOver = "KONIEC GRY! ";
                        text_win = "Zwycięzca to: ";
                        text_draw = "Remis!";
                    break;
                }

                if (winner > 0)
                {
                    GameResult.Content = text_gameOver + "\n" + text_win + (winner == 1 ? "X" : "O");
                }
                else if (winner == 0)
                {
                    GameResult.Content = text_gameOver + "\n" + text_draw;
                }

                if (winner != -1)
                {
                    gameInProgress = false;
                    GameResult.Visibility = Visibility.Visible;
                }
            }
        }

    }
}
