# Elevens Card Game - 2nd Submission ✨

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


 
