namespace OrderModels

module Order = 

    type OrderItem = {Name: string; Cost: decimal; Quantity: int} with
        // member defined with type declaration
        member this.Total = 
            this.Cost * (decimal this.Quantity)


    let createOrderItem name cost quantity = 
        {Name = name; Cost = cost; Quantity = quantity}

    let display(orderItem: OrderItem) = 
            printfn "%s %f %i %f" orderItem.Name orderItem.Cost orderItem.Quantity orderItem.Total

    type OrderItem with 
        member this.Display = display this