using System.Numerics;


internal class Program
{

    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            BigInteger n = Int64.Parse(Console.ReadLine());
            Console.WriteLine(BigInteger.Abs(Sum_sq_numbers(n) - Sq_sum_numbers(n)));


        }







    }

    public static BigInteger Sum_sq_numbers(BigInteger n)
    {
        return ((n * (n + 1) * (2 * n + 1)) / 6);  //sum of squares of first n numbers.
    }

    public static BigInteger Sq_sum_numbers(BigInteger n)
    {
        return BigInteger.Pow(((n * (n + 1)) / 2), 2);
    }


}
