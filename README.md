❌⭕ Tic Tac Toe Game – Windows Forms (.NET)

A desktop Tic Tac Toe (X/O) game built using C# and Windows Forms (.NET).
This project demonstrates game logic implementation, event-driven programming, and UI interaction in a desktop application.

<img width="1132" height="621" alt="image" src="https://github.com/user-attachments/assets/160fde08-a256-4dae-ae08-96cf378d6af5" />


Two players take turns placing X and O on a 3×3 grid. The system automatically detects the winner or a draw.

 Features

The game includes the following functionality:

Two-player gameplay
Player 1 uses X
Player 2 uses O

Automatic winner detection

Horizontal win
Vertical win
Diagonal win

Draw detection

If all 9 rounds are played without a winner

Restart game button
Resets the board
Resets turns
Starts a new game

 Invalid move detection

Prevents selecting an already occupied cell
Winning combination highlight
Winning cells turn green

Concepts Practiced

This project helped practice several important programming concepts:

Event-driven programming
Game state management
UI control manipulation
Working with PictureBox
Using Tag property to store state
Drawing custom graphics using Paint
Handling turns and game rounds
Win condition checking

Game Interface

The interface contains:

A 3×3 game board
A turn indicator
A winner display
A restart button
The grid is drawn dynamically using the Paint event.


Game Logic

Each move updates:

The board cell
The player turn
The number of rounds played

After every move, the system checks if the game has ended.

 Game End Conditions

The game ends when:

A player completes 3 symbols in a row
9 rounds are played without a winner (Draw)
Winning cells are highlighted in green, and the game board becomes disabled.

Technologies Used

C#
.NET Framework

Learning Purpose

This project was created to practice game logic and GUI programming using Windows Forms, focusing on how user interactions update application state and control program flow.
Windows Forms
