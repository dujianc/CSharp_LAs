using System;

namespace Activity_5_1_2
{
    class GeneratePrimes
    {
        Random r;
        public GeneratePrimes()
        {
            r = new Random();
        }
        private bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for(int i=2; i<=n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public void Prime()
        {
            int val;
            do
            {
              val = r.Next(1, 1000);
            } while (IsPrime(val));
            
            Console.WriteLine("Random Prime: ",+val);
        }

        public void Prime(int n)
        {
            int val;
            Console.WriteLine(n+" Random Prime: ");
            for (int i=0; i<n; i++)
            {
               do
            {
                val = r.Next(1, 1000);
            } while (IsPrime(val));
                Console.Write(val + " ");
            }
             Console.WriteLine();

        }
        public void Prime(int a, int b)
        {
            //int val;
            Console.WriteLine("All primes in the range "+a+" to "+b+": ");
            for (int i = a; i < b; i++)
            {
                if (IsPrime(i))
               
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void Prime(int c, int a, int b)
        {
           // int val;
            Console.WriteLine("The first "+c+" primes in the range " + a + " to " + b + ": ");
            for (int i = a; i < b; i++)
            {
                if (IsPrime(i))
                {
                   Console.Write(i + " ");
                   c--;
                }
                if (c == 0) break;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int val, a, b, c;
            var p = new GeneratePrimes();
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("Example: ");
                Console.WriteLine("To generate a random prime: prime");
                Console.WriteLine("To generate 5 random primes: prime 5");
                Console.WriteLine("To generate all primes in the range (10 to 20): prime 10 20");
                Console.WriteLine("To generate first 5 primes in the range (10 to 100): prime 5 10 100");
                Console.WriteLine("To exit from the program: exit");

                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                else if (cmdArgs[0] == "exit") return;
                else if (cmdArgs.Length == 1)
                {
                    if (cmdArgs[0] == "prime")
                    {
                        p.Prime();
                    }
                    else continue;
                }
                else if (cmdArgs.Length == 2)
                {
                    if (cmdArgs[0] == "prime")
                    {
                        val = int.Parse(cmdArgs[1]);
                        p.Prime(val);
                    }
                    else continue;
                }
                else if (cmdArgs.Length == 3)
                {
                    if (cmdArgs[0] == "prime")
                    {
                        a = int.Parse(cmdArgs[1]);
                        b = int.Parse(cmdArgs[2]);
                        p.Prime(a, b);
                    }
                    else continue;
                }
                else if (cmdArgs.Length == 4)
                {
                    if (cmdArgs[0] == "prime")
                    {
                        c = int.Parse(cmdArgs[1]);
                        a = int.Parse(cmdArgs[2]);
                        b = int.Parse(cmdArgs[3]);
                        p.Prime(c, a, b);
                    }
                    else continue;
                }
                else
                {
                    Console.WriteLine("\nUnknown Command!. Please enter command in proper format.");
                }

                Console.ReadKey();
            }
        }
    }
}
