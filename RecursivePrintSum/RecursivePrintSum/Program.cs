using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePrintSum
{
    class Program
    {
        static void DisplayList(List<int> myList, int space)
        {
            if (myList.Count >= 1)
            {
                for(int i=0; i<space; i++)
                {
                    Console.Write("  ");
                }
                foreach(var item in myList)
                {
                    Console.Write(string.Format("{0,3}",item) + " ");
                }
                Console.WriteLine();
            }

            List<int> newList = new List<int>();
            for (int i=0; i < myList.Count - 1; i++)
            {
                newList.Add(myList[i] + myList[i + 1]);
            }
            if (newList.Count >= 1)
            {
                DisplayList(newList, space+1);
            }
        }

        static void Main(string[] args)
        {
            List<int> myList =  new List<int>(){ 1,3,5,2,4};
            DisplayList(myList, 0);

            Console.Read();

        }
    }
}
