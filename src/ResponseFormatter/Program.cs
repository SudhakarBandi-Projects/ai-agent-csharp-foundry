using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string relativeresponsefilePath = Path.Combine("..", "..", "..", "..", "..", "data", "response_raw.json");
        string responsefilePath = Path.GetFullPath(relativeresponsefilePath);

        string json = File.ReadAllText(responsefilePath);
        //JObject response = JObject.Parse(json);
        //string reply = response["choices"]?[0]?["text"]?.ToString()?.Trim();
        Console.WriteLine("\nAI Agent Response:\n------------------");
        Console.WriteLine(json);
    }
}