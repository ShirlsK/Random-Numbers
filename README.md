# 🎲 Random Number - Guess the Number Game

A simple **C# console application** where the user plays a "Guess the Number" game.

The program generates a random number between **1 and 30**.  
The user must guess the number, and the program will give hints:

- "TOO LOW! TRY AGAIN"
- "TOO HIGH! TRY AGAIN"
- "Correct!" when guessed correctly

## 🎮 How to play

- Run the program.
- Enter your guesses in the console.
- The program will tell you if your guess is too low, too high, or correct.
- It will also show how many attempts it took you.

## 🛠️ Technologies used

- C#
- .NET 8.0 Console Application
- Random number generation
- Console input/output
- Basic game loop and user interaction

## 🗂️ Project Structure
randomNumb/
├── randomNumb.sln
├── Program.cs
├── randomNumb.csproj
└── README.md

## 🚀 How to run the project

### Using Visual Studio:

1. Open `randomNumb.sln` in Visual Studio.
2. Press **F5** or click **Run**.

### Using .NET CLI:

```bash
dotnet run

📖 Example output
Welcome to 'Guess the Number'!
I have selected a number between 1 and 30. Can you guess what it is?
Enter your guess: 10
TOO LOW! TRY AGAIN
Enter your guess: 20
TOO HIGH! TRY AGAIN
Enter your guess: 15
Correct! You guessed the number in 3 attempts.
Thank you for playing!
