#region TextWriter

// C# TextWriter class is an abstract class.
// It is used to write text or sequential series of characters into file.

using (TextWriter writer = File.CreateText("G:\\.NET Learnings\\FileIO\\TextFile.txt"))
{
    writer.WriteLine("Hello C#");
    writer.WriteLine("C# File Handling by JavaTpoint");
}
Console.WriteLine("Data written successfully...");

#endregion

#region TextReader

// It represents a reader that can be used to read text or sequential series of characters.

// Reading all data of file.
using (TextReader tr = File.OpenText("G:\\.NET Learnings\\FileIO\\TextFile.txt"))
{
    Console.WriteLine(tr.ReadToEnd());
}

// Reading single line
using (TextReader tr = File.OpenText("G:\\.NET Learnings\\FileIO\\TextFile.txt"))
{
    Console.WriteLine(tr.ReadLine());
}

#endregion