// C# BinaryWriter class is used to write binary information into stream.
// 

using (BinaryWriter writer = new BinaryWriter(File.Open("G:\\.NET Learnings\\FileIO\\BinaryFile.dat", FileMode.Create)))
{

    writer.Write(12.5);
    writer.Write("this is string data");
    writer.Write(true);
}

using (BinaryReader reader = new BinaryReader(File.Open("G:\\.NET Learnings\\FileIO\\BinaryFile.dat", FileMode.Open)))
{
    Console.WriteLine("Double Value : " + reader.ReadDouble());
    Console.WriteLine("String Value : " + reader.ReadString());
    Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
}