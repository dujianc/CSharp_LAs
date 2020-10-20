using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicePool
{
    public class Dice
    {
        //private int side;
        private Random r;
        public int Side { get; private set; }
       // public int Side { get => side; private set => side = value; }

        public Dice(int s)
        {
            Side = s;
            r = new Random();
        }

        public int Roll()
        {
            return r.Next(1, Side + 1);
        }

    }

        public class DicePool
    {
        public List<Dice> dicePool;
        public DicePool()
        { 
            dicePool = new List<Dice>();
        }

        public void Add(int s)
        {
            Dice newDice = new Dice(s);
            dicePool.Add(newDice);
        }
        public bool Remove(int s)
        {
            Dice delDice = dicePool.Find(a => a.Side == s);
            if(delDice != null)
            {
                dicePool.Remove(delDice);
                return true;
            }
            return false;
        }

        public int Roll(int s)
        {
            Dice findDice = dicePool.Find(a => a.Side == s);
            if (findDice == null)
            {
                return -1;
            }
            return findDice.Roll();
        }
        public int RollAll()
        {
            int sum = 0;
            int t;
            foreach(var d in dicePool)
            {
                t = d.Roll();
                Console.WriteLine("Dice with side: " + d.Side + " Roll Result: "+t);
                sum += t;
            }
            return sum;
        }
    }
    class Program
    {
    static void Main(string[] args)
    {
            string command;
            string[] words;
            DicePool dPool = new DicePool();
            int result;

            do
            {
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine();
                command = command.ToLower();
                command = command.Trim();
                while(command.Contains("  "))
                {
                    command.Replace("  ", " ");
                }
                    words = command.Split(' ');
                if (words[0] == "add")
                {
                    dPool.Add(int.Parse(words[1]));
                    Console.WriteLine(words[1] + " sided dice is added in the system.");
                }
                else if (words[0] == "roll")
                {
                    result = dPool.Roll(int.Parse(words[1]));
                    if (result == -1)
                    {
                        Console.WriteLine(words[1] + " sided dice is not available");
                    }
                    else
                    {
                        Console.WriteLine("Dice No: " + words[1] + " Roll result: " + result);
                    }
                }

                else if (words[0] == "remove")
                {
                    if (dPool.Remove(int.Parse(words[1])) == true)
                        Console.WriteLine("Dice No: " + words[1] + " is succefully removed from the system");
                    else
                    {
                        Console.WriteLine("Dice No: " + words[1] + " is not found");
                    }
                }

                else if (words[0] == "rollall")
                {
                    result = dPool.RollAll();
                    Console.WriteLine("Summation of all rools: " + result);

                }
                else
                {
                    Console.WriteLine("Please enter in correct format! ");
                }

            } while (command != "exit");
            
            
            
            //Dice obj6 = new Dice(6);
            //for (int i=0; i<10; i++)
            //{
            //    Console.WriteLine("Roll " + (i + 1) + " Result: " + obj6.Roll());
            //}
            //Console.ReadLine();
    }
    
    }

}





