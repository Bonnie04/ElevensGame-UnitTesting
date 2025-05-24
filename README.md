# Elevens Card Game - Complete Development Journey

##  1st Submission: Foundation & Unit Testing
This initial version established the core classes and comprehensive unit testing framework.

###  What Was Built
- **Card Class**: Basic card representation with enum-based suits and ranks
- **Deck Class**: 52-card deck with Fisher-Yates shuffle algorithm
- **Player Class**: Hand management and scoring functionality  
- **ElevensGame Class**: Initial game logic for card removal and win detection
- **Comprehensive Unit Tests**: 15+ tests covering all class functionality

###  Key Features Implemented
- Card creation and value calculation (Ace=1, Jack=11, Queen=12, King=13)
- Deck shuffling using Fisher-Yates algorithm
- Game board management with 9-card layout
- Pair detection for cards summing to 11
- Jack-Queen-King combination detection
- Win/loss condition checking
- Move counting and validation

###  Technical Highlights
- Object-oriented design with proper encapsulation
- MSTest framework for unit testing
- Error handling for edge cases
- Enum-based card representation for type safety

---

# Elevens Card Game - 2nd Submission 

##  Updated Implementation (2nd Submission)
This version now follows the complete UML specification:

###  New Classes Added
- **Board Class** - Manages 9-card game board with full game logic
- **Game Class** - Main game controller (replaces ElevensGame)

###  Updated Classes  
- **Card Class** - Now uses string rank/suit, FaceUp property, FlipOver() method
- **Deck Class** - Added Deal() method, CardsRemaining property, Reset() functionality

###  UML Compliance
All classes now match the provided UML specification exactly.

---

## Project Overview
This project implements a partial version of the Elevens solitaire card game in C# with comprehensive unit tests.

## Completed Implementation

###  Core Classes
- **Card.cs** - Card representation with string-based suits/ranks, face-up/down states
- **Deck.cs** - 52-card deck with Fisher-Yates shuffle algorithm and dealing functionality
- **Player.cs** - Player functionality with hand management
- **Board.cs** - Game board managing 9-card layout with win/loss detection
- **Game.cs** - Main game controller for managing game state

###  Unit Tests
- **CardTests.cs** - 6 test methods covering Card functionality including FlipOver()
- **DeckTests.cs** - 5 test methods for deck operations and card dealing
- **PlayerTests.cs** - 4 test methods for player operations
- **GameTests.cs** - 3 test methods for game logic

###  Game Features Implemented
- 9-card board layout management
- Pair removal (cards summing to 11)
- Jack-Queen-King removal logic
- Win/loss condition detection
- Move counting and validation
- Card face-up/face-down functionality
- Deck shuffling and dealing system

### 📋 UML Design Implementation
This implementation follows the provided UML specification:

**Card Class Features:**
- String-based rank and suit properties
- FaceUp boolean property with get/set
- PointValue calculation (1-13)
- FlipOver() method for state changes
- ToString() and Equals() methods

**Deck Class Features:**
- CardsRemaining property
- IsEmpty property
- Deal() method for card distribution
- Reset() functionality
- HasCards() validation

**Board Class Features:**
- 9-card array management
- GameWon/GameLost properties
- SelectCards() for move validation
- ReplaceCards() for board updates
- HasValidMoves() detection

**Game Class Features:**
- IsGameActive property
- CurrentBoard access
- PlayCards() move execution
- StartNewGame()/RestartGame() functionality

## Test Results
All unit tests pass successfully, validating the core functionality of each class according to UML specifications.

## Assignment Submission
This represents the 2nd submission for the Elevens game assignment with complete UML compliance and enhanced unit testing.

###  Technical Implementation Notes
- Uses string-based card representation as per UML spec
- Implements proper error handling for edge cases
- Follows object-oriented design principles
- Includes comprehensive validation and testing
- Maintains backward compatibility where possible

###  Class Relationships (UML Compliant)
- Game has one Board
- Board has one Deck and 9 Cards
- Deck has many Cards
- All relationships match provided UML diagram

  ##  3rd Submission Update: Fully Playable Game!
This final version provides a complete, playable console implementation of the Elevens solitaire card game.

##  How to Compile and Run

### Requirements
- .NET SDK 6.0 or later

### Instructions
```bash
# Clone the repository
git clone https://github.com/Bonnie04/ElevensGame-UnitTesting.git
cd ElevensGame-UnitTesting

# Build and run the game
dotnet restore
dotnet build
dotnet run --project ElevensGame


 
