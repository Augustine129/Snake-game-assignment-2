# Tic-Tac-Toe built in C# assignment 2

Tic-Tac-Toe is a very simple game for two players. So only two players can play at a time. This game is also known as Noughts and Crosses or Xs and Os game. One player plays with X and the other player plays with O. In this game, we have a board that consists of a 3X3 grid.

## 1. challenge outline (academic standard: pass level detail: section required for pass) - 10%.

#### a. *Summary and overview of the problem, overall proposed solution. 
- This is a clone of the classic tic tac toe game. 
- At the beginning, the players' characters are shown: player 1 is X and player 2 is O. 
- Then it shows whose turn it is. 
- Then the user is instructed to enter a number between 1 and 9, which the player can use to keep track of his position. 
- The game has 3 rows and 3 columns, numbered from 1 to 9. 
- When the player places markers on the game board, the board is updated and the player is informed about his move. 
- If there is a winner, a message is displayed which player has won. - If all markers are placed and there is no winner, it is a draw and the game ends. - If there is no winner, the game continues.

#### b. *UML diagram illustrating the original overall solution. 

https://replit.com/@Augustine129/Tic-tac-toe-game#Screenshot%202022-01-08%20at%2020.56.20.png

## Original work plan, overall concept, development strategy, and quality approach:

My work plan is to break down the overall problem into smaller tasks, namely;

- Display the position of player 1.
- Display of player 2's position.
- Display of the 3 x 3 grid.

Each task will be noted on my Kanban board and worked on individually, so I will take an agile approach to development. I will self-assess the quality of the code I have written through regular code reviews. This will help me identify errors in my code. Throughout the development process, I will validate all user input and internal processes.

I have also decided to use version control. For this, I have used git. I created branches and PRs and merged the code into main.

I went through the requirements of the task and created a Kanban board for it. As shown in the following diagram

https://replit.com/@Augustine129/Tic-tac-toe-game#Screenshot%202022-01-08%20at%2021.23.03.png

An important challenge before the design was to indicate the winner in the game. The winner function should accept a board as input and return the winner of the board if there is one. If player 1 won the game, the function should return this result.

I also learned about code smells and code refactoring. An example of code refactoring would be to use switch statements instead of if statements in line 48, because switch statements work faster and are usually more efficient. 
The switch statement works better than multiple if statements when you enter input directly without any condition checking in the statements. Switch statements work well when you want to improve the readability of the code and there are many alternatives available.


## Thoughtful statement 

One way to improve the development of this project would be to include an AI feature, such as player vs. computer. During the early stages of testing, more bugs occurred with this feature. One bug in particular was that the wrong 'winner' was displayed in the game. Consequently, the project would be less credible if it included this feature.

For an OOP-based project, encapsulation was the best feature to include. However, there are three other principles, including abstraction, inheritance, and polymorphism, that would make this a pure OOP project.