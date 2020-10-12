open RandomPerson
open System

let printRandomPerson() =
  let newRandomPerson=generateRandomPerson()
  let firstName=newRandomPerson.FirstName
  let lastName=newRandomPerson.LastName
  let zipCodeData=newRandomPerson.ZipCode
  printfn "       %s %s \n       %s, %s\n" firstName lastName zipCodeData.City zipCodeData.State

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