// Learn more about F# at http://fsharp.org

open System

let rec totalArea (squares: List<int>): int =
    match squares with
    | [] -> 0
    | head::tail ->
        head * head + totalArea tail

let totalArea2 (squares: List<int>): int = 
    List.map (fun x -> x * x) squares |> List.reduce (+)

type Prereq =     
    | And of seq<Prereq>     
    | Or of seq<Prereq>     
    | Unit of string     
    | CreditPoints of int     
    | Nil

let rec numberOfUnits (prereq: Prereq) : int =
    match prereq with
    | And seq -> 
        Seq.map (fun s -> numberOfUnits s) s |> Seq.reduce (+)
    | Or seq -> 
        Seq.map (fun s -> numberOfUnits s) s |> Seq.reduce (+)
    | Unit u -> 1
    | _ -> 0

[<EntryPoint>]
let main argv =
    printfn "%d" (numDays 2)
    Console.ReadKey() |> ignore
    0 // return an integer exit code
