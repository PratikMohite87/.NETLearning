// Structure : it is a COMPOSITE DATATYPE consisting of a number of elements of OTHER types.
//             its VALUE type, instance or object of struct are created in STACK.
//             it can contain : fields,
//                              properties,
//                              methods,
//                              constants,
//                              constructors,
//                              indexers,
//                              operators & even other types of structures.

using ClassLibrary1;
using System;

public struct MyStruct : Interface1
{
    #region Fields
    // Fields : can be declard private, public, internal.
    //          we can only declare cannot initialise, use constructor to initialise.
    //          NOTE : check c# 10 or greater version for initialisation of field in structure directly.
    public int x;
    public int y;
    //public int z = 10;      // C.T.ERROR.

    // However a struct can contain STATIC fields, which CAN BE initialized inside the struct.
    public static int z = 10;

    private int w;

    public string[] data;
    #endregion

    #region Properties
    public int W
    {
        get { return w; }
        set { w = value; }
    }
    #endregion

    #region Indexer
    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
    #endregion

    #region Constructors
    //A C# struct can declare constrcutor, but they MUST take parameters.
    //A default constructor (constructor without any parameters) are always provided to initialize the struct fields to their default values.

    public MyStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
        w = 10;
        data = new string[w];
    }

    //The parameterized constructors inside a struct can also be overloaded. 
    public MyStruct(int x)
    {
        this.x = x;
        this.y = x;
        w = 0;
        data = null;
    }


    // The 'this' operator can also be used in constructors and parameterized constructors can be chained inside a C# constructor
    //public MyStruct(int x, int y) : this(x+y)
    //{
    //    this.x = x;
    //    this.y = y;
    //}
    #endregion

    #region Methods
    //The methods can be either static or non-static.
    public void SetZ(int z)
    {
        MyStruct.z = z;
    }
    #endregion

    #region Static Methods
    //But static methods can access only other static members and they can't invoke by using an object of the structure.
    //They can invoke only by using the struct name.
    public static int ManipulateStaticField()
    {
        ++z;
        return z;
    }
    #endregion

    #region Method Overloading
    // Methods inside struct can also be OVERLOADED
    public void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetXY(int x)
    { 
        this.x = x;
        this.y = x;
    }

    #endregion

    #region Method From Interface
    // Just like classes, a C# struct can also implement from an interface
    public void Method()
    {
        Console.WriteLine("Method from interface");
    }
    #endregion

    #region Operator Overloading
    // The operators can be overloaded inside a C# structure also.
    // The same rules applicable with respect to a C# class is also applicable here.
    // Both unary and binary operators can be overloaded.

    public static MyStruct operator -(MyStruct myStruct)
    {
        MyStruct myStruct1 = new MyStruct();
        myStruct1.x = -myStruct.x;
        myStruct1.y = -myStruct.y;

        return myStruct1;
    }
    #endregion

    #region Destructor
    // Only Class type can contain destructors
    //~MyStruct() { }       // Error
    #endregion
}