using System;

/*
 * Problem 16.** Bit Exchange (Advanced)
 * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned
 * integer. The first and the second sequence of bits may not overlap. 
 */

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q:");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k:");
        int k = int.Parse(Console.ReadLine());

        int p1 = p;
        int p2 = p + 1;
        int p3 = p + k - 1;
        int p4 = q;
        int p5 = q + k;
        int p6 = q + k - 1;
        int v1, v2, v3, v4, v5, v6;
        v1 = ((1 << p1) & n) != 0 ? 1 : 0;
        v2 = ((1 << p2) & n) != 0 ? 1 : 0;
        v3 = ((1 << p3) & n) != 0 ? 1 : 0;
        v4 = ((1 << p4) & n) != 0 ? 1 : 0;
        v5 = ((1 << p5) & n) != 0 ? 1 : 0;
        v6 = ((1 << p6) & n) != 0 ? 1 : 0;
        n = (v1 == 0) ? (~(1 << p4) & n) : ((1 << p4) | n);
        n = (v2 == 0) ? (~(1 << p5) & n) : ((1 << p5) | n);
        n = (v3 == 0) ? (~(1 << p6) & n) : ((1 << p6) | n);
        n = (v4 == 0) ? (~(1 << p1) & n) : ((1 << p1) | n);
        n = (v5 == 0) ? (~(1 << p2) & n) : ((1 << p2) | n);
        n = (v6 == 0) ? (~(1 << p3) & n) : ((1 << p3) | n);
        Console.WriteLine("Result is :" + n);
    }
}

