
// It can be used to perform synchronous and asynchronous read and write operations.
// By the help of FileStream class, we can easily read and write data into file.

using System.Runtime.CompilerServices;

#region _  FileStream example: writing single & multiple byte(s) into file

FileStream fs = new FileStream("G:\\.NET Learnings\\FileIO\\FileStream_Learnings\\filestream_learning.txt", FileMode.OpenOrCreate);

// Writing single byte into file.
fs.WriteByte(65);

// Writing multiple bytes into file
for(int i = 66; i <= 70; i++)
{
    fs.WriteByte((byte)i);
}

// Closing the current stream and releasing any resource.
fs.Close();

#endregion

#region FileStream example: reading all bytes from file

FileStream fs2 = new FileStream("G:\\.NET Learnings\\FileIO\\TextFile.txt", FileMode.OpenOrCreate);

int j = 0;

while (( j = fs2.ReadByte()) != -1)
{
    Console.WriteLine((char)j);
}

// Closing the current stream and releasing any resource.
fs2.Close();

Console.ReadLine();

#endregion