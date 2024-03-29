﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTestsLab_1_2"), InternalsVisibleTo("WinFormsApp1")]

namespace Lab_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = -1;

            while (numberOfItems < 0)
            {
                Console.Write("Podaj liczbe przedmiotow: ");
                numberOfItems = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Podaj ziarno losowania: ");
            int seed = Convert.ToInt32(Console.ReadLine());

            List<Item> items = new List<Item>(numberOfItems);
            Random random = new Random(seed);

            double val = 0, weigh = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                val = random.Next(1, 11);
                weigh = random.Next(1, 11);
                items.Add(new Item(i, val, weigh));
            }

            foreach (Item it in items)
            {
                Console.WriteLine(it);
            }

            Console.Write("Podaj maksymalną pojemność: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            List<Item> sorted = Solve.solve(items, capacity);

            Console.WriteLine("Zapakowane:");

            val = 0;
            weigh = 0;

            foreach (Item it in sorted)
            {
                Console.WriteLine(it);
                val += it.value;
                weigh += it.weight;
            }
            Console.WriteLine("Calkowita wartość: " + val);
            Console.WriteLine("Całkowita waga: " + weigh);
        }
    }
}