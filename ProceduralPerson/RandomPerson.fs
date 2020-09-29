module RandomPerson
open LastNames
open FirstNames
open System

let inline upperCaseFirstLetter (s:string) =
  let mutable c=s.ToLower().ToCharArray()
  c.[0]<-Char.ToUpper(c.[0])
  new string(c)

let pickRandomLastName() =
  let maxLastName=snd lastNameAndFrequencies.[lastNameAndFrequencies.Length-1]
  let rnd=Random()
  let newNum=rnd.NextDouble()*maxLastName
  let filteredList=lastNameAndFrequencies|>List.filter(fun x->newNum<(snd x))
  let chosen=filteredList.[0]
  upperCaseFirstLetter (fst chosen)

let pickRandomFirstName() =
  let maxFirstName=snd firstNameAndFrequencies.[firstNameAndFrequencies.Length-1]
  let rnd=Random()
  let newNum=rnd.NextDouble()*maxFirstName
  let filteredList=firstNameAndFrequencies|>List.filter(fun x->newNum<(snd x))
  let chosen=filteredList.[0]
  upperCaseFirstLetter (fst chosen)