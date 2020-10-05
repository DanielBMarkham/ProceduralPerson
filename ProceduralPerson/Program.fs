open RandomPerson
open System

let printRandomPerson() =
  let firstName=pickRandomFirstName()
  let lastName=pickRandomLastName()
  let randomPerson=pickRandomZipCode()
  printfn "       %s %s \n       %s, %s\n" firstName lastName randomPerson.City randomPerson.State

[<EntryPoint>]
let main argv =
  printfn "Hello "
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  printRandomPerson()
  0