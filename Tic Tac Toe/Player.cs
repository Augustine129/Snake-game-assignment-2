using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Player
    {
        // The criteria that need to be fulfilled for the player to win the match.
        private readonly CheckGameWinner checkWinner;

        // The criteria that need to be fulfilled for the match to end as a draw.
        private readonly CheckGameDraw checkGameDraw;

        // A random reference used when the player plays as the computer.
        private readonly Random random;
        
        // The number of wins achieved from this player.
        public int Score { get; private set; }
        
        // The mark of the player in the board, can be X or O.
        private string GameΜark { get; set; }
        
        // The display name of the player.
        public string PlayersΝame { get; private set; }
        
        // The color of the player's mark in the board.
        public Color PlayerColour { get; private set; }
        
        // A 2-dimensional array that holds all moves made by this player for a specific match.
        private bool[,] Moves { get; set; }

        // The X coordinate of the last move for a match.
        private int PlayerLastMoveX { get; set; }

        // The Y coordinate of the last move for a specific match.
        private int PlayerLastMoveY { get; set; }
        
        // Whether this player is controlled by the computer.
        public bool ComputerPlayer { get; private set; }

        public Player(string playerName, Color playerColour, string gameMark, bool computerPlayer = false)
        {
            // Initialize and create new objects.
            
            checkWinner = new CheckGameWinner();
            checkGameDraw = new CheckGameDraw();
            random = new Random();
            PlayerColour = playerColour;
            PlayersΝame = playerName;
            PlayerLastMoveX = -1;
            PlayerLastMoveY = -1;
            ComputerPlayer = computerPlayer;
            Moves = new bool[5, 5];
            GameΜark = gameMark;
        }
        
        public void ResetGame()
        {
            // Reset the moves array and the X, Y coordinates of the last move.
            Moves = new bool[MainForm.X, MainForm.Y];
            PlayerLastMoveX = -1;
            PlayerLastMoveY = -1;
        }

        public PlayersMoveState MakeMove(Button button, int x, int y)
        {
            // Makes a move on the board.

            // Change the color and the text of the button.
            button.ForeColor = PlayerColour;
            button.Text = GameΜark;

            // Track the move on the board.
            PlayerLastMoveX = x;
            PlayerLastMoveY = y;
            Moves[x, y] = true;

            // Increase the global number of moves for this match.
            MainForm.GameMoves++;

            // Update the win goal criteria to take into account this specific move.
            checkWinner.ChangeCurrentMove(Moves, x, y);

            // Check if the move can result to a win, draw or just continue the match.
            if (checkWinner.GoalScored())
                return PlayersMoveState.Win;
            if (checkGameDraw.GoalScored())
                return PlayersMoveState.Draw;
            return PlayersMoveState.Continues;
        }

        public void AddWin()
        {
            // Increment the score counter.
            Score++;
        }

        public Button SelectButton(Player otherPlayer, Button[,] buttons)
        {
            // The X and Y coordinates of the button that will be selected.
            int buttonX, buttonY;

            // The X and Y coordinates of the last move made by the other player.
            var lastX = otherPlayer.PlayerLastMoveX;
            var lastY = otherPlayer.PlayerLastMoveY;

            // A 2-dimensional array that holds all nearby X, Y coordinates
            // relative to the last move made by the opponent.
            //
            // Basically, we're retrieving all positions marked with asterisks below:
            //
            // *   *   *
            // *   ~   *
            // *   *   *

            // We are searching for a nearby slot to block our opponent.

            int[,] options =
            {
                { lastX, lastY + 1 },
                { lastX + 1, lastY },
                { lastX, lastY - 1 },
                { lastX - 1, lastY },
                { lastX + 1, lastY + 1 },
                { lastX - 1, lastY - 1 },
                { lastX + 1, lastY - 1 },
                { lastX - 1, lastY + 1 },
            };

            // We need to loop through all of our options and find a suitable spot
            // to make our next move. If all of the positions are blocked then we are
            // surrounded and we should make random move.

            // The list of valid options, we will select a random one afterwards.
            var validOptions = new List<int[]>();

            // Loop through all elements.
            for (var i = 0; i < options.GetLength(0); i++)
            {
                // Get the X and Y coordinate of the position candidate.
                var x = options[i, 0];
                var y = options[i, 1];

                // Check if the X and Y coordinates are valid and not blocked/used.
                if (x >= 0 && y >= 0 && x != MainForm.X && y != MainForm.Y &&
                    !otherPlayer.Moves[x, y] && !Moves[x, y])
                {
                    // Add our option to the list.
                    validOptions.Add(new [] {x, y});
                }
            }

            if (lastX >= 0 && lastY >= 0 && validOptions.Count > 0)
            {
                // If the player already made his first move and we're not surrounded
                // then we can make a move relative to his last one.

                // Get a random position relative to his last move.
                var choice = validOptions[random.Next(validOptions.Count)];
                buttonX = choice[0];
                buttonY = choice[1];
            }
            else
            {
                // Otherwise if we have no valid options or the computer player is playing first
                // we will just make a random move on the board.

                do
                {
                    buttonX = random.Next(MainForm.X);
                    buttonY = random.Next(MainForm.Y);

                    // We want to make sure our random move can be actually made.
                    // The button may have already been clicked, keep searching if that's the case.
                } while (otherPlayer.Moves[buttonX, buttonY] || Moves[buttonX, buttonY]);
            }

            // Return the button that was selected.
            return buttons[buttonX, buttonY];
        }

        public override string ToString()
        {
            // Overrides the default ToString() method, returns the name of the player instead.
            return PlayersΝame;
        }
    }
}
