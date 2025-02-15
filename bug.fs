let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result

x <- 100
y <- 200

result <- add x y //Error: This line will cause a compile-time error.
printfn "%d" result