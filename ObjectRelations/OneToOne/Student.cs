using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class Student
    {
        public int StudentId { set; get; }
        public string Name { set; get; }
        public Branch Branch { set; get; }      // One-To-One Relationship.
        public List<Examination> examinations { set; get; }     // One-To-Many Relationship.
    }
}
