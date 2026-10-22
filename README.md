WPF Counter Application

Description



This project is a simple counter application developed in C# using Windows Presentation Foundation (WPF). It allows users to increase, decrease, and reset a counter, as well as change its value by a custom amount entered in a text box.



The application demonstrates basic event handling, variable manipulation, input validation, and updating UI elements in a WPF application.



Features

Increment Counter – Increases the counter by 1.

Decrement Counter – Decreases the counter by 1.

Reset Counter – Resets the counter to 0.

Custom Increment – Increases the counter by a user-specified number.

Custom Decrement – Decreases the counter by a user-specified number.

Input Validation – Restricts keyboard input to numeric digits.

Technologies Used

C#

.NET

Windows Presentation Foundation (WPF)

XAML

Regular Expressions (System.Text.RegularExpressions)

Project Structure

Project/

├── MainWindow.xaml       # Defines the user interface

├── MainWindow.xaml.cs    # Contains the counter logic

├── App.xaml              # Application configuration

└── App.xaml.cs           # Application startup logic





Note: The exact project structure may vary depending on the Visual Studio project template.



How to Run

Install Visual Studio with the .NET desktop development workload.

Open the project or solution file (.csproj or .sln) in Visual Studio.

Make sure the required .NET version is installed.

Build the project using Build → Build Solution.

Run the application by pressing F5 or clicking Start.

How to Use

Launch the application.

Click the increment button to increase the counter by 1.

Click the decrement button to decrease the counter by 1.

Click the reset button to set the counter to 0.

Enter a number into the input field.

Use the custom increment or decrement button to modify the counter by the entered amount.

Implementation Details



The application uses an integer variable named count to store the current counter value.



IncrementBtn\_Click() increases the counter by one.

DecrementBtn\_Click() decreases the counter by one.

ResetBtn\_Click() resets the counter to zero.

NumberValidationTextBox() validates keyboard input using a regular expression.

CustomIncrementBtn\_Click() adds the entered number to the counter.

CustomDecrementBtn\_Click() subtracts the entered number from the counter.



After each operation, the CounterBlock text property is updated to display the current value.



Possible Improvements

Add error handling for empty or invalid input.

Use int.TryParse() instead of int.Parse() to avoid conversion exceptions.

Add support for negative numbers if required.

Prevent integer overflow.

Improve the interface with additional styling and responsive layout.

License



This project is intended for educational and personal use. Add a specific license if you plan to distribute it publicly.

