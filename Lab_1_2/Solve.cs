﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    internal class Solve
    {
        public static List<Item> solve(List<Item> items, double capacity)
        {
            List<Item> selected = new List<Item>();
            double currentWeight = 0;
            List<Item> sorted = items.OrderByDescending(item => item.ratio).ToList();

            foreach (Item it in sorted)
            {
                if (currentWeight + it.weight <= capacity)
                {
                    selected.Add(it);
                    currentWeight += it.weight;
                }
            }

            return selected;
        }
    }
}
