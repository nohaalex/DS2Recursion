using System;

namespace DS2Recursion
{
    public class DS2Recursion
    {
        public void Calculateiterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n--;
            }
        }

        public void Calculaterecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                Calculaterecursive(n - 1);
            }
        }

        public int nsum(int n)
        {
            return n * (n + 1) / 2;
        }

        public int iterativensum(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total += i;
                i++;
            }
            return total;
        }

        public int recursivensum(int n)
        {
            if (n == 0)
                return 0;
            return recursivensum(n - 1) + n;
        }


        public int iterativefactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }


        public int recursivefactorial(int n)
        {
            if (n == 0)
                return 1;

            return recursivefactorial(n - 1) * n;
        }
        public static void Main(string[] args)
        {
            DS2Recursion recursion=new DS2Recursion();
            Console.WriteLine("Calling iterative method");
            recursion.Calculateiterative(5);
            Console.WriteLine("\nCalling recursive method");
            recursion.Calculaterecursive(5);
            Console.WriteLine("\nCalling sum of n natural numbers function:"+recursion.nsum(5));
            Console.WriteLine("\nCalling sum of n natural numbers iterative function:"+recursion.iterativensum(5));
            Console.WriteLine("\nCalling sum of n natural numbers recursive function:"+recursion.recursivensum(5));
            Console.WriteLine("\nCalling factorial iterative function:{0}",recursion.iterativefactorial(5));
            Console.WriteLine("\nCalling factorial recursive function:"+recursion.recursivefactorial(5));   

            Console.ReadKey();
        }

       
    }
}