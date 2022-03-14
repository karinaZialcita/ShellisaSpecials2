using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class5Demo.Entities
{
    class PeopleList : ICollection
    {
        //Store the backing array for the collection
        private Person[] _people;

        //Store the count.
        private int _count;

        //Return the count
        public int Count { get { return _count; } }

        //Return a copy of this object
        public object SyncRoot { get { return this; } }

        //Property for Synchronziation
        public bool IsSynchronized { get { return false; } }

        //Constructor
        public PeopleList() { }

        public PeopleList(Person[] newPeopleArray)
        {
            _people = new Person[newPeopleArray.Length];
            _count = newPeopleArray.Length;

            for (int i = 0; i < newPeopleArray.Length; i++)
            {
                //Add each person internall
                _people[i] = newPeopleArray[i];
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_people[i], index++);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
