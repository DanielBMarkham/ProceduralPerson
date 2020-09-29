open RandomPerson
open System

[<EntryPoint>]
let main argv =
  printfn "Hello "
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  printfn "      %s %s" (pickRandomFirstName()) (pickRandomLastName())
  0