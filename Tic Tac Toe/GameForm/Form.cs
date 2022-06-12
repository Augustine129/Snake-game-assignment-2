using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        // The number of buttons in the horizontal axis.
        public const int X = 5;
        
        // The number of buttons in the vertical axis.
        public const int Y = 5;

        // The 2-dimensional array that contains all buttons in the board.
        private readonly Button[,] _buttons;

        // The two players of the game, player 2 may be a computer player.
        private Player _playerOne, _playerTwo;

        // The current player's turn.
        private Player _turn;

        // A random reference used to decide which player will play first.
        private readonly Random _random;

        // A reference to a new game form.
        private NewGameForm _newGameForm;

        // Counts the number of moves for each match.
        public static int GameMoves { get; set; }

        public MainForm()
        {
            InitializeComponent();
            
            // Initialize the 2-dimensional array of usable buttons.
            _buttons = new[,] {
                { _buttonOne, _buttonTwo, _buttonThree, _buttonFour, _buttonFive },
                { _buttonSix, _buttonSeven, _buttonEight, _buttonNine, _buttonTen },
                { _button11, _button12, _button13, _button14, _button15 },
                { _button16, _button17, _button18, _button19, _button20 },
                { _button21, _button22, _button23, _button24, _button25 },
            };

            // Create a new random object.
            _random = new Random();
        }

        private static void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $@"Game 2{Environment.NewLine}{Environment.NewLine}Augustine Osagie {Environment.NewLine}Tic tac toe{Environment.NewLine}Game",
                @"About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CheckComputerPlay()
        {
            // Check if the player is controlled by the computer.
            if (_turn.ComputerPlayer)
            {
                // If that's the case then select a button and perform a click.
                var selected = _turn.SelectButton(
                    _turn.Equals(_playerOne) ? _playerTwo : _playerOne, _buttons);

                // Click the button that was selected.
                selected.PerformClick();
            }
        }

        private void CreateGame(Player player1, Player player2)
        {
            // Assuming the users have interacted with the new game form window,
            // this method will be called when they finish setting up the players.

            // We have our two player objects passed in with all the settings from the new game form.
            _playerOne = player1;
            _playerTwo = player2;

            // Updated the score labels.
            _assignNamePlayerOne.Text = player1.PlayersΝames;
            _showScorePlayer1.Text = @"0";
            _assignNamePlayerTwo.Text = player2.PlayersΝames;
            _showScorePlayer2.Text = @"0";

            // The new game button now works as a Restart button when every match ends.
            _newGameButton.Text = @"Restart";

            // Everything is ready, start the game.
            StartGame();
        }

        private void EndGameDraw()
        {
            // Display a message box for the draw.
            MessageBox.Show(@"Its a draw!!!", @"Match");

            // Reset the current game, prepare for the next one.
            ResetGame();
        }

        private void EndGameWin()
        {
            // Display a message box for the winner.
            MessageBox.Show(_turn + @"Congratulation you won the game!", @"Match");

            // Add one to the total wins of the player.
            _turn.AddWin();

            // Update the score label of the winner.
            if (_turn == _playerOne)
                _showScorePlayer1.Text = _turn.Score.ToString();
            else
                _showScorePlayer2.Text = _turn.Score.ToString();

            // Reset the current game, prepare for the next one.
            ResetGame();
        }

        private static void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private KeyValuePair<int, int> GetCoordinates(Button button)
        {
            // Initialize x, y variables.
            int x = 0, y = 0;

            // Loop through all buttons along the X and Y axis.
            for (var i = 0; i < X; i++)
            {
                for (var j = 0; j < Y; j++)
                {
                    // If the buttons are equal then get the x and y coordinates.
                    if (!_buttons[i, j].Equals(button)) continue;
                    x = i;
                    y = j;
                    break;
                }
            }

            // Return a new key-pair object that will hold the x and y variables.
            // Basically we're returning two variables.
            return new KeyValuePair<int, int>(x, y);
        }

        private void HandleMoves(object sender, EventArgs e)
        {
            // Handles all moves for each match when a button is clicked.

            // Find which button was clicked, perform casting.
            var button = (Button)sender;

            // Get the X and Y coordinates of the button.
            var (x, y) = GetCoordinates(button);

            // If the clicked button hasn't been used before then proceed.
            if (button.Text.Length == 0)
            {
                // Register the move of the current player.
                var state = _turn.MakeMove(button, x, y);

                // Determine the result of the move.
                if (state == PlayersMoveState.Win)
                {
                    // The move formed a set of Xs or Os that resulted to a win.
                    EndGameWin();
                }
                else if (state == PlayersMoveState.Draw)
                {
                    // The move didn't result to a win and all buttons are clicked.
                    EndGameDraw();
                }
                else
                {
                    // The match still has potential and may result to a win or a draw.
                    // Switch turns and let the other player make his move.
                    SwitchTurns();
                }
            }
        }

        private bool IsNewGameFormClosed()
        {
            // Check if the new game form is null or already closed, then we can open it.
            return _newGameForm == null || _newGameForm.IsDisposed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Loop through all registered buttons and add a new click event handler.
            foreach (var button in _buttons)
            {
                // At first, all buttons are disabled until the match starts.
                button.Enabled = false;

                // Add a new event handler, HandleMoves() is the method handling this event.
                button.Click += HandleMoves;
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // The new button should open the new game form if there are no players.
            if (_playerOne == null || _playerTwo == null)
            {
                // Prevent the game form from opening more than once.
                if (IsNewGameFormClosed())
                    OpenNewGameForm();
            }
            // Otherwise we already have two players so we just start the game.
            // At this point the first match already finished and we are ready to start a new one.
            else
            {
                StartGame();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure the game form isn't already opened.
            if (IsNewGameFormClosed())
            {
                // If we already have two players created, just reset the game.
                // For example, if a match is already started we will end it gracefully.
                if (_playerOne != null && _playerTwo != null)
                    ResetGame();

                // Open the new game form to create new players.
                OpenNewGameForm();
            }
        }

        private void OpenNewGameForm()
        {
            // Create a new game form object and show the form.
            // The new game form requires a game creation handler as a callback, we use delegates.
            _newGameForm = new NewGameForm(CreateGame);
            _newGameForm.Show();
        }

        private void RandomTurn()
        {
            // Generate a random number from 0 to 1, basically true/false.
            var rand = _random.Next(0, 2);

            // Choose who is going to play next.
            if (rand == 0)
                SetTurnPlayer1();
            else
                SetTurnPlayer2();

            // Check if the player is being controlled by the computer,
            // if that's the case then make a move.
            CheckComputerPlay();
        }

        private void ResetGame()
        {
            // This method cleans everything up after a match finishes.
            // All player settings are preserved, this will only prepare the game for a new match.

            // Reset the number of moves for this match.
            GameMoves = 0;

            // Reset each player.
            _playerOne.ResetGame();
            _playerTwo.ResetGame();

            // Reset the player labels.
            ResetNameLabels();

            // Remove the text from all buttons and disable them.
            foreach (var button in _buttons)
            {
                button.Text = "";
                button.Enabled = false;
            }

            // Make the Restart button visible again.
            _newGameButton.Visible = true;
            _newGameButton.Focus();
        }

        private void ResetNameLabel1()
        {
            // Reset the name label of player 1 back to it's original state.
            _assignNamePlayerOne.Font = new Font(_assignNamePlayerOne.Font, FontStyle.Regular);
            _assignNamePlayerOne.ForeColor = Color.Black;
        }

        private void ResetNameLabel2()
        {
            // Reset the name label of player 2 back to it's original state.
            _assignNamePlayerTwo.Font = new Font(_assignNamePlayerTwo.Font, FontStyle.Regular);
            _assignNamePlayerTwo.ForeColor = Color.Black;
        }

        private void ResetNameLabels()
        {
            // Reset all name labels back to their original state.
            ResetNameLabel1();
            ResetNameLabel2();
        }

        private void SetTurnPlayer1()
        {
            // Player 1 is now playing.
            _turn = _playerOne;

            // Change the name label of player 1 to indicate his turn.
            _assignNamePlayerOne.Font = new Font(_assignNamePlayerOne.Font, FontStyle.Bold);
            _assignNamePlayerOne.ForeColor = _turn.PlayerColour;

            // Reset the name label of player 2.
            ResetNameLabel2();
        }

        private void SetTurnPlayer2()
        {
            // Player 2 is now playing.
            _turn = _playerTwo;

            // Change the name label of player 2 to indicate his turn.
            _assignNamePlayerTwo.Font = new Font(_assignNamePlayerTwo.Font, FontStyle.Bold);
            _assignNamePlayerTwo.ForeColor = _turn.PlayerColour;

            // Reset the name label of player 1.
            ResetNameLabel1();
        }

        private void StartGame()
        {
            // Enable all buttons so they can be clicked.
            foreach (var button in _buttons)
            {
                button.Enabled = true;
            }

            // The new game button is no longer visible since the match has started.
            _newGameButton.Visible = false;

            // Choose randomly one of the two players for the first turn.
            RandomTurn();
        }

        private void SwitchTurns()
        {
            // Choose who is going to play next.
            // If this was player 1's turn, then player 2 is going to play next.
            // If this was player 2's turn, then player 1 is going to play next.
            if (_turn.Equals(_playerOne))
                SetTurnPlayer2();
            else
                SetTurnPlayer1();

            // Check if the player is being controlled by the computer,
            // if that's the case then make a move.
            CheckComputerPlay();
        }
    }
}
