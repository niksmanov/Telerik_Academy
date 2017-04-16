using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var priorityQueue = new PriorityQueue<int>();

            priorityQueue.Enqueue(4);
            priorityQueue.Enqueue(44);
            priorityQueue.Enqueue(2);
            priorityQueue.Enqueue(18);
            priorityQueue.Enqueue(656);
            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(23);

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
