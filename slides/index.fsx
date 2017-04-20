(**
- title : Hacking F# in JS world
- description : Hacking F# in JS world
- author : Krzysztof Cieslak
- theme : moon
- transition : default

***

### Hacking F# in JS world

* Krzysztof Cieslak
* @k_cieslak

***

### Why F#

* Functional-first
* Typesafety
* Pragmatism
* Computation expression
* Community

---

*)

let value = 123

let value2 = "Hello Get.Net"

let list = [ 1; 2; 3; 4 ]

(**

---

*)

type Model = { property1 : string; property2 : int }

let instance = {property1 = "ABCD"; property2 = 1}

type Shape =
    | Circle of radius : int
    | Rectangle of a : int * b : int
    | Other

let crlc = Circle 123
let rect = Rectangle (123, 345)
let somethingDifferent = Other

(**

---

*)

[ 1; 2; 3; 4 ] |> List.map (fun n -> n + 1)

[ 1; 2; 3; 4 ]
|> List.where (fun n -> n % 2 = 0)
|> List.map (fun n -> n * n)


(**

***

### Why JS

* Run everywhere
* Decent VM
* Innovative and open Community
* Popular in smaller companies and startups

***

### State of the union

* TypeScript
* Flow
* ClojureScript
* Elm
* PureScript
* Others ( ScalaJS, OcamlJS, HaskellJS etc)

***

### Fable

* F# -> JS compailer
* Using Bable as middle step of compilation process
* Deep integration with existing ecosystem
* Generating readable JS

***

### Demo 1

***

### Elm architecture

* Model-View-Update
* Unidirectional data flow
* Works well with Functional Programming / Reactive Programming
* Used in many different libraries - React / Redux, Reactive Extensions based UIs, VueJS

***

### Demo 2

***

### GUI Desktop Applications

* Electron by GitHub
* Run everywhere
* Used by popular applications - Slack, VSCode, Atom

***

### Demo 3

***

### Mobile development

* React native + Elm architecture
* Fuse
* Deep integration with all tooling

***

### Demo 4

***

### Other things

* Server applications (Express.js etc)
* Webtask.io - serverless apps
* React VR
* D3 data visualization
* WebGL (Pixi.js etc)

***

### FableConf

* 22th September
* Bordeaux, France
* Good wine, and food.

***

### Q & A

***

### Thank You

*)