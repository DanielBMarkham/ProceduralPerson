module RandomPerson
open LastNames
open FirstNames
open System

let inline upperCaseFirstLetter (s:string) =
  let mutable c=s.ToLower().ToCharArray()
  c.[0]<-Char.ToUpper(c.[0])
  new string(c)

let pickRandomLastName() =
  let rnd=Random()
  let newNum=rnd.NextDouble()*100.0
  let filteredList=lastNameAndFrequencies|>List.filter(fun x->newNum<(snd x))
  let chosen=filteredList.[0]
  upperCaseFirstLetter (fst chosen)

let pickRandomFirstName() =
  let rnd=Random()
  let newNum=rnd.NextDouble()*100.0
  let filteredList=firstNameAndFrequencies|>List.filter(fun x->newNum<(snd x))
  let chosen=filteredList.[0]
  upperCaseFirstLetter (fst chosen)