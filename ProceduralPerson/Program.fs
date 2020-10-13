open RandomPerson
open LastNames
open FirstNames
open System

type ArrayItemTuple<'a> = 'a*double //type inference _might_ handle a lot of these generics
type ArrayItem<'a>= { Item:'a;Distribution:double}
let inline TupleToItem<'a>(x:ArrayItemTuple<'a>) = {Item=fst x;Distribution=snd x}
let inline ItemToTuple<'a> x = (x.Item,x.Distribution)

let itemAndFrequenciesSum<'a> (arr:ArrayItemTuple<'a> array) =
  let lst = arr |> Array.toList
  fst (lst
  |> List.mapFold(fun acc x->
    let newAcc=snd x
    ((x,newAcc), newAcc)
    ) 0.0)
let pickRandomItem<'a> (arr:ArrayItemTuple<'a> [])() =
  let x = itemAndFrequenciesSum<'a>(arr)
  let maxNum = snd x.[x.Length-1]
  let rnd=System.Random()
  let newNum=rnd.NextDouble()*maxNum
  let filteredList=x|>List.filter(fun x->newNum<(snd x))
  let chosen=fst filteredList.[0]
  fst chosen

type Gender = Male | Female
let genderBreakDown:(ArrayItemTuple<Gender> [])  =
  [|
    (Male, 0.5);
    (Female, 0.5)
  |]
let foo = pickRandomItem<Gender>(genderBreakDown)


// Nothing -> Male or Female (50/50)
// Gender and no Names -> Gender and Names based on distribution array
// Gender, Names, and no zip -> Gender, names, and zip based ONLY on zip array
//
// In general, it reduces to
// transformMatrix:'b  Values, probabilities, and target transforms
// inputMatrix:'a
// outputMatrix:'a
// TransformFunction=transformMatrix->inputMatrix->outputMatrix
//



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