using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    internal class _17952
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<(int score, int time)> st = new Stack<(int, int)> ();
            int ans = 0;
            for(int i=0; i<n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (ints[0] == 0)
                {
                    if(st.Count > 0)
                    {
                        (int score, int time) = st.Pop();
                        time--;
                        if (time == 0)
                            ans += score;
                        else
                        {
                            st.Push((score, time));
                        }
                        

                    }
                }
                else if (ints[0] == 1)
                {
                    ints[2]--;
                    if (ints[2] == 0)
                        ans += ints[1];
                    else
                    {
                        st.Push((ints[1], ints[2]));
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
