using System;
using System.Collections.Generic;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //AdYas.Add("Okan", 27);
            //AdYas.Add("Sait", 18);


            //foreach (var isimler in AdYas)
            //{
            //    Console.WriteLine(isimler);
            //}

            MyDictionary<string, int> isimler = new MyDictionary<string, int>();
            isimler.Add("uğur",1);

            foreach (var item in isimler)
            {
                Console.WriteLine(isimler);
            }



        }
    }
}
