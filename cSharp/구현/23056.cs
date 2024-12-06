using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.구현
{
    class _23056
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0];
            int m = nm[1];
            int[] parti = new int[n+1];
            List<(int Class, string Name)> blue = new List<(int, string)>();
            List<(int Class, string Name)> white = new List<(int, string)>();
            while (true)
            {
                var inputs = Console.ReadLine().Split();
                if (inputs[0] == "0" && inputs[1] == "0")
                    break;
                int gr = int.Parse(inputs[0]);
                string name = inputs[1];
                if (parti[gr] <= (m-1))
                {
                    parti[gr]++;
                    if(gr%2 == 0)
                    {
                        white.Add((gr,name));
                    }
                    else
                    {
                        blue.Add((gr, name));
                    }
                }
            }
            PrintSortedStudents(blue);
            PrintSortedStudents(white);

            static void PrintSortedStudents(List<(int Class, string Name)> students)
            {
                var sortedStudents = students
                    .OrderBy(student => student.Class)
                    .ThenBy(student => student.Name.Length) // 이름 길이 순으로 정렬
                    .ThenBy(student => student.Name)        // 이름 사전순으로 정렬
                    .ToList();

                // 결과 출력
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"{student.Class} {student.Name}");
                }
            }

        }
    }
}
