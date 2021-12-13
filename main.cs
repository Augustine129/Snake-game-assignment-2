using System;

 //List of things I need to do
    // Provide instroctions of the game
    //Greeting
    //Displayer player 1 is X and Player 2 is of
    //Dsplay which turn is it to play the game
    //Display a game board
    //the game will have 3 rows and 3 columns
    //As the player places markers on the game  I need to update the table to notify which players has a turn
    //After each turn judge there is a winner
    // I there is no winner the player needs to keep playing
    //If all markers are placed and there is no winner and its a draw the game should stop
    // If we have a winner then the game should stop

class Program {
  
  static void Main (string[] args) {

    int playerNum = -1;
    string[] gameGrid = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
    int gameScores = 0;

    do
    {
      Console.Clear();
      playerNum = NextPlayer(playerNum);
      
      GameInstruction(playerNum);
      DisplayGameBoard(gameGrid);

      GameLogic(gameGrid, playerNum);
      gameScores = CheckWhoWon(gameGrid);
    
    }while (gameScores.Equals(0));

    Console.Clear();
    GameInstruction(playerNum);
    DisplayGameBoard(gameGrid);
    

    if (gameScores.Equals(1))
    {
      Console.WriteLine($"Well Done Player {playerNum} you won this game ");
    }

    if(gameScores.Equals(2))
    {
      Console.WriteLine($"Unfortunatley its a drwaw :(");

    }

  }

  private static int CheckWhoWon(string[] gameGrid) 
  {
    if(CheckGameWinner(gameGrid))
    {
      return 1;
    }

    if(CheckGameDraw(gameGrid))
    {
      return 2;
    }
    return 0;
    
  }

   private static bool CheckGameDraw(string[] gameGrid)
    {
       return gameGrid[0] != "1" &&
              gameGrid[1] != "2" &&
              gameGrid[2] != "3" &&
              gameGrid[3] != "4" &&
              gameGrid[4] != "5" &&
              gameGrid[5] != "6" &&
              gameGrid[6] != "7" &&
              gameGrid[7] != "8" &&
              gameGrid[8] != "9";
    }

    private static bool CheckGameWinner(string[] gameGrid)
    {
    if (CheckIfGridTheSame(gameGrid, 0, 1, 2))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 3, 4, 5))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 6, 7, 8))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 0, 3, 6))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 1, 4, 7))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 2, 5, 8))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 0, 4, 8))
    {
        return true;
    }

    if (CheckIfGridTheSame(gameGrid, 2, 4, 6))
    {
        return true;
    }

    return false;
}

  private static bool CheckIfGridTheSame(string[] testGameGrid, int p1, int p2, int p3) 
  {
     return testGameGrid[p1].Equals(testGameGrid[p2]) &&testGameGrid[p2].Equals(testGameGrid[p3]);
  }

  static void GameInstruction( int PlayerTurn)
  {
    //Provide instroctions of the game
    //Greeting

    Console.WriteLine("Welcome to Augustine Tic Tac Toe Game !!");

    //Displayer player 1 is X and Player 2 is of
    Console.WriteLine("Player 1: X");
    Console.WriteLine("Player 2: O");


    //Dsplay which turn is it to play the game
    //Tell the user to enter a number between 1 and 9
    Console.WriteLine($"Player {PlayerTurn} please select 1 throught 9 from the game board ");

  }

  static void DisplayGameBoard(string[] gameGrid) 
  {
    //Display the game board
    Console.WriteLine($"{gameGrid[0]} | {gameGrid[1]} | {gameGrid[2]}");
    Console.WriteLine(" ---+---+--- ");
    Console.WriteLine($"{gameGrid[3]} | {gameGrid[4]} | {gameGrid[5]}");
    Console.WriteLine(" ---+---+--- ");
    Console.WriteLine($"{gameGrid[6]} | {gameGrid[7]} | {gameGrid[8]}");

  }

  static void GameLogic(string[] gameGrid, int playerNum)
  {
    bool correctValue = true;


    do {
      string playerInput = Console.ReadLine();

    if(!string.IsNullOrEmpty(playerInput) &&
    (playerInput.Equals("1") ||
    playerInput.Equals("2") ||
    playerInput.Equals("3") ||
    playerInput.Equals("4") ||
    playerInput.Equals("5") ||
    playerInput.Equals("6") ||
    playerInput.Equals("7") ||
    playerInput.Equals("9") ||
    playerInput.Equals("9"))) 
    
    {

      int.TryParse(playerInput, out var displayGameGrid);

      string currentGrid = gameGrid[displayGameGrid - 1];

      if(currentGrid.Equals("X") || currentGrid.Equals("O"))
      {
        Console.WriteLine("Please enter the correct value");
      }
      else
      {
        gameGrid[displayGameGrid - 1 ] = DisplayerPlayerGrid(playerNum);
        correctValue = false;
      }

    }
    else
    {
      Console.WriteLine("Invalid value");
    }

    } while (correctValue);
    
    static string DisplayerPlayerGrid(int players)
    {
      if(players % 2 == 0)
      {
        return "O";
      }
      return "X";
    }
  }

  static int NextPlayer(int players) 
  {
    if (players.Equals(1))
    {
      return 2;
    }
      return 1;
  }
}


