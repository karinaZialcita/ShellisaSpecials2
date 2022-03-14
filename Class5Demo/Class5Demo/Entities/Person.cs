using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Class5Demo.Entities
{
    public abstract class Person
    {
        //Store the name in a backing variable
        protected string _name;
        //Property to front the backing variable
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Override default constructor
        public Person() => _name = "Jane Doe";
        public Person(string newName) => _name = newName;

        
        public void WakeUp() => WriteLine($"Wake up {_name}");


    }
}
