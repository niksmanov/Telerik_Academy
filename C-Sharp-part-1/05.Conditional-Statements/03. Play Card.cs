using System;

  class playCard
    {
        static void Main()
        {
            string cards = Console.ReadLine();

            switch (cards)
            {
                case "2": Console.WriteLine("yes {0}", cards); break;
                case "3": Console.WriteLine("yes {0}", cards); break;
                case "4": Console.WriteLine("yes {0}", cards); break;
                case "5": Console.WriteLine("yes {0}", cards); break;
                case "6": Console.WriteLine("yes {0}", cards); break;
                case "7": Console.WriteLine("yes {0}", cards); break;
                case "8": Console.WriteLine("yes {0}", cards); break;
                case "9": Console.WriteLine("yes {0}", cards); break;
                case "10": Console.WriteLine("yes {0}", cards); break;
                case "J": Console.WriteLine("yes {0}", cards); break;
                case "Q": Console.WriteLine("yes {0}", cards); break;   
                case "K": Console.WriteLine("yes {0}", cards); break;
                case "A": Console.WriteLine("yes {0}", cards); break;
                default: Console.WriteLine("no {0}", cards); break;
            }
        }

    }
