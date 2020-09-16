namespace OrderModels

type OrderItem = {Name: string; Cost: decimal; Quantity: int} with
    // member defined with type declaration
    member this.Total = 
        this.Cost * (decimal this.Quantity)
