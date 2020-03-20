// Learn more about F# at http://fsharp.org

open System

let abs x =
    if x < 0.0 then
        x * -1.0
    else 
        x

let hyp a b = 
    let square x =
        x * x
    sqrt (square a + square b)  

let leap x = 
    if x % 4 = 0 then
        if x % 100 = 0 then
            x % 400 = 0
        else
            true                                        
    else 
        false   

let numDays month = 
    match month with
    | 2 -> 28
    | 4 -> 30
    | 6 -> 30
    | 9 -> 30
    | 11 -> 30
    | _ -> 31



[<EntryPoint>]
let main argv =
    printfn "%d" (numDays 2)
    Console.ReadKey() |> ignore
    0 // return an integer exit code
