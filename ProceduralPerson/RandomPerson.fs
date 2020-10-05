module RandomPerson
open LastNames
open FirstNames
open ZipCode
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

let zipCodeAndFrequenciesSum =
  zipCodeFrequenciesList
  |> List.mapFold(fun acc x->
    let newAcc=acc+x.Population
    ((
      { 
        x with
          Population=newAcc
      }
      ), newAcc)
    ) 0.0

let pickRandomZipCode() =
  // NEED TO PUT IN RUNNING TOTAL POP
  let totalPopulation=snd zipCodeAndFrequenciesSum
  let rnd=Random()
  let newNum=rnd.NextDouble()*totalPopulation
  let filteredList=fst zipCodeAndFrequenciesSum|>List.filter(fun x->newNum<(x.Population))
  let chosen=filteredList.[0]
  chosen
