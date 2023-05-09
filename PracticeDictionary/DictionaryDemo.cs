using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionary
{
    public class DictionaryDemo
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public void MethodDictionary()
        {
            //Add
            dictionary.Add("1", "Mansi");
            dictionary.Add("2", "Mohan");
            dictionary.Add("3", "Komal");
            dictionary.Add("4", "Lucky");
            Console.WriteLine(dictionary["3"]);
            Console.WriteLine(dictionary["4"]);
            //Edit
            dictionary["2"] = "Nikita";
            dictionary["3"] = "John";
            //Remove
            dictionary.Remove("2");
            dictionary.Remove("4");
            foreach (KeyValuePair<string, string> key in dictionary)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }
            if (dictionary.ContainsKey("3"))
            {
                dictionary["3"] = "AAAA";
            }
            foreach (KeyValuePair<string, string> key in dictionary)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(40, "Bruce");
            dict.Add(41, "Lily");
            dict[42] = "ABCD";
            foreach (KeyValuePair<int, string> key in dict)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }
        }
    }
}
