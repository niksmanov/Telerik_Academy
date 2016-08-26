using System;


class bitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte q = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());

        if ((q > p + k - 1) || (p > q + k - 1))
        {
            for (int i = 0; i < k; i++)
            {
                uint bitP = (uint)(n & (1 << p)) >> p;
                uint bitQ = (uint)(n & (1 << q)) >> q;

                n &= (uint)(~(1 << q));
                n |= (uint)(bitP << q);

                n &= (uint)(~(1 << p));
                n |= (uint)(bitQ << p);

                p++;
                q++;
            }
            Console.WriteLine(n);
        }
    }
}
