namespace Task3
{
    public class Trie
    {
        private Node head;

        public Trie()
        {
            head = new Node();
        }

        public void AddWord(string word)
        {
            Node current = head;

            current = current.GetChild(word[0], true);

            for (int i = 1; i < word.Length; i++)
            {
                current = current.GetChild(word[i], true);
            }

            current.AddCount();
        }

        public int GetCount(string word)
        {
            Node current = head;

            foreach (char c in word)
            {
                current = current.GetChild(c);

                if (current == null)
                {
                    return 0;
                }
            }

            return current.Count;
        }
    }
}
