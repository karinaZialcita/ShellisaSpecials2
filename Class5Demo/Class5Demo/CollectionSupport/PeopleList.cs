using Class5Demo.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class5Demo.CollectionSupport
{
    class PeopleList : ICollection
    {
        //store the backing array for the collection
        private Person[] _people;
        //store the count
        private int _count;

        //return the count
        public int Count { get { return _count; } }
        
        //return a copy of this object
        public object SyncRoot { get { return this; } }

        //property for sychronization
        public bool IsSynchronized { get { return false; } }

        //constructor
        public PeopleList() { }

        public PeopleList(Person[] newPeopleArray)
        {
            _people = new Person[newPeopleArray.Length];
            _count = newPeopleArray.Length;

            for(int i = 0; i < newPeopleArray.Length; i++)
            {
                //add each person interally
                _people[i] = newPeopleArray[i];
            }
        }


        public void CopyTo(Array array, int index)
        {
            for(int i = 0; i < Count; i++)
            {
                //expand the array by one
                array.SetValue(_people[i], index++);
            }


        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
