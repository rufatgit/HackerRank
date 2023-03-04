using System.Diagnostics;



Console.WriteLine("How many times you want to repeat process? ");

int test_cases = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < test_cases; i++)
{
    Console.WriteLine("What is limit? ");
    double limit =Convert.ToDouble(Console.ReadLine());

    Stopwatch sw = new Stopwatch();
    sw.Start();
    Console.WriteLine("Gauss Sum: " + Function(limit, 3, 5, 15));
    sw.Stop();
    Console.WriteLine("Elapsed total milliseconds with Gauss Sum: "+sw.Elapsed.TotalMilliseconds.ToString("N0"));

    Stopwatch sw2 = new Stopwatch();
    sw2.Start();
    Console.WriteLine("Brute Force way: " + Sum(limit));
    sw2.Stop(); 
    Console.WriteLine("Elapsed total milliseconds with Brute Force approach: "+sw2.Elapsed.TotalMilliseconds.ToString("N0"));


}

static double Gauss_Sum(double divisibility_number, double limit)
{
    double n = Math.Floor((limit - 1) / divisibility_number);
    double k = (n / 2)  * (n + 1);

    return divisibility_number * k;

}


static double Function(double limit, double three, double five, double fifteen)
{
    return Gauss_Sum(three, limit) + Gauss_Sum(five, limit) - Gauss_Sum(fifteen, limit);

}



static double Sum(double limit)
{
    double sum = 0;

    for (int i = 0; i < limit; ++i)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            sum += i;
        }


    }

    return sum;

}


