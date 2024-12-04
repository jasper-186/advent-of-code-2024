
open System.Text.RegularExpressions

let readLines filePath = System.IO.File.ReadAllLines(filePath);

let lines = readLines "puzzle01-input-test.txt" 
let leftColumn= lines |> Array.map (fun x ->  x.Split(" ")[0] |> int  ) 
let rightColumn= lines |> Array.map (fun x ->   x.Split(" ")[1] |> int  ) 

let sortedLeftColumn = Array.sort leftColumn
let sortedRightColumn = Array.sort rightColumn

let rec sum (left:array<int>, right:array<int>, index:int) =
    match index with
    | -1 -> 0
    | _ ->  abs(left[index] - right[index]) + sum (left, right, index-1)

let result:int = sum (sortedLeftColumn, sortedRightColumn, sortedLeftColumn.Length-1)

printfn "The total is %A"  result;;



    