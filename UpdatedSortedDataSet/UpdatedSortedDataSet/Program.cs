using System;

namespace Activity_SortedDataset
{
    class MySort
    {
        protected int[] x = new int[1000];
        protected int sz;
        public bool Sorted { get; private set; }
        public MySort()
        {

            sz = 0;
            Sorted = true;
        }
        public void AddItem(int val)
        {

            x[sz] = val;
            sz = sz + 1;
            Sorted = false;
        }
        public void AddRandomItems(int n)
        {

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                x[sz + i] = r.Next(1, 1000);
            }
            sz = sz + n;
            Sorted = false;
        }
        public void InsertionSort(int[] x, int n)
        {
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = x[i];
                j = i - 1;
                while (j >= 0 && x[j] > key)
                {
                    x[j + 1] = x[j];
                    j = j - 1;
                }
                x[j + 1] = key;
            }
        }
        public void DataSort()
        {
            if (Sorted == false)
            {
                InsertionSort(x, sz);
                Sorted = true;
            }
        }
        public void ShowArray()
        {
            for (int i = 0; i < sz; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
    }
    class MySearch : MySort
    {
        public MySearch()
        {

        }
        public int BinarySearch(int val, ref int count)
        {
            DataSort();
            int first = 0;
            int last = sz - 1;
            int mid;
            count = 1;
            while (first <= last)
            {

                mid = (first + last) / 2;
                if (val > x[mid])
                {
                    count++;
                    first = mid + 1;
                }
                else if (val < x[mid])
                {
                    count++;
                    last = mid - 1;
                }
                if (val == x[mid])
                {
                    count += 2;
                    return mid;
                }
                count++;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = new MySearch();
            int val;
            int n;
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("Example: ");
                Console.WriteLine("To add 5 random values: addrandom 5");
                Console.WriteLine("To add a single values: add 75");
                Console.WriteLine("To find a value in the sorted Dataset: search or find");
                Console.WriteLine("To view all array content: display");
                Console.WriteLine("To exit from the program: exit");

                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                if (cmdArgs[0] == "addrandom")
                {
                    n = int.Parse(cmdArgs[1]);
                    dataSet.AddRandomItems(n);
                    Console.WriteLine("\nRandom Value(s) added successfully");
                }
                else if (cmdArgs[0] == "add")
                {
                    val = int.Parse(cmdArgs[1]);
                    dataSet.AddItem(val);
                    Console.WriteLine("\nValue {0} added successfully", val);
                }
                else if (cmdArgs[0] == "display")
                {
                    dataSet.DataSort();
                    dataSet.ShowArray();
                }
                else if (cmdArgs[0] == "search" || cmdArgs[0] == "find")
                {
                    int comparison = 0, pos;
                    val = int.Parse(cmdArgs[1]);
                    pos = dataSet.BinarySearch(val, ref comparison);
                    if (pos != -1)
                    {
                        Console.WriteLine("\nSearch value found at index position: {0} with {1} search comparisons.", pos, comparison);
                    }
                    else
                    {
                        Console.WriteLine("\nUnsuccessful search with {0} search comparisons.", comparison);
                    }
                }
                else if (cmdArgs[0] == "exit")
                {
                    break;
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

