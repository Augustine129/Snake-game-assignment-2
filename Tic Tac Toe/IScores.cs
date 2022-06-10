namespace Tic_Tac_Toe
{
    public interface IScores
    {
        // This interface is used to create Goals that can be achieved depending on certain criteria.
        // The GoalReached() method returns a boolean value that determines if the goal has been reached.

        bool GoalScored();
    }
}
