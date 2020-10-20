using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceString
{
    class Program
    {
        static string MultilineInput()
        {
            Console.WriteLine("Enter a multiline input: ");
            string input = "";
            string sentence;
            do
            {
                sentence = Console.ReadLine();
                input += sentence + "\n";

            } while (sentence.Length > 0);
              
              return input;
        }

        static string ReplaceString(string line, string sStr, string rStr)
        {
            string[] words = line.Split(' ');
            for (int i=0; i<words.Length; i++)
            {
                if (words[i].Contains(sStr))
                {
                    if(words[i].Length == sStr.Length)
                    {
                        words[i] = rStr;
                    }
                    else if(words[i].IndexOf(sStr) == 0)
                    {
                        if(words[i][sStr.Length] == '.' || words[i][sStr.Length] == ',')
                        {
                            words[i] = words[i].Replace(sStr, rStr);
                        }

                    }
                }
            }
            line = string.Join(" ", words);
            return line;
        }

        static void Main(string[] args)
        {
            string strMulti = MultilineInput();
            Console.WriteLine(strMulti);

            Console.WriteLine("Enter a search-string: ");
            string sStr = Console.ReadLine();
            Console.WriteLine("Enter a replace-string: ");
            string rStr = Console.ReadLine(); 

            string[] lines = strMulti.Split('\n');
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = ReplaceString(lines[i], sStr, rStr);
            }
            
            strMulti=string.Join("\n", lines);
            Console.WriteLine(strMulti);

            Console.Read();
        }
    }
}
