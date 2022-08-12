open System.IO
open System.Text.RegularExpressions

let dirs = 
    Directory.GetDirectories "." 
    |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith("_")))

for dir in dirs do
    let texFiles = Directory.GetFiles(dir, "*.tex")
    for file in texFiles do
        let text = File.ReadAllText(file)

        let targetRegex = Regex(@"\\documentclass.*\\title{(.*)}.*\\author.*\\begin{document}", RegexOptions.Singleline)
        let matches = targetRegex.Matches text

        let mutable textParts = []
        let mutable sourceIndex = 0
        let mutable wereChanges = false

        for aMatch in matches do
            let newText = $"\\documentclass{{../mcstext}}\n\n\\texttitle{{{aMatch.Groups[1]}}}\n\n\\begin{{document}}"

            textParts <- text.Substring(sourceIndex, aMatch.Index - sourceIndex) :: textParts
            textParts <- newText :: textParts
            sourceIndex <- aMatch.Index + aMatch.Length

            wereChanges <- true

        textParts <- text.Substring(sourceIndex) :: textParts

        let updatedText = textParts |> List.rev |> List.reduce (+)

        if wereChanges = true then 
            File.WriteAllText(file, updatedText)

for dir in dirs do
    let unwantedFiles = Directory.GetFiles(dir, "*.tmp")
    unwantedFiles |> Seq.iter (fun f -> File.Delete f)