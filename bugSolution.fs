let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable result = add x y // Declare result as mutable
printfn "%d" result

x <- 100
y <- 200

result <- add x y
printfn "%d" result