using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> meyveler = new MyDictionary<string>();
            meyveler.Add("Muz");
            meyveler.Add("Erik");
            meyveler.Add("Çilek");

            Console.WriteLine(meyveler.Count + " elemanlıdır.");

        }
    }
}
