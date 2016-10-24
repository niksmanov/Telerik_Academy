using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;

        private static object locker = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void WriteTime()
        {
            Console.WriteLine($"Now is {DateTime.Now}");
        }
    }
}
