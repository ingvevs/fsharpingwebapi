module Personas
type ConstructorPerson(name: string, age: int) =
    let _name = name
    member This.Age = age

    member this.Name with get() = _name

type ConstrucorLessPerson = {
    Name: string
    Age: int
    }

let age (person: ConstructorPerson) =
    person.Age

let addone x = x + 1

let double x = x * 2

let addoneDouble x =
    addone >> double

let result x = 
    addoneDouble x
            
