using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Table", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Usando a A Expressão Lambda diretamente como Argumento do Método 'Sort'

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
