
open System.Text.RegularExpressions

let readLines filePath = System.IO.File.ReadAllLines(filePath);

let lines = readLines "puzzle01-input.txt" 

let leftParse (x: string) =
    printfn "leftParse - %A" x
    let c = x.Split(" ", System.StringSplitOptions.RemoveEmptyEntries)
    printfn "leftParse - '%A' - '%A'" x c[0]
    c[0] |> int

let rightParse (x: string) =
    printfn "rightParse - %A" x
    let c = x.Split(" ", System.StringSplitOptions.RemoveEmptyEntries)
    printfn "rightParse - '%A' - '%A'" x c[1]
    c[1] |> int

let leftColumn= lines |> Array.map (fun x ->  leftParse x  ) 
let rightColumn= lines |> Array.map (fun x ->   rightParse x  ) 

let sortedLeftColumn = Array.sort leftColumn
let sortedRightColumn = Array.sort rightColumn

let rec sum (left:array<int>, right:array<int>, index:int) =
    match index with
    | -1 -> 0
    | _ ->  abs(left[index] - right[index]) + sum (left, right, index-1)

let result:int = sum (sortedLeftColumn, sortedRightColumn, sortedLeftColumn.Length-1)

// correct answer 2378066
printfn "The total is %A"  result;;



    