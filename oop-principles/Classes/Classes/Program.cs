using System;

namespace Classes
{
    public class Person {

        public string Name;

        public void Intrtoduce(string to) {

            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // static class member to create an object 
        public static Person Parse(string str) {
            var person = new Person();
            person.Name = str;

            return person;
        
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create an instance class member
            /*
            var person = new Person();
            person.Name = "Jay";
            person.Intrtoduce("John");
            */

            // create a static class member
            var person = Person.Parse("John");
            person.Intrtoduce("Jay");   
        }
    }
}
