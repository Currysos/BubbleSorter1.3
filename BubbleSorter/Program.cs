using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int delay;
            int visualize;
            bool isdone = false;
            int n3;
            Random rnd = new Random();
            int nia;
            int lown;
            int highn;
            int YN;
            int[] arr;

            Start();

            void Start()
            {
                Console.WriteLine("BubbleSorting");

                Console.WriteLine("Numbers in the array? ");
                string nias = Console.ReadLine();
                nia = Convert.ToInt32(nias);
                Console.Clear();

                arr = new int[nia];

                Console.WriteLine("Want to visualize the sorting?\n   Yes(1)  No(2)");
                string visualizes = Console.ReadLine();
                visualize = Convert.ToInt32(visualizes);
                Console.Clear();

                if (visualize == 1)
                {
                    Console.WriteLine("Delay? \nMore numbers in array requires less delay for it to sort" +
                        "\n Recomendations;" +
                        "\n     *10 numbers or less: 100 delay" +
                        "\n     *100 numbers or less: 10 delay" +
                        "\n     *500 numbers or less; 0 delay" +
                        "\n     *500 numbers or more: 0 delay" +
                        "\n");
                    string delays = Console.ReadLine();
                    delay = Convert.ToInt32(delays);
                }
                else
                {
                    delay = 0;
                }
                Console.Clear();

                Console.WriteLine("Lowest possible number? ");
                string lows = Console.ReadLine();
                lown = Convert.ToInt32(lows);

                Console.WriteLine("Highest highest number? ");
                string highs = Console.ReadLine();
                highn = Convert.ToInt32(highs);
                RandomizeArray();
                Console.Clear();

                if (visualize == 1)
                {
                    Console.WriteLine("Looks good?\n" +
                        "*Numbers in array: " + nia +
                        "\n*Delay; " + delay +
                        "\n*Array is from: " + lown + " to: " + highn +
                        "\n Yes(1)  No(2)");
                }
                else
                {
                    Console.WriteLine("Looks good?\n" +
                        "*Numbers in array: " + nia +
                        "\n*No Visualization" +
                        "\n*Array is from: " + lown + " to: " + highn +
                        "\n Yes(1)  No(2)");
                }

                string YNs = Console.ReadLine();
                YN = Convert.ToInt32(YNs);
                Console.Clear();

                if (YN == 1)
                {
                    printarray();
                    Console.WriteLine("\nYour array");

                    Console.WriteLine("\n\nGreen means done, red means working. The text may flash green, it means that that number is set to position" +
                        "\n\n\n                                         Start sorting, press enter");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Start();
                }
            }
            void RandomizeArray()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(lown, highn + 1);
                }
            }
            void printarray()
            {
                if (visualize == 1)
                {
                    Console.Clear();
                    foreach (int numbers in arr)
                    {
                        Console.Write(numbers + ",");
                    }
                    Thread.Sleep(delay);
                }
                else
                {
                    Console.Clear();
                    foreach (int numbers in arr)
                    {
                        Console.Write(numbers + ",");
                    }
                }
            }

            void bubblesorting()
            {
                while (isdone == false)
                {
                    isdone = true;
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            isdone = false;
                            n3 = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = n3;
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        if (isdone == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    if (visualize == 1)
                    {
                        printarray();
                    }
                }
            }
            if (visualize == 1)
            {
                bubblesorting();
            }


            if (visualize == 2)
            {
                bubblesorting();
                printarray();
            }

            Console.WriteLine("\nDone!" +
                "\nPress Enter to Exit");
            Console.ReadKey();
        }
    }
}
