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


    let item1 = Order.createOrderItem "Table" 199.99m 1
    let item2 = Order.createOrderItem "Chair" 49.99m 6
    let item3 = Order.createOrderItem "Lamp" 99.99m 1
    let item4 = Order.createOrderItem "Plate" 3.99m 6
    let item5 = Order.createOrderItem "Cup" 2.99m 6

    let order = [item1; item2; item3; item4; item5]

    List.iter( fun (item: Order.OrderItem) -> item.Display) order
   
    let orderTotal = order |> Seq.sumBy(fun (item: Order.OrderItem) -> item.Total) 
    printfn "order total: %f" orderTotal


    0 // return an integer exit code
