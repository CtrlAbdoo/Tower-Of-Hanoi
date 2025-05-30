# Tower of Hanoi

A graphical implementation of the classic Tower of Hanoi puzzle game using C# and Windows Forms.

## Description

The Tower of Hanoi is a classic mathematical game or puzzle that consists of three poles and a number of disks of different sizes which can slide onto any pole. The puzzle starts with the disks neatly stacked in ascending order of size on one pole, creating a conical shape. The objective is to move the entire stack to another pole, following these rules:

1. Only one disk can be moved at a time
2. Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack or on an empty pole
3. No larger disk may be placed on top of a smaller disk

## Features

- Interactive drag-and-drop interface
- Variable number of disks
- Move counter
- Auto-solve demonstration
- Minimum moves counter
- Visual feedback for valid/invalid moves

## Technical Details

The project is built using:
- C# (.NET Framework)
- Windows Forms for the GUI
- MVVM architecture pattern

### Project Structure

- `Program.cs` - Application entry point
- `GameForm.cs` - Main game window and UI logic
- `GameState.cs` - Manages the game state
- `Move.cs` - Handles move logic and validation
- `Pole.cs` - Represents a pole in the game
- `Disk.cs` - Represents a disk in the game
- `MoveCalculator.cs` - Calculates possible moves and solutions
- `GameConstants.cs` - Game configuration constants

## How to Play

1. Launch the application
2. Select the number of disks you want to play with from the menu
3. Drag and drop disks between poles
4. Try to solve the puzzle in the minimum number of moves
5. Use the "Show Me" option to see the solution demonstrated

## Development

### Prerequisites

- Visual Studio (2019 or later recommended)
- .NET Framework

### Building the Project

1. Clone the repository
2. Open `toh.sln` in Visual Studio
3. Build the solution (F5 or Ctrl+Shift+B)

## Tips

- The minimum number of moves required to solve the puzzle is 2^n - 1, where n is the number of disks
- Start with a smaller number of disks to understand the pattern
- The game includes a move counter to track your progress
- Use the auto-solve feature to learn the optimal solution strategy

## Contributing

Feel free to fork the repository and submit pull requests for any improvements you'd like to make.

## License

This project is available under the MIT License. 