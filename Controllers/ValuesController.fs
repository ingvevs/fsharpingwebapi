namespace fsharpingwebapi.Controllers

open Microsoft.AspNetCore.Mvc
open Personas

[<Route("api/[controller]")>]
[<ApiController>]
type ValuesController () =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let values = [|"value1"; "value2"|]
        ActionResult<string[]>(values)

    [<HttpGet("{id}")>]
    member this.Get(id:int) =
        let person = ConstructorPerson("Ingve", 10)
        let constructorLEss =  {
                Name = "INgve"
                Age = 35
                }

        let myAge = age person
        let resu = addoneDouble myAge

        let result = 5 |> addone |> double

        let orange = Apple
        let bla = Y
        let blabla digit = 
            match digit with
            | X -> 10
            | V -> 5
            | Y -> 1

        let res = blabla X

        ActionResult<int>(res)

    [<HttpPost>]
    member this.Post([<FromBody>] value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>] value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
