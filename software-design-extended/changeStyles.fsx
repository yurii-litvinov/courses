let fromSlidesStyle = "../mcsslides"
let toSlidesStyle = "../../slides-style"
let fromTextStyle = "../mcstext"
let toTextStyle = "../../text-style"

open System.IO
open System.Text.RegularExpressions

let change text fromRegex toString =
    let targetRegex = Regex(fromRegex, RegexOptions.Singleline)
    let matches = targetRegex.Matches text

    let mutable textParts = []
    let mutable sourceIndex = 0
    let mutable wereChanges = false

    for aMatch in matches do
        let newText = toString

        textParts <- text.Substring(sourceIndex, aMatch.Index - sourceIndex) :: textParts
        textParts <- newText :: textParts
        sourceIndex <- aMatch.Index + aMatch.Length

        wereChanges <- true

    textParts <- text.Substring(sourceIndex) :: textParts

    let updatedText = textParts |> List.rev |> List.reduce (+)
    (updatedText, wereChanges)

let dirs = 
    Directory.GetDirectories "." 
    |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith("_")))

for dir in dirs do
    let texFiles = Directory.GetFiles(dir, "*.tex")
    for file in texFiles do
        let text = File.ReadAllText(file)

        let updatedText, wereChangesAsSlides = change text $"\\\\documentclass{{{fromSlidesStyle}}}" $"\\documentclass{{{toSlidesStyle}}}"
        let updatedText, wereChangesAsText = change updatedText $"\\\\documentclass{{{fromTextStyle}}}" $"\\documentclass{{{toTextStyle}}}"

        if wereChangesAsSlides || wereChangesAsText then 
            File.WriteAllText(file, updatedText)
