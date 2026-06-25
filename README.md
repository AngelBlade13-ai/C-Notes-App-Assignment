# Notes App

A simple Windows Forms notes application built in C#. The app lets a user create notes with a title and message, store them in a table, read selected notes, delete notes, and open the current note in a second form.

## How to Run

1. Clone the repository.
2. Open `C# Notes App.slnx` in Visual Studio.
3. Build and run the project.

## Features

- Add a note with a title and message.
- Read a selected note back into the main form fields.
- Clear the input fields with the New button to start a separate note.
- Delete a selected note and automatically clear the title and message fields.
- Open the current title and message in Form2.
- Close Form2 with the Go Back button.
- Basic error handling for empty notes and missing selections.

## Demonstration Steps

1. Type a title and message, then click Save.
2. Select the saved note in the list and click Read.
3. Click Open Second Form to view that note in Form2.
4. Click Go Back to close Form2.
5. Click New to clear the fields for another note.
6. Select a note and click Delete to remove it and clear the fields.
