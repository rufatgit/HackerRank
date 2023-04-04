
namespace _3_Largest_prime_factor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  List<long> check_before_prime = List_of_prime(50000);

              int t = Convert.ToInt32(Console.ReadLine());
              for (int a0 = 0; a0 < t; a0++)
              {

                  long n = Convert.ToInt64(Console.ReadLine());
                  //check_before_prime.ForEach(Console.WriteLine);  
                  if (n == 1)
                  {
                      continue;
                  }
                  if (check_before_prime.Contains(n))
                  {
                      Console.WriteLine(n);
                      continue;
                  }


                  List<long> list_prime_number = List_of_prime(n);
                  List<long> list_prime_factors = Find_Prime_Factors(n, list_prime_number);

                  Console.WriteLine(Show_Largest(list_prime_factors));
              }
  */
            long limit = Convert.ToInt64(Console.ReadLine());
            long max_possible_divisibility = (long)Math.Sqrt(limit);
            for (long i = 2; i <= max_possible_divisibility; i++)
            {
                if (limit%i==0)
                {
                    limit = limit / i;
                    i = 1;
                    max_possible_divisibility = (long)Math.Sqrt(limit);
                }
            }
            Console.WriteLine(limit);



        }


        public static long Show_Largest(List<long> list_prime_factors)
        {
            long largest=list_prime_factors[0];

            for (int i = 1; i < list_prime_factors.Count; i++)
            {
                if (list_prime_factors[i]>largest)
                {
                    largest=list_prime_factors[i];
                }
            }

            return largest;


        }


        public static List<long> Find_Prime_Factors(long dividend, List<long> list_divisor)
        {
            List<long> prime_factors= new List<long>(); 

            for (int i = 0; i < list_divisor.Count; i++)
            {
                while (dividend%list_divisor[i]==0)
                {
                    dividend=dividend/list_divisor[i];
                    prime_factors.Add(list_divisor[i]);
                }
            }

            
            return prime_factors;
        }

        public static List<long> List_of_prime(long n)
        {
            //n = Convert.ToInt64(Math.Floor(Math.Sqrt(Convert.ToDouble(n))));


            List<long> prime_list = new List<long>();
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }

                    if (counter > 2)
                    {
                        break;
                    }

                }
                if (counter == 2)
                {
                    prime_list.Add(i);
                }
                counter = 0;

            }

            return prime_list;

        }





    }






}




