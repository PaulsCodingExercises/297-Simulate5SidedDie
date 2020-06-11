using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace _297_Simulate5SidedDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Approach 1");
            // as we need to generate lots of numbers in quick succession we want to use the same Random() as
            // any randoms created to close together will produce the same series of numbers

            Random rnd = new Random();
            List<int> results = new List<int>();
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);
            results.Add(0);

            Console.WriteLine("Generating distribution of numbers from rand7() 100,000,000 times");
            for (int i = 0; i < 100000001; i++)
            {
                int result = RandomNumberGenerator.rand7_approach1(rnd);
                results[result]++;

                if (i % 10000000 == 0 && i != 0)
                    Console.WriteLine("Generated " + i + " results");
            }

            WriteResults(results);

            Console.WriteLine("Generating distribution of numbers from rand5() 100,000,000 times");
            for (int i = 0; i < 100000001; i++)
            {
                int result = RandomNumberGenerator.rand5_approach1(rnd);
                results[result]++;

                if (i % 10000000 == 0 && i != 0)
                    Console.WriteLine("Generated " + i + " results");
            }

            WriteResults(results);


            Console.WriteLine("************************");
            Console.WriteLine("Approach 3");

            Console.WriteLine("Generating distribution of numbers from rand7() 100,000,000 times");
            for (int i = 0; i < 100000001; i++)
            {
                int result = RandomNumberGenerator.rand7_approach2(rnd);
                results[result]++;

                if (i % 10000000 == 0 && i != 0)
                    Console.WriteLine("Generated " + i + " results");
            }

            WriteResults(results);


            Console.WriteLine("Generating distribution of numbers from rand5() 100,000,000 times");
            for (int i = 0; i < 100000001; i++)
            {
                int result = RandomNumberGenerator.rand5_approach2(rnd);
                results[result]++;

                if (i % 10000000 == 0 && i != 0)
                    Console.WriteLine("Generated " + i + " results");
            }

            WriteResults(results);
        }

        private static void WriteResults(List<int> results)
        {
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(i + ": " + results[i]);
                results[i] = 0;
            }
        }
    }
}
