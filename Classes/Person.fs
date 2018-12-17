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

let addoneDouble =
    addone >> double

let result x = 
    addoneDouble x
            

// type Apple = {
//     Name: string
// }

// type Banana = {
//     Name: string
// }

type Fruit = Apple | Banana | Dig of int

type Roman = V | X | Y
        
