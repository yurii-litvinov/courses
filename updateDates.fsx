/// Copyright (c) Yurii Litvinov 2023-2025

/// Configuration parameters:
/// Relative path to a directory with presentations (that has separate subdirectories for each pair).
let directoryPath = "programming-2nd-semester"

/// Date of a firs pair of a course, in dd.mm.yyyy format.
let startDate = "11.02.2025"

/// A list of control work pairs that don't have their own slides or text, starting with 1.
let controlWorkPairNumbers = [17; 22]

/// All pairs before this pair will be left unmodified.
let fromPair = 1

/// Should be true if there are two pairs in a week with separate presentations.
let twoPairsAWeek = true

/// If there are two pairs in a week with separate presentations, date of a second pair of a course, in dd.mm.yyyy format.
/// Has effect only if twoPairsAWeek is true.
let secondPairStartDate = "14.02.2025"

/// A list of holidays (and other days we need to skip for some reason), in dd.mm.yyyy format.
let holidays = ["08.03.2025"; "01.05.2025"; "08.05.2025"; "09.05.2025"; "12.06.2025"; "04.11.2025"; "31.12.2025"]

open System.IO
open System
open System.Text.RegularExpressions

let convertedStartDate = DateTime.Parse startDate
let convertedSecondPairDate = DateTime.Parse secondPairStartDate

let dirs = 
        Directory.GetDirectories directoryPath 
        |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith("_")))
        |> Seq.filter (fun dir -> not ((FileInfo dir).Name.StartsWith(".")))
        |> Seq.sort

let pairDate (startDate: DateTime) weekNumber =
    startDate + TimeSpan.FromDays (weekNumber * 7)

let courseDates = 
    Seq.initInfinite id 
    |> Seq.collect (fun i -> (pairDate convertedStartDate i) :: if twoPairsAWeek then [pairDate convertedSecondPairDate i] else [] )
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

        let dateRegex = Regex @"}{\d\d\.\d\d\.\d\d\d\d.?}"
        let newDate = $"}}{{{date}}}"
        let updatedText = dateRegex.Replace(text, newDate)

        File.WriteAllText(file, updatedText)
