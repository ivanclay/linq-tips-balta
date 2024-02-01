using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_tips
{
    public class Program
    {

      

        static void Main(string[] args)
        {
            var fruits = new List<string>();
            fruits.Add("cereja");
            fruits.Add("abacaxi");
            fruits.Add("maça");
            fruits.Add("pessego");
            fruits.Add("pera");
            fruits.Add("coco");
            fruits.Add("coco");
            fruits.Add("coco");
            fruits.Add("banana");

            //10 SKIP
            foreach (var fruit in fruits.Skip(3))
                Console.WriteLine(fruit);

                //9 ULTIMO
                //Console.WriteLine(fruits.Last());

                //8 SINGLE
                //Console.WriteLine(fruits.Single()); //EXCEPTION
                //Console.WriteLine(fruits.Single(x => x == "abacaxi"));

                //7 WHERE
                //foreach (var fruit in fruits.Where(x => x == "coco"))
                //    Console.WriteLine(fruit);

                //6 TAKE
                //foreach (var fruit in fruits.Take(3))
                //Console.WriteLine(fruit);

                //5 ELEMENT AT -> pegar pelo indice
                //Console.WriteLine(fruits.ElementAt(5));

                //4 CONTAR
                //Console.WriteLine(fruits.Count);
                //Console.WriteLine(fruits.Count(x => x == "coco"));

                //3 Verificar se todos os elementos são de um tipo
                //Console.WriteLine(fruits.All(x => x == "coco"));

                //2 Verificar se 1 elemento existe
                //Console.WriteLine(fruits.Any(x => x == "amora"));

                //1 Primeiro elemento
                //Console.WriteLine(fruits.First());
                //Console.WriteLine(fruits.FirstOrDefault());
        }
    }
}
