#region StreamWriter

// C# StreamWriter class is used to write characters to a stream in specific encoding.
// It inherits TextWriter class.
// It provides overloaded write() and writeln() methods to write data into file.

FileStream fs = new FileStream("G:\\.NET Learnings\\FileIO\\TextFile.txt", FileMode.Open);

// Will be used to write characters to a FileStream "fs" created above.
StreamWriter sw = new StreamWriter(fs);

// Writes string to the stream.
sw.Write("hELLO aLL");

sw.Close();

fs.Close();

#endregion

#region StreamReader

// C# StreamReader class is used to read string from the stream.
// It inherits TextReader class.

FileStream fs2 = new FileStream("G:\\.NET Learnings\\FileIO\\TextFile.txt", FileMode.Open);

StreamReader sr = new StreamReader(fs2);

// Reading single line.
Console.WriteLine(sr.ReadLine());

string line = "";

// Reads all the lines
while ((line = sr.ReadLine()) != null)
{
    Console.WriteLine(line);
}

sr.Close();

fs2.Close();

#endregion