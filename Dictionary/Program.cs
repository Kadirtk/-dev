using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> city = new MyDictionary<string, string>();
            city.Add("TR","Adana");
            city.Add("JP", "Akihabara");
            city.Add("US", "Miami");
            city.Add("CA", "Toronto");
            city.Add("UK", "London");
            city.Add("GR", "Berlin");
            city.Add("FR", "Paris");
            city.Add("RU", "Moscow");
            city.Add("HU", "Budapest");

            foreach (var item in city.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
