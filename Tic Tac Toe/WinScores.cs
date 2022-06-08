namespace Tic_Tac_Toe
{
    public class CheckGameWinner : IScores
    {
        // This class performs a check every time the player makes a move on the board.
        // It will determine if the player has won the match.

        // The moves of the player on the board.
        private bool[,] moves;

        // The x coordinate of the player's move.
        private int x;

        // The y coordinate of the player's move.
        private int y;

        private bool CheckDiagLeft()
        {
            // Check if the player has won on the right diagonal.
            //
            // Basically we're checking these coordinates:
            // (0, 4), (1, 3), (2, 2), (3, 1), (4, 0)

            for (var i = 0; i < MainForm.X; i++)
            {
                // If the player is missing one move then it's not a win.
                if (!moves[i, (MainForm.X - 1) - i])
                    return false;
            }

            return true;
        }

        private bool CheckDiagRight()
        {
            // Check if the player has won on the right diagonal.
            //
            // Basically we're checking these coordinates:
            // (0, 0), (1, 1), (2, 2), (3, 3), (4, 4)

            for (var i = 0; i < MainForm.X; i++)
            {
                // If the player is missing one move then it's not a win.
                if (!moves[i, i])
                    return false;
            }

            return true;
        }

        private bool CheckHorizontal()
        {
            // Check if the player has won on the X axis.

            for (var i = 0; i < MainForm.Y; i++)
            {
                // If the player is missing one move then it's not a win.
                if (!moves[x, i])
                    return false;
            }

            return true;
        }

        private bool CheckVertical()
        {
            // Check if the player has won on the Y axis.

            for (var i = 0; i < MainForm.Y; i++)
            {
                // If the player is missing one move then it's not a win.
                if (!moves[i, y])
                    return false;
            }

            return true;
        }

        public bool GoalScored()
        {
            // Check if the player has won on the X/Y axis or in the left/right diagonal.
            return CheckHorizontal() || CheckVertical() ||
                CheckDiagRight() || CheckDiagLeft();
        }

        public void ChangeCurrentMove(bool[,] moves, int x, int y)
        {
            // Updates the data of the current move made by the player.

            this.moves = moves;
            this.x = x;
            this.y = y;
        }
    }
}
