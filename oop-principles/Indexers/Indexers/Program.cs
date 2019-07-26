using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        // or you can initialize _dictionary in a constructor
        /*
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        */

        // declare an indexer is like declaring a property but an indexer doesn't have a name
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }

        }

        // if we son't implement an indexer then we need to create our own get and set methods
        /*
        public void SetItem(string key, string value)
        {

        }
        public string GetItem(string key)
        {
            return key;
        }
        */
    }


    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            // store a key-value pair
            cookie["name"] = "Jay";
            cookie["name1"] = "Teerapong";
            Console.WriteLine(cookie["name1"]);
        }
    }
}
