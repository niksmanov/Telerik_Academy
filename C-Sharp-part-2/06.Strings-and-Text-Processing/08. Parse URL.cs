using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class parseURL
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
        string resouce = string.Empty;

        Console.WriteLine("[protocol] = {0}", input[0]);
        Console.WriteLine("[server] = {0}", input[1]);
        for (int i = 2; i < input.Length; i++)
        {
            resouce += "/" + input[i];
        }
        Console.Write("[resource] = {0}", resouce);

    }
}


