# Demo video can also be found in youtube
 https://youtu.be/oSLPzrZ6Spg

## Tic-Tac-Toe built in C# Assigment 2

Tic-Tac-Toe is a very simple game for two players. So only two players can play at a time. This game is also known as Noughts and Crosses or Xs and Os game.

## 1. challenge outline (academic standard: pass level detail: section required for pass) - 10%.

#### a. *Summary and overview of the problem, general proposed solution. 

- This is a clone of the classic tic-tac-toe game. 
- At the beginning the user is greeted with the game setup form to select the blue or red player. 
- Then the game begins in a five by five grid of clickable elements, similar to traditional tic-tac-toe.
- The user's task is to beat the  computer player configured to make random moves by selecting empty spaces on the board.
- As the game continues , we verify that our victory conditions are met by checking diagonally left, diagonally right, horizontally, and vertically.
- If there is a winner, a message will be displayed indicating which player has won. 
- If all markers have been placed and there is no winner, the game is tied and ends.

#### b. *UML diagram illustrating the original overall solution. 

https://replit.com/@Augustine129/Tic-tac-toe-game#Screenshot%202022-01-08%20at%2020.56.20.png

## Original work plan, overall concept, development strategy, and quality approach:

My work plan is to break down the overall problem into smaller tasks, namely;

- Menu (How do you play the game and which player go first)
- Displaying the position of player 1.
- Display of player 2's position.
- Display of the 5 x 5 grid.
- Check if the position of the grid is valid or not

Before submitting my Tic Tac toe game, I worked locally on Rider to clean my code and resolve issues and fix bugs. This helped with the distribution of the 3x3 grid, I wanted
to make sure the grid was efficiently sized and spaced.

## Analysis and decomposition of the overall problem into key ‘epic’ style tasks:

My approach on creating this system will be break down down the epic, into smaller stories that can be worked on

https://replit.com/@Augustine129/Tic-tac-toe-game#Screenshot%202022-01-08%20at%2021.23.03.png

An important challenge before the design was to determine who the winner of the game was.
The winner function should accept a board as input and return the winner of the board if there is one.
If player 1 or player 2 won the game, the function should return that result.76yu

## Analysis with embedded examples of key code refactoring, reuse, smells:
I also learned about code smells and refactoring. An example of code refactoring would be to have more classes that do certain things, which provides an 
easy way to keep the data elements and methods together in one place, which helps organize the program better.
Using classes also provides another functionality of this object-oriented programming paradigm, which is inheritance.
Classes also help to override any standard operator.

##Implementation and effective use of ‘advanced’ programming principles (with examples):








## Reflective review, opportunities to improve and continued professional development:

One way to improve the development of this project would be to include an AI feature, such as player vs. computer. In the early stages of testing, more bugs occurred with this feature. One bug in particular was that the wrong 'winner' was displayed in the game. Consequently, the project would be less credible if it included this feature.

Moreover I added the option where the user can choose which player they want to be
and the option to quit the game which is not included on the demo.

https://replit.com/@Augustine129/Tic-tac-toe-game#Screenshot%20(16).png

For an OOP-based project, encapsulation was the best feature to include. However, there are three other principles, including abstraction, inheritance, and polymorphism, that would make this a pure OOP project.



##OOP Principles
Composition

It describes a class that references one or more objects of other classes in instance variables. One way I demostrated composonsition on this project
