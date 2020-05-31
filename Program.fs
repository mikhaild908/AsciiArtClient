open System
open System.Drawing
open ImageToAsciiArt

[<EntryPoint>]
let main argv = 
    let bitmap = AsciiArt.DrawText("MIKE")
    let chars = AsciiArt.ConvertToAscii(bitmap)

    for h in [0 .. bitmap.Height - 1] do
        for w in [0 .. bitmap.Width - 1] do
            Console.Write(chars.[w, h]);
        Console.WriteLine() 

    //Console.ReadLine() |> ignore
    0