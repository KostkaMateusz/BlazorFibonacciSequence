# Fibonacci Sequence Calculator

This web application allows you to generate a Fibonacci sequence based on the specified size. The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, usually starting with 0 and 1.

## Usage

1. Access the application by navigating to the root URL ("/").
2. Enter a non-negative integer representing the maximum size of the Fibonacci sequence (Max: 15000).
3. Click the "Generate Fibonacci Sequence" button.

## Code Structure

- The code is organized using the `Blazor` framework and `WebAssemlby` Deployment model.
- The `FibonaciFormParameters` class defines the input model with validation rules.
- The `CalculationTime` class is responsible for measuring the time taken for the calculation.
- The `OnClick` method triggers the Fibonacci sequence calculation when the form is submitted.
- The `GetFibonaci` method calculates the Fibonacci sequence using an iterative approach.
- The `fibonaciSeries` variable holds the generated Fibonacci sequence.
- The application uses asynchronous tasks and a timer to measure calculation time accurately.

## Features: 
### Input Validation

The input is validated to ensure it falls within the acceptable range (0 to 15000). If an invalid input is provided, an error message will be displayed.

### Calculation Time

The application displays the time taken to calculate the Fibonacci sequence.

### Spinner Indicator

While the Fibonacci sequence is being calculated, a spinner is displayed to indicate ongoing computation.

### Fibonacci Sequence Table

Once the calculation is complete, the resulting Fibonacci sequence is displayed in a table with two columns: "Nº" (index) and "Value."