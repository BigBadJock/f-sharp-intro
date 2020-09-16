// Learn more about F# at http://fsharp.org

open System
open OrderModels

[<EntryPoint>]
let main argv = 
    let square x =  x * x 
    let squareValues v = List.map( fun x-> square x) v

    let values = [1..10]
    printfn "values %A" values

    let newValues = List.map(fun x-> x * 2) values
    printfn "newValues %A" newValues

    let squared = squareValues values
    printfn "squared values %A" squared

    let squared2 = squareValues newValues
    printfn "squared newValues %A" squared2

    let item1 = {Name= "Table"; Cost= 199.99m; Quantity=1 }
    let item2 = {Name= "Chair"; Cost=  49.99m; Quantity=6 }
    let item3 = {Name= "Lamp";  Cost=  99.99m; Quantity=1 }
    let item4 = {Name= "Plate"; Cost=   3.99m; Quantity=6 }
    let item5 = {Name= "Cup";   Cost=   2.99m; Quantity=6 }
    let order = [item1; item2; item3; item4; item5]

    List.iter(fun x -> printfn "%s %f %i %f" x.Name x.Cost x.Quantity x.Total) order

    let orderTotal = order |> Seq.sumBy(fun (item: OrderItem) -> item.Total) 
    printfn "order total: %f" orderTotal


    0 // return an integer exit code
