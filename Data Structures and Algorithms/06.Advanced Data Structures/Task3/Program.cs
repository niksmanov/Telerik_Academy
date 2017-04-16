using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var trie = new Trie();
            var output = new List<string>();

            var wordsCount = 0;

            using (var reader = new StreamReader("../../someText.txt"))
            {
                var text = reader.ReadLine();
                var word = string.Empty;

                foreach (var letter in text)
                {
                    if (letter == ' ')
                    {
                        wordsCount += 1;
                        trie.AddWord(word);
                        if (!output.Contains(word))
                        {
                            output.Add(word);
                        }
                        word = string.Empty;
                    }
                    else
                    {
                        word += letter;
                    }
                }
            }

            Console.WriteLine($"In the text has: {wordsCount} words");

            foreach (var word in output)
            {
                var count = trie.GetCount(word);
                var timesString = count == 1 ? "time" : "times";
                Console.WriteLine($"\"{word}\" exists {count} {timesString}");
            }
        }
    }
}
