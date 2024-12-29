using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _1713
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] students = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=1; i<=100; i++)
            {
                dic[i] = 0;
            }
            List<int> ls = new List<int>();
            foreach(int student in students)
            {
                if (ls.Count < n && !ls.Contains(student))
                {
                    ls.Add(student);
                    dic[student]++;
                }

                else if(ls.Count>=n && !ls.Contains(student))
                {
                    int delSut = ls.First();
                    foreach(var i in ls)
                    {
                        if (dic[i] < dic[delSut])
                        {
                            delSut = i;
                        }
                    }
                    ls.Remove(delSut);
                    dic[delSut] = 0;
                    ls.Add(student);
                    dic[student]++;
                }
                else if(ls.Contains(student))
                    dic[student]++;
            }
            ls.Sort();
            foreach(int student in ls)
                Console.WriteLine(student);
        }
    }
}
