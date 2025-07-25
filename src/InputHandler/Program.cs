using System;
using System.IO;

class Program
{
    static void Main()
    {
        string relativeuserinputPath = Path.Combine("..", "..", "..", "..", "..", "data", "user_input.txt");
        string userinputfilePath = Path.GetFullPath(relativeuserinputPath);

        Console.WriteLine("Enter your question:");
        string question = Console.ReadLine();
        File.WriteAllText(userinputfilePath, question);
    }
}