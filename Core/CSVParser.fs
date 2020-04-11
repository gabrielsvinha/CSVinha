namespace CSVinha.Core.CSVParser

open System.IO
open System.Collections

module Parser =
    let SerializeStream (stream: StreamReader) =
        printfn "Parse func"

    let Serialize (filePath: string) =
        use sr = new StreamReader (filePath)
        sr |> SerializeStream

    let TryDeserialize (csv: IDictionary) =
        printfn "deserialize"
