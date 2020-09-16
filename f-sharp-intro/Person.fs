namespace OrderModels

module Person = 
    type T = {First:string; Last:string} with
        // member defined with type declaration
        member this.FullName = 
            this.First + " " + this.Last

    // constructor
    let create first last = 
        {First=first; Last=last}
       