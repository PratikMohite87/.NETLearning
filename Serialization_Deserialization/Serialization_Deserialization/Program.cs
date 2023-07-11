// Serialization is the process of converting the state of an object into a form that can be persisted or transported.

// Serialization is the process of converting object into byte stream so that it can be saved to memory, file or database.

// The reverse process of serialization is called deserialization.

using System.Runtime.Serialization.Formatters.Binary;

// This attribute needs to put to the class whose object can be serialised in future for transport purpose, else it will throw error will serializing.
[Serializable]
class Student
{
    public int rollno;
    public string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class SerializeExample
{
    public static void Main(string[] args)
    {
        #region Serialize

        Student s = new Student(101, "sonoo");

        FileStream stream = new FileStream("G:\\.NET Learnings\\Serialization_Deserialization\\Serialization_Deserialization\\serializedObject.txt", FileMode.OpenOrCreate);

        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, s);

        stream.Close();

        #endregion

        #region Deserialize

        FileStream stream2 = new FileStream("G:\\.NET Learnings\\Serialization_Deserialization\\Serialization_Deserialization\\serializedObject.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter2 = new BinaryFormatter();

        Student s1 = (Student)formatter2.Deserialize(stream2);
        Console.WriteLine("Rollno: " + s1.rollno);
        Console.WriteLine("Name: " + s1.name);

        #endregion

        stream2.Close();
    }
}