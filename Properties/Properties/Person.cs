using System;
namespace Properties
{
    class Person
    {
        public Person(int age)
        {

            Age = age;
        }
        public int Age { get; private set; }

      
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        if (value > 0)
        //            age = value;
        //        else
        //            age = 0;
        //    }
        //}
    }
}
