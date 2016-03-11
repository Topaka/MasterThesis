// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code

let rand = System.Random();
let size = (20, 20);

let RandomPosition size =
    match size with
    | (a, b) -> (rand.Next(a), rand.Next(b));

let goal = RandomPosition size;
let bot = RandomPosition size;

let rec cheatPath botPos = 
    match botPos, goal with
    | (a,b), (c,d) ->  if a<c then "right"::(cheatPath (a+1,b)) else 
                       if a>c then "left"::(cheatPath (a-1,b)) else
                       if b<d then "up"::(cheatPath (a,b+1)) else
                       if b>d then "down"::(cheatPath (a,b-1)) else
                       [];

let cheatTest = cheatPath bot;

