using System.Collections.Generic;

namespace Task3
{
    public class Node
    {
        private LinkedList<Node> children;

        public int Count { private set; get; }
        public char Data { private set; get; }

        public Node(char data = ' ')
        {
            this.Data = data;
            this.Count = 0;
            children = new LinkedList<Node>();
        }

        public Node GetChild(char c, bool createIfNotExist = false)
        {
            foreach (var child in children)
            {
                if (child.Data == c)
                {
                    return child;
                }
            }

            if (createIfNotExist)
            {
                return CreateChild(c);
            }

            return null;
        }

        public void AddCount()
        {
            this.Count++;
        }

        public Node CreateChild(char c)
        {
            var child = new Node(c);
            children.AddLast(child);

            return child;
        }
    }
}
