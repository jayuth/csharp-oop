using System;

namespace Properties
{

    public class Person
    {
        // when using auto-implemented properties, we don't need to declare a field
        // private set - the value of Birthdate can be set only once 
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }

        // since private set is defined, we need to initialize the Birthdate field through a constructor 
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;

        }

        // we don't implement autom-implemented proptery here bc the value of 'age' depends on the Birthdate property 
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1991, 8, 4));
            Console.WriteLine(person.Age);
        }
    }
}
