open System
open System.IO

/// Compute the eight neighbouring coordinates of a cell.
/// This function should return a list of the coordinates
/// adjacent to the given (x,y) position. The order of the
/// neighbours does not matter.
let neighbors (x:int, y:int) : (int * int) list =
    failwith "Not yet implemented"

/// Given a set of currently alive cells, compute the next generation
/// according to Conway's Game of Life rules:
///  - Any live cell with fewer than 2 live neighbours dies.
///  - Any live cell with 2 or 3 live neighbours survives.
///  - Any live cell with more than 3 live neighbours dies.
///  - Any dead cell with exactly 3 live neighbours becomes alive.
let nextState (alive : Set<int * int>) : Set<int * int> =
    failwith "Not yet implemented"

/// Render the current state to the console. The width and height
/// determine the bounds of the viewable window. Cells outside
/// these bounds may be omitted. Alive cells should be printed
/// with '#', dead cells with '.'.
let render (alive : Set<int * int>) (width:int) (height:int) : unit =
    failwith "Not yet implemented"

/// Load a pattern from a file. A simple text format is provided
/// in patterns/glider.txt. Lines beginning with '#' are comments
/// and blank lines are ignored. Each remaining line should contain
/// two integers separated by whitespace representing the x and y
/// coordinates of a live cell. Coordinates are relative and may
/// include negative values.
let loadPattern (path:string) : Set<int * int> =
    failwith "Not yet implemented"

/// Parse command line arguments. The default behaviour runs a glider
/// seed for a limited number of generations. You are free to extend
/// the CLI to accept flags such as --gens, --width, --height or
/// --pattern &lt;file&gt;.
let parseArgs (args:string list) : (Set<int*int>) * int * int * int =
    // return: initial alive set, generations, width, height
    failwith "Not yet implemented"

[<EntryPoint>]
let main argv =
    try
        let args = argv |> Array.toList
        // Parse arguments: initial state, number of generations, width, height
        let initial, gens, width, height = parseArgs args
        // Simulation loop: repeatedly apply nextState and render
        let rec loop (state:Set<int*int>) (g:int) =
            if g &gt; 0 then
                // Clear the console between generations
                Console.Clear()
                render state width height
                // Sleep briefly to create a visible animation
                System.Threading.Thread.Sleep(100)
                loop (nextState state) (g - 1)
        loop initial gens
        0
    with
    | ex ->
        eprintfn "%s" ex.Message
        eprintfn "Usage: dotnet run -- [--gens N] [--width W] [--height H] [--pattern file]"
        1