using System;
using System.Linq;

namespace 최고의피자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 입력
            int n = int.Parse(Console.ReadLine()); // 토핑의 종류 수
            string[] price = Console.ReadLine().Split();
            int doughPrice = int.Parse(price[0]); // 도우의 가격
            int toppingPrice = int.Parse(price[1]); // 토핑의 가격
            int doughCalorie = int.Parse(Console.ReadLine()); // 도우의 열량

            int[] toppings = new int[n];
            for (int i = 0; i < n; i++)
            {
                toppings[i] = int.Parse(Console.ReadLine()); // 각 토핑의 열량
            }

            // 내림차순으로 토핑 정렬
            Array.Sort(toppings, (x, y) => y.CompareTo(x));

            // 초기 피자 가격과 열량 (도우만 있을 때)
            int totalPrice = doughPrice;
            int totalCalorie = doughCalorie;

            // 최고의 1원당 열량 계산 (초기값 설정)
            int maxCaloriePerWon = totalCalorie / totalPrice;

            // 토핑을 하나씩 추가하면서 1원당 열량을 계산
            foreach (int toppingCalorie in toppings)
            {
                totalPrice += toppingPrice;      // 토핑 추가로 가격 증가
                totalCalorie += toppingCalorie;  // 토핑 추가로 열량 증가

                int currentCaloriePerWon = totalCalorie / totalPrice; // 현재 1원당 열량

                // 1원당 열량이 같거나 높으면 계속 갱신
                if (currentCaloriePerWon >= maxCaloriePerWon)
                {
                    maxCaloriePerWon = currentCaloriePerWon; // 최대값 갱신
                }
                else
                {
                    break; // 더 이상 추가해도 이득이 없으면 중단
                }
            }

            // 결과 출력
            Console.WriteLine(maxCaloriePerWon);
        }
    }
}
