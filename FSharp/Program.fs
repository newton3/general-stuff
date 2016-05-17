// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
let isPalindrome (s: string) =
    let arr = s.ToCharArray()
    arr = Array.rev arr


[<EntryPoint>]
let main args = 
    isPalindrome "abcba"
    |> printfn "%A"

    isPalindrome "abcbadd"
    |> printfn "%A"
    0
    
