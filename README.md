# Overview
This repository contains a school project for the "Object Programming" subject on WSEI Kraków made by Mateusz Zbróg and Jakub Leżański.
The objective of the project was to create an interactive WPF interface for a console-based Tic Tac Toe game clone, "Hyper Tic Tac Toe", which was made by Mateusz Zbróg as a project for "Introduction to Programming" subject on WSEI Kraków in previous semesters.

The application contains a playable Tic Tac Toe game with configurable Grid Size, ranging from 3 to 6, where the player wins if they fill a number of cells in one direction equal to the Grid Size.    
English and Polish language translations are available.

### Development Baseline
Please use English for the entire project. That includes all of the code, comments, variable names, asset names and this entire repository.

Documentation of the project is handled by XML comments in the source files, as well as this Readme file.

The repository is separated into 4 branches. Three of them are to be used for the initial development, whereas `master` connects all of them for a final product.

### Coding style
The code style in the entire project should be consistent. In order to keep it as such, please follow the guidelines below:

 • The variable naming convention is lowerCamelCase, where the first word starts with a small letter and the later ones always start from a big one. However, separate words with underscore if it is a variation of a specific context. Then return to lower letters for the first word.      
For example, if writing code for a turn timer, the main context of the variable's name would be `turnTimer`. To setup variations of it, such as `currentValue`, use the notation that separates them with an underscore: `turnTimer_currentValue`.

 • Always name variables descriptively. Do not use abbreviations, unless it is a popular abbrevitation for a long word, such as `Coord` instead of `Coordinate` or `ID` for `IdentificationNumber`.

 • After finishing the code, consider if it can be understood just by following the code along. If not, comment it and explain what unclear lines do. The more comments, the better.

 ### Commit descriptions
Commits always require a short description of which changes it introduces, so include a proper short description. It is a good practice to make a commit after finishing work on one thing, before moving to another. It helps you to describe the changes as one package, also allows you to easily roll back in case something goes wrong in the next step. Try to use proper English grammar in the descriptions, also consider including a sign in front of the description, depending on what was its primary change, in following fashion:    
 `+ This change added new features, etc.`     
 `- This change removed things from the project or is a bug fix.`     
 `| This change changed reworked or changed form of something that already was in the project.`

Remember to always include a single space after the sign for sake of readability.

# Project Structure
The application consists of following parts:    
→"MainWindow" page and its code – its role is to handle application/window configuration, as well as prepare initial variables. Not visible to the user.    
→"HomePage" page and its code – Allows the user to configure the game, then start it or shut down the application.    
→"Grid_9" page and its code – Handles the actual game and allows user to return to "HomePage" at any time.    
→"HyperTicTacToe_Library" dynamic link library – Contains logic of the game. Its design is handled in generic style and can be re-used in any interface.   

### Installation Instructions
Head to the [Releases](https://github.com/mateusz-zbrog/project-PO-CS-2019-20-lab/releases) tab, download the installer and launch it. Follow its instructions. During the process, you will have to select a folder where the application will be installed. After it's installed, head to that folder and launch `HyperTicTacToe.exe`.

### IDE Setup

##### Adding library reference

The application cannot launch if it misses assembly reference for `HyperTicTacToe_Library`. If that's the case, in Solution Explorer, head to Dependencies of `HyperTicTacToe` and by right-clicking "Assemblies", add `HyperTicTacToe_Library` to it. If it's not built by you, it should be in `bin\Debug\netcoreapp3.0` folder in projects downloaded from `master` or `library` branch.

##### Setting up final (master) version

Download the `master` branch and launch it in an up-to-date Visual Studio 2019 IDE. The application itself should be ready to be launched by Visual Studio, but you might have to add a library reference (as described above).     
To add Unit Tests, download them from `unit_tests` branch and add them to the `HyperTicTacToe` solution by right-clicking on it in Solution Explorer, then `Add...` → `Existing Project`. The tests can be launched by selecting `Test` on top application bar of Visual Studio 2019 and then selecting `Run All Tests`.

##### Setting up in-dev versions

Download `interface` and `library` branches. Launch the `library` solution and build it, so it's available as DLL, which will appear in `bin\(Debug or Release)\netcoreapp3.0` folder. Launch the `interface` solution and add the built DLL as a reference, following the instructions described above.

### Documentation

An auto-generated documentation is available in `docs` folder in `master` branch.     
A description on usage of the generic HyperTicTacToe library can be found on [Wiki](https://github.com/mateusz-zbrog/project-PO-CS-2019-20-lab/wiki/Using-HyperTicTacToe_Library).

# Credits
Made by Mateusz Zbróg and Jakub Leżański with roughly 50%/50% share of responsibilities.    
Mateusz Zbróg was the leader and worked mostly on the C# code and managed the repository, whereas Jakub Leżański worked mostly on the interface, its visual aspects and XAML code.
