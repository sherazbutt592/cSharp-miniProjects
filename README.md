📘 C# Projects Collection

This repository contains multiple C# console-based projects I created while learning object-oriented programming, design patterns, and best practices. Each project demonstrates different concepts in .NET development such as abstraction, encapsulation, interfaces, file handling, JSON serialization, caching, and custom business logic.

📂 Projects Overview
1. ✅ Todo Application

A simple task manager that lets users add, view, and remove TODO items.

Data persistence is handled using JSON files.

Demonstrates: Interfaces, Dependency Injection, Repository Pattern, Input Validation.

Features:

Add unique TODOs.

Remove tasks by index.

Save & load tasks from a file.

Error logging with a Logger.

2. 🎲 Dice Roll Game

A fun console game where the user has 3 tries to guess the number rolled on a 6-sided dice.

Demonstrates: Encapsulation, Interfaces, Random number generation.

Features:

Dice rolling simulation.

Input validation for guesses.

Win/Lose tracking with an enum.

3. 🗂 Game Data Parser

Reads JSON-formatted game data (title, release year, rating) from a file.

Demonstrates: Serialization/Deserialization, File Handling, Error Logging.

Features:

Load and display game data.

Detect and print invalid data in red text.

Log errors into a file (error.log).

4. ⚡ Custom Cache System

Implements a simple caching layer to avoid repeated expensive operations.

Demonstrates: Decorator Pattern, Composition, Dictionary usage.

Features:

SlowDataDownloader simulates slow operations.

CachedDataDownloader caches results for reuse.

Shows performance difference between cached vs non-cached calls.

5. 🍲 Recipe & Ingredients Manager

Manages recipes and their ingredients, storing them in files as IDs.

Demonstrates: Composition, JSON/File Storage, Data Transformation.

Features:

Convert each recipe into a list of ingredient IDs.

Store and retrieve recipes as structured data.

Explore issues like list accumulation & fix with fresh per-recipe ID lists.

🚀 How to Run

Clone the repo:

git clone https://github.com/your-username/your-repo-name.git


Open the project in Visual Studio or VS Code.

Build and run any project from the solution.

🛠 Technologies Used

C# (.NET 6/7)

OOP Principles (Encapsulation, Inheritance, Interfaces, Polymorphism)

Design Patterns (Repository, Decorator, Strategy, Template)

File Handling & JSON Serialization

Console Applications

📌 Notes

These projects were created as part of my C# learning journey. They focus on clean code practices, proper separation of concerns, and applying real-world software engineering concepts in small, manageable programs.
