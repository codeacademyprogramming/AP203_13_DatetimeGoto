using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndDatetime
{
    internal struct Human
    {

        public Human(string name,string surname,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
