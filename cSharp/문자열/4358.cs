using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.cSharp.문자열
{
    internal class _4358
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> trees = new Dictionary<string, int>();
            int total = 0;
            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                if (trees.ContainsKey(input))
                    trees[input]++;
                else
                    trees[input] = 1;
                total++;

            }
            var sortedTrees = trees.OrderBy(x => x.Key).ToList(); ;
            foreach (var tree in sortedTrees)
            {
                double per = tree.Value / (double)total * 100;
                Console.WriteLine($"{tree.Key} {per:F4}");
            }
        }
    }
}
