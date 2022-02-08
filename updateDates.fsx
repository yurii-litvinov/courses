let holidays = ["23.02.2022"; "08.03.2022"; "01.05.2022"; "02.05.2022"; "09.05.2022"; "10.05.2022"; "12.06.2022"; "13.06.2022"]
let controlWorkPairNumbers = [8; 10; 12]
let startDate = "17.02.2022"
let directoryPath = "programming/programming-2nd-semester"



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

for dir, date in Seq.zip dirs courseDates do
    let texFiles = Directory.GetFiles(dir, "*.tex")
    for file in texFiles do
        let text = File.ReadAllText(file)
        let dateRegex = Regex @"\\date{\d\d\.\d\d\.\d\d\d\d.?}"
        let newDate = $"\\date{{{date}}}"
        let updatedText = dateRegex.Replace(text, newDate)
        File.WriteAllText(file, updatedText)
