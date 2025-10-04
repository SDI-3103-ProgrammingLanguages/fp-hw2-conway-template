# Conway's Game of Life in F#

## Overview

This starter project provides a minimal F# console application to
simulate Conway's Game of Life. The core logic has not been
implemented. Your task is to complete the functions marked
`failwith "Not yet implemented"` in `Program.fs` so that the
program can evolve the game and display the results in the terminal.

You should not introduce mutable state or loops in the core
simulation. Instead, rely on immutable data structures and pure
functions to compute each generation from the previous one.

## Project layout

- `ConwayGame.fsproj` – F# project file
- `Program.fs` – main entry point with stubbed functions to implement
- `patterns/glider.txt` – sample pattern file defining a glider

## Building and running

After cloning the repository, you can build and run the application
using the .NET CLI. Ensure that the .NET 8.0 SDK is installed.

```bash
dotnet build
dotnet run -- --pattern patterns/glider.txt --gens 50 --width 40 --height 20
```

The example above runs the glider pattern for 50 generations on a
40×20 grid. You may adjust the number of generations and grid size
via command line arguments. If no pattern is supplied, you can
default to a built‑in seed.

## Implementing the Game

The following functions need to be completed in `Program.fs`:

1. **neighbors**: Given a cell coordinate `(x, y)`, return a list of
   the eight neighbouring coordinates.

2. **nextState**: Given a `Set<int * int>` of currently alive cells,
   compute the set of cells that will be alive in the next
   generation according to the Game of Life rules.

3. **render**: Print a rectangular view of the current state to the
   console. Alive cells should be displayed as `#` and dead cells
   as `.`.

4. **loadPattern**: Read a pattern file and return a set of
   coordinates corresponding to live cells. The provided
   `patterns/glider.txt` shows an example format. Pattern files may
   include comments (lines starting with `#`) and blank lines.

5. **parseArgs**: Parse command line arguments to determine the
   initial state, number of generations, and grid dimensions. You
   may choose your own argument syntax; consider flags like
   `--gens`, `--width`, `--height`, and `--pattern`.

6. **main**: The main function calls `parseArgs` to obtain
   parameters, runs a simulation loop using `nextState`, and calls
   `render` at each step. A brief pause is inserted between
   generations to animate the simulation.

### Tips

- Use the `Set` type from F# to efficiently store coordinates of
  live cells. Sets support fast membership tests and basic set
  operations.
- You can compute neighbour counts using functions such as
  `Seq.collect`, `Seq.countBy`, and `Map`.
- Avoid mutable collections and imperative loops; instead, use
  recursion and higher‑order functions.

## License

This template is provided as part of a course assignment and may
only be used for educational purposes.