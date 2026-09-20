# Student Grade Calculator GUI

This is a Windows Forms version of my Student Grade Calculator console application.

## Object-Oriented Design

The application uses a Student base class with RegularStudent and HonorsStudent derived classes. The classes use inheritance to share student information and grade calculations.

RegularStudent and HonorsStudent override the DetermineLetterGrade method.

## How to Use

Enter a student name and three grades, then click Calculate. The program will display the average and letter grade. Clear resets the form and Close exits the application.

## Controls and Events

The application uses text boxes, labels, and buttons. It includes Form Load and button Click events.

## Validation

The student name cannot be blank and grades must be numbers from 1 to 100.

## Limitations

The application calculates three grades for one student at a time.
