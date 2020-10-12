module RandomPerson
open LastNames
open FirstNames
open ZipCode
open System

type RandomPerson=
  {
  FirstName:string
  LastName:string
  Gender:string
  ZipCode:BasicZipCodeData
  }


let inline upperCaseFirstLetter (s:string) =
  let mutable c=s.ToLower().ToCharArray()
  c.[0]<-Char.ToUpper(c.[0])
  new string(c)

let generateRandomPerson() =
  let firstName,gender=pickRandomFirstNameAndGender()
  let lastName=pickRandomLastName()
  let zipCodeData=pickRandomZipCodeData()
  {
  FirstName=upperCaseFirstLetter(firstName)
  LastName=upperCaseFirstLetter(lastName)
  Gender=upperCaseFirstLetter(gender)
  ZipCode=zipCodeData
  }
