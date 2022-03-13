let holidays = ["23.02.2022"; "08.03.2022"; "01.05.2022"; "02.05.2022"; "09.05.2022"; "10.05.2022"; "12.06.2022"; "13.06.2022"]
let controlWorkPairNumbers = []
let fromPair = 5
let startDate = "14.03.2022"
let directoryPath = "software-design-csc"



open System.IO
open System
open System.Text.RegularExpressions

let convertedStartDate = DateTime.Parse startDate

let dirs = Directory.GetDirectories directoryPath |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith("_")))
let courseDates = 
    Seq.initInfinite (fun i -> convertedStartDate + (TimeSpan.FromDays <| float (i * 7)))
    |> Seq.map (fun date -> date.ToShortDateString())
    |> Seq.except holidays
    |> Seq.indexed
    |> Seq.filter (fun (num, _) -> controlWorkPairNumbers |> List.contains (num + 1) |> not)
    |> Seq.map snd

let pairs = Seq.zip (dirs |> Seq.skip (fromPair - 1)) courseDates 

for dir, date in pairs do
    let texFiles = Directory.GetFiles(dir, "*.tex")
    for file in texFiles do
        let text = File.ReadAllText(file)

        let dateRegex = Regex @"\\date{\d\d\.\d\d\.\d\d\d\d.?}"
        let newDate = $"\\date{{{date}}}"
        let cscDateRegex = Regex @"}{\d\d\.\d\d\.\d\d\d\d.?}"
        let newCscDate = $"}}{{{date}}}"
        let updatedText = dateRegex.Replace(text, newDate)
        let cscUpdatedText = cscDateRegex.Replace(updatedText, newCscDate)

        File.WriteAllText(file, cscUpdatedText)
