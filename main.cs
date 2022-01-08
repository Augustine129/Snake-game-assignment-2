using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

 class Program
    {

        static void Main(string[] args)
        {

            var playerNum = -1;
            string[] gameGrid = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            var gameScores = 0;

            do
            {
                Console.Clear();
                playerNum = NextPlayer(playerNum);

                GameInstruction(playerNum);
                DisplayGameBoard(gameGrid);

                GameLogic(gameGrid, playerNum);
                gameScores = CheckWhoWon(gameGrid);

            } while (gameScores.Equals(0));

            Console.Clear();
            GameInstruction(playerNum);
            DisplayGameBoard(gameGrid);


            switch (gameScores)
            {
                case 1:
                    Console.WriteLine($"Well Done Player {playerNum} you won this game ");
                    break;
                case 2:
                    Console.WriteLine($"Unfortunately its a draw :(");
                    break;
            }
        }

        private static int CheckWhoWon(string[] gameGrid)
        {
            if (CheckGameWinner(gameGrid))
            {
                return 1;
            }

            return CheckGameDraw(gameGrid) ? 2 : 0;
        }

        private static bool CheckGameDraw(IReadOnlyList<string> gameGrid)
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

        private static bool CheckGameWinner(IReadOnlyList<string> gameGrid)
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

            return CheckIfGridTheSame(gameGrid, 0, 4, 8) || CheckIfGridTheSame(gameGrid, 2, 4, 6);
        }

        private static bool CheckIfGridTheSame(IReadOnlyList<string> testGameGrid, int p1, int p2, int p3)
        {
            return testGameGrid[p1].Equals(testGameGrid[p2]) && testGameGrid[p2].Equals(testGameGrid[p3]);
        }

        private static void GameInstruction(int playerTurn)
        {
            //Provide instructions of the game
            //Greeting

            Console.WriteLine("Welcome to Augustine Tic Tac Toe Game !!");

            //Display player 1 is X and Player 2 is of
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");


            //Display which turn is it to play the game
            //Tell the user to enter a number between 1 and 9
            Console.WriteLine($"Player {playerTurn} please select 1 throughout 9 from the game board ");

        }

        static void DisplayGameBoard(IReadOnlyList<string> gameGrid)
        {
            //Display the game board
            Console.WriteLine($"{gameGrid[0]} | {gameGrid[1]} | {gameGrid[2]}");
            Console.WriteLine(" ---+---+--- ");
            Console.WriteLine($"{gameGrid[3]} | {gameGrid[4]} | {gameGrid[5]}");
            Console.WriteLine(" ---+---+--- ");
            Console.WriteLine($"{gameGrid[6]} | {gameGrid[7]} | {gameGrid[8]}");

        }

        private static void GameLogic(IList<string> gameGrid, int playerNum)
        {
            var notCorrectValue = true;


            do
            {

                var playerInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(playerInput) &&
                    (playerInput.Equals("1") ||
                     playerInput.Equals("2") ||
                     playerInput.Equals("3") ||
                     playerInput.Equals("4") ||
                     playerInput.Equals("5") ||
                     playerInput.Equals("6") ||
                     playerInput.Equals("7") ||
                     playerInput.Equals("8") ||
                     playerInput.Equals("9")))

                {

                    int.TryParse(playerInput, out var displayGameGrid);

                    var currentGrid = gameGrid[displayGameGrid - 1];

                    if (currentGrid.Equals("X") || currentGrid.Equals("O"))
                    {
                        Console.WriteLine("Please enter the correct value");
                    }
                    else
                    {
                        gameGrid[displayGameGrid - 1] = DisplayPlayerGrid(playerNum);
                        notCorrectValue = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid value");
                }

            } while (notCorrectValue);

            static string DisplayPlayerGrid(int players)
            {
                return players % 2 == 0 ? "O" : "X";
            }
        }

        private static int NextPlayer(int players)
        {
            return players.Equals(1) ? 2 : 1;
        }
    }


