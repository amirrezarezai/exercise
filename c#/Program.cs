using System;

namespace HelloWorld
{
  using System;

class Program
{
    static void Main(string[] args)
    {
        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        Array.Sort(cities, (str1, str2) =>
        {
            if (str1.Length == str2.Length)
                return string.Compare(str1, str2);
            else
                return str1.Length.CompareTo(str2.Length);
        });

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Console.ReadLine();
    }
}
}