using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class addingPolynomials
{
    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[firstPolynomial.Length];
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] firstInput = Console.ReadLine().Split(' ');
        int[] firstPolynomial = new int[n];
        string[] secondInput = Console.ReadLine().Split(' ');
        int[] secondPolynomial = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstPolynomial[i] = int.Parse(firstInput[i]);
            secondPolynomial[i] = int.Parse(secondInput[i]);
        }

        Console.WriteLine(String.Join(" ", AddPolynomials(firstPolynomial, secondPolynomial)));

    }
}
