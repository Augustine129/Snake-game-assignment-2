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
  
  public static void Main (string[] args) {

    var playerNum = -1;

    do
    {
      playerNum = NextPlayer(playerNum);
      
      GameInstruction(playerNum);
      DisplayGameBoard();

    string playerInput = Console.ReadLine();

    Console.Clear();
    
    }while (true);
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

  static void DisplayGameBoard() 
  {
    //Display the game board
    Console.WriteLine(" 1 | 2 | 3 ");
    Console.WriteLine(" ---+---+--- ");
    Console.WriteLine(" 4 | 5 | 6 ");
    Console.WriteLine(" ---+---+--- ");
    Console.WriteLine(" 7 | 8 | 9 ");

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


