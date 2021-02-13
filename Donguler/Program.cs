using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

          


            string kurs1 = "Yazılım geliştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            // array- dizi

            string[] kurslar = new string[] {"Yazılım geliştirme kampı","Programlamaya başlangıç için temel kurs","java","Python","c#"};

            
            for (int i = 0; i <kurslar.Length; i++)   // i=i+2
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)        // forech dizilerde kullanılır. --> Dizileri daha kolay dolaşmayı sağlar
            {
                Console.WriteLine(kurs);
                    
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
