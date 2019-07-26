using System;

namespace Encapsulation
{
    public class Person
    {
        // private = encapsulation; hiding information
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
