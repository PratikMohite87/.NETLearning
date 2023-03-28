using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // Use readonly structures in following cases :
    //      All fields are readonly.
    //      properties have only 'get' accessor
    //      There parameterized constructor that initializes all fields.
    //      U don't want to allow change to any field or property of the structure.
    //      Methods can read fields; but can't modify.
    //      Its feature of 8.0
    public readonly struct ReadOnlyStructure
    {
        private readonly string _characterName;

        public string CharacterName
        {
            get { return _characterName; }
        }

        public ReadOnlyStructure(string value)
        {
            _characterName = value;
        }

        public void PrintCharacterName()
        {
            Console.WriteLine(CharacterName);
        }
    }
}
