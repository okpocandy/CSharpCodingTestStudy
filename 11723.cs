using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study
{
    internal class _11723
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                switch(inp[0])
                {
                    case "add":
                        {
                            if (!ls.Contains(int.Parse((inp[1]))));
                            {
                                ls.Add(int.Parse((inp[1])));
                            }
                            break;
                        }
                    case "remove":
                        {
                            if(ls.Contains(int.Parse((inp[1]))))
                            {
                                ls.Remove(int.Parse((inp[1])));
                            }
                            break;
                        }
                    case "check":
                        {
                            if (ls.Contains(int.Parse((inp[1]))))
                                sb.Append(1 + "\n");
                            else
                                sb.Append(0 + "\n");
                            break;
                        }
                    case "toggle":
                        {
                            if (ls.Contains((int.Parse((inp[1])))))
                                ls.Remove((int.Parse((inp[1]))));
                            else
                                ls.Add((int.Parse((inp[1]))));
                            break;
                        }
                    case "all":
                        ls = new List<int>{ 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
                        break;
                    case "empty":
                        ls.Clear();
                        break;
                }
                
            }
            Console.WriteLine(sb);
        }
    }
}
