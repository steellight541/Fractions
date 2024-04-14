# Fractions Calculator

This project is a fractions calculator implemented in C#. It consists of several components:

- `LibraryFractions`: This is the core library that implements the logic for fraction operations. See [LibraryFractions.csproj](LibraryFractions/LibraryFractions.csproj) and [Fraction.cs](LibraryFractions/Fraction.cs) for more details.
- `ConsFractionsApp`: This is a console application that uses the `LibraryFractions` library. See [ConsFractionsApp.csproj](ConsFractionsApp/ConsFractionsApp.csproj) and [Program.cs](ConsFractionsApp/Program.cs) for more details.
- `TestFractionLibrary`: This project contains unit tests for the `LibraryFractions` library. See [TestFractionLibrary.csproj](TestFractionLibrary/TestFractionLibrary.csproj) and [UnitTestFraction.cs](TestFractionLibrary/UnitTestFraction.cs) for more details.
- `WPFFractionsCalculator`: This is a WPF application that provides a graphical user interface for the fractions calculator. See [WPFFractionsCalculator.csproj](WPFFractionsCalc/WPFFractionsCalculator.csproj), [MainWindow.xaml](WPFFractionsCalc/MainWindow.xaml), and [MainWindow.xaml.cs](WPFFractionsCalc/MainWindow.xaml.cs) for more details.

## Building the Project

To build the project, open `FractionsCalculator.sln` in Visual Studio and build the solution.

## Running the Project

To run the project, you can either run the `ConsFractionsApp` console application or the `WPFFractionsCalculator` WPF application from Visual Studio.

## Running the Tests

To run the tests, open `TestFractionLibrary` set it as [Startup_Project]() in Visual Studio and run the tests.

## Set as Startup Project

To set a project as the startup project in Visual Studio, follow these steps:

1. Open your solution in Visual Studio.
2. In the Solution Explorer window (usually on the right side), locate the project that you want to set as the startup project.
3. Right-click on the project and select "Set as Startup Project" from the context menu. 

The selected project will now be set as the startup project. You can verify this as the project name will be displayed in bold in the Solution Explorer window. This means that when you run your solution, Visual Studio will start executing the code from this project.
