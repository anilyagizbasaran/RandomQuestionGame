# Random Question Game

This project is a simple game application that allows users to play a game where random questions are displayed on the screen. Users can enter their own questions, which are then stored in a text file and used during gameplay.

## Getting Started

These instructions will help you get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You need to have .NET Framework and an appropriate development environment such as Visual Studio installed on your computer to run this project.

### Installation

1. Clone this project:
[github.com/anilyagizbasaran/RandomQuestionGame.git](https://github.com/anilyagizbasaran/RandomQuestionGame.git)
2. Open the project using Visual Studio or your preferred IDE.
3. Build and run the project.

## Usage

The game displays a random question to the user. Each time the user presses "Enter", a new question appears on the screen. Additionally, users can add new questions or delete existing ones.

## Forms and Their Functions

In this project, there are three main forms, each serving a different purpose:

### MainForm.cs

This form acts as the entry screen where users have the option to either start playing the game or navigate to the settings section.

### QuestionsForm.cs

Similar to a settings panel, this form allows users to manage questions by adding or deleting them.

### RandomQuestionsForm.cs

This form represents the gameplay screen. Pressing "Enter" displays the next question in sequence.

## Data Storage

The user-entered questions are stored in a text file named "Question.txt" located in the "Documents" folder. This file is automatically created when you launch the game for the first time, and it serves as the storage for the questions entered during gameplay.

The `QuestionDal` class interacts with this file as if it were a simple database. Here's how it works:

- **GetAll():** Reads all questions from the "Question.txt" file located in the "Documents" folder and returns them as a list of strings.
- **AddQuestion(string newQuestion):** Appends a new question to the end of the "Question.txt" file.
- **DeleteQuestion(string deleteQuestion):** Deletes a specific question from the "Question.txt" file.

This approach allows for simple data storage and retrieval without the need for a full-fledged database system.

## Random Question Generation

Random questions are generated and displayed using the `Shuffle` method. Here's how it works:

- The `Shuffle` method is used to randomize the order of questions stored in the list.
- When the game starts or when the user requests a new question, the questions are shuffled to ensure randomness.
- The `QuestionDal` class retrieves the questions from the "Question.txt" file and stores them in a list.
- Each time the user presses "Enter" to request a new question, the next question in the shuffled list is displayed.

This approach ensures that the user receives a random sequence of questions during gameplay, enhancing the gaming experience.

## Contributing

If you would like to contribute to this project, please submit a pull request. Consider opening an issue to initiate a discussion for major changes before making modifications.

