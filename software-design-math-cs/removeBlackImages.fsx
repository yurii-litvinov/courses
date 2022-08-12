open System.IO
open System.Text.RegularExpressions

let dirs = 
    Directory.GetDirectories "." 
    |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith("_")))

for dir in dirs do
    let texFiles = Directory.GetFiles(dir, "*.tex")
    for file in texFiles do
        let text = File.ReadAllText(file)

        let imageRegex = Regex @"\\includegraphics(\[.*\])?{(.*)Black.png}"
        let matches = imageRegex.Matches text

        let mutable textParts =[]
        let mutable sourceIndex = 0

        for aMatch in matches do
            let optionalPart = if aMatch.Groups.Count >= 3 then aMatch.Groups[1].Value else ""
            let fileNamePart = aMatch.Groups[2].Value
            let newImage = $"\\image{optionalPart}{{{fileNamePart}.png}}"

            textParts <- text.Substring(sourceIndex, aMatch.Index - sourceIndex) :: textParts
            textParts <- newImage :: textParts
            sourceIndex <- aMatch.Index + aMatch.Length

        textParts <- text.Substring(sourceIndex) :: textParts

        let updatedText = textParts |> List.rev |> List.reduce (+)

        File.WriteAllText(file, updatedText)

for dir in dirs do
    let unwantedFiles = Directory.GetFiles(dir, "*Black.*")
    unwantedFiles |> Seq.iter (fun f -> File.Delete f)
