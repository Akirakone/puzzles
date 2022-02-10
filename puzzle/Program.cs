using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(6);
            FirstNames();
        }
        //Random Array
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] randomInt = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomInt[i] = rand.Next(5, 25);
            }
            foreach (int random in randomInt)
            {
                Console.WriteLine(random);
            }

            int min = randomInt[0];
            int max = randomInt[0];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (randomInt[i] > max)
                {
                    max = randomInt[i];
                }
                else if (randomInt[i] < min)
                {
                    min = randomInt[i];
                }
                sum = sum + randomInt[i];
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min:  {min}");
            Console.WriteLine($"Sum:  {sum}");
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            int coinFlip = rand.Next(2);
            if (coinFlip == 1)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }

        }
        public static double TossMultipleCoins(int num)
        {
            double heads_ratio = 0;
            for (int i = 0; i < num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    heads_ratio = heads_ratio + 1;
                }
            }
            heads_ratio = heads_ratio / num;
            Console.WriteLine(heads_ratio);
            return heads_ratio;
        }

        public static void FirstNames()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            names.Add("Akira");
            names.Add("Ousmane");
            names.Add("Troy");

            Random rand = new Random();
            var randomized = names.OrderBy(item => rand.Next());

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length < 5)
                {
                    names.Remove(names[i]);
                }
            }
            foreach (string name in randomized)
            {
                Console.WriteLine(name);
            }

        }
    }
}

