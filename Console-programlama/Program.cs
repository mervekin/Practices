using System;

namespace Console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name=Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string  lastname=Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " "+ lastname);
        }
    }
}
