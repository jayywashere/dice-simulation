# DiceSimulation

> a small C# dice simulation because apparently i wanted to roll millions of dice without actually rolling millions of dice (LITERALLY)

## About

basically, i made this as a small C# project to mess around with simulations, random numbers, numeric input validation, and working with different dice setups

it supports the standard 2d6 setup as well as custom dice with configurable dice counts and sides

the program runs the simulations, sorts the roll frequencies, and calculates the percentage of times each result occurred

## Features

- standard 2d6 simulation
- custom dice count and sides
- up to 10,000,000 simulation rounds
- sorts and displays roll frequencies
- calculates result percentages
- generic numeric input validation with configurable ranges

## Requirements

- .NET 10.0

## Run

run the program with:

```bash
dotnet run
```

## Example

```text
=== DICE SIMULATOR ===

1. Run Standard 2d6 Simulation

2. Run Custom Dice Simulation

3. Exit
```

## How It Works

the program lets you choose between a standard 2d6 simulation or a custom dice simulation.

for custom simulations, you can configure the number of dice and the number of sides on each die, along with the number of simulation rounds.

after running the simulations, the program counts how often each result occurs, sorts the results, and calculates their percentages.

## Current Scope

- standard 2d6 simulations
- custom dice simulations
- configurable dice count and sides
- up to 10,000,000 simulation rounds
- roll frequency sorting
- result percentages
- numeric input validation

more features may be added later...hm

## License

See [LICENSE](LICENSE).
