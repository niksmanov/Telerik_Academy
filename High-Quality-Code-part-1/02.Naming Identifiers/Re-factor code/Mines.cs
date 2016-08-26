namespace MinesGame
{
    using System;
    using System.Collections.Generic;

    internal class Mines
    {
        internal static void Main()
        {
            string commands = string.Empty;
            char[,] field = CreateBattleField();
            char[,] bombs = PlantBombs();
            int counter = 0;
            bool explode = false;
            List<PointsCount> champions = new List<PointsCount>(6);
            int row = 0;
            int col = 0;
            bool firstFlag = true;
            const int MaxResult = 35;
            bool secondFlag = false;

            do
            {
                if (firstFlag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Store(field);
                    firstFlag = false;
                }

                Console.Write("Daj red i kolona : ");
                commands = Console.ReadLine().Trim();
                if (commands.Length >= 3)
                {
                    if (int.TryParse(commands[0].ToString(), out row) &&
                    int.TryParse(commands[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        commands = "turn";
                    }
                }

                switch (commands)
                {
                    case "top":
                        Rankings(champions);
                        break;
                    case "restart":
                        field = CreateBattleField();
                        bombs = PlantBombs();
                        Store(field);
                        explode = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayersMove(field, bombs, row, col);
                                counter++;
                            }

                            if (MaxResult == counter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                Store(field);
                            }
                        }
                        else
                        {
                            explode = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");

                        break;
                }

                if (explode)
                {
                    Store(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string niknejm = Console.ReadLine();
                    PointsCount t = new PointsCount(niknejm, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((PointsCount r1, PointsCount r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((PointsCount r1, PointsCount r2) => r2.Points.CompareTo(r1.Points));
                    Rankings(champions);

                    field = CreateBattleField();
                    bombs = PlantBombs();
                    counter = 0;
                    explode = false;
                    firstFlag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvori 35 kletki bez kapka kryv.");
                    Store(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    PointsCount to4kii = new PointsCount(imeee, counter);
                    champions.Add(to4kii);
                    Rankings(champions);
                    field = CreateBattleField();
                    bombs = PlantBombs();
                    counter = 0;
                    secondFlag = false;
                    firstFlag = true;
                }
            }
            while (commands != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Rankings(List<PointsCount> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayersMove(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = Count(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void Store(char[,] board)
        {
            int length = board.GetLength(0);
            int height = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < height; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBattleField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlantBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] battleField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    battleField[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int col = i2 / cols;
                int row = i2 % cols;
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                battleField[col, row - 1] = '*';
            }

            return battleField;
        }

        private static void Calcultions(char[,] field)
        {
            int kol = field.GetLength(0);
            int red = field.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char kolkoo = Count(field, i, j);
                        field[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char Count(char[,] r, int rr, int rrr)
        {
            int counts = 0;
            int rows = r.GetLength(0);
            int cols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    counts++;
                }
            }

            if (rr + 1 < rows)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    counts++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    counts++;
                }
            }

            if (rrr + 1 < cols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    counts++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    counts++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < cols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    counts++;
                }
            }

            if ((rr + 1 < rows) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    counts++;
                }
            }

            if ((rr + 1 < rows) && (rrr + 1 < cols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    counts++;
                }
            }

            return char.Parse(counts.ToString());
        }

        internal class PointsCount
        {
            private string name;
            private int points;

            public PointsCount(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public PointsCount()
            {
            }

            public string Name
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int Points
            {
                get
                {
                    return this.points;
                }

                set
                {
                    this.points = value;
                }
            }
        }
    }
}
