using System;

namespace STEP_2
{
    internal class Project_02
    {
        // 무한루프와 break 문
        public void A051_InfiniteLoop()
        {
            int sum = 0;
            int days = 1;
            int money = 1000;

            while (true)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000) break;
                days++;
                money *= 2;
            }
            // ### : 10진수 자리 표시자
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);

            for (sum = 0, days = 1, money = 1000; ; days++, money*=2)
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C}, sum = {2,11:C}", days, money, sum);
                if (sum >= 1000000) break;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);
        }

        // 합계가 10000이 넘는 순간, break문 사용하여 빠져나오고, 이때까지 합을 구한다.
        public void A052_UsingBreak()
        {
            int sum = 0;
            for (int i=1; ; i++)
            {
                sum += i;
                if (sum >= 10000)
                {
                    Console.WriteLine("1~{0}의 합 = {1}", i, sum);
                    break;
                }
            }

            sum = 0;
            int index = 1;
            for (; sum < 10000; index++)
            {
                sum += index;
            }
            // 10000 이 넘으면 for문 빠져나오는데, 이때 index 값은 10001 이기때문에, -1 을 해서 출력한다.
            Console.WriteLine("1~{0}의 합 = {1}", index - 1, sum);
        }

        // 다중 반복문으로 1~n까지의 팩토리얼과 합 구하기
        public void A053_SumOfFactorials()
        {
            Console.Write("숫자를 입력(첫 반복문 값): ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j=2; j <= 1; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2} != {1,10:#,#}", i, fact); // 세자리마다 소수점 표시
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:N0}\n", n, sum);
        }

        // 다중 루프를 이용하여 구구단 출력
        public void A054_TimesTable()
        {
            for (int y=1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                {
                    Console.Write("{0}x{1}={2,2}   ", x, y, x * y);
                }

                Console.WriteLine();
            }
        }

        // 1000까지의 소수를 출력하고 몇 개인지 출력
        // 소수는 1과, 자기 자신 외에는 나누어지지않는 숫자이다.
        public void A055_PrimeNumbers()
        {
            int index;
            int primes = 0;

            for (int i=2; i<1000; i++)
            {
                for (index = 2; index < i; index++)
                {
                    if (i % index == 0) break;
                }
                if (index == i) // i가 소수라면 
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n": "");
                    // 15개 마다 줄 바꿈한다.
                }
            }
            Console.WriteLine("\n2부터 1000 사이의 소수의 개수 : {0}개", primes);
        }

        // 이중 루프와 피라미드 출력
        public void A056_LoopPyramid()
        {
            // (1)
            for (int i=1; i<=5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (2)
            for (int i=1; i <= 5; i++)
            {
                for (int j=1; j <= 2 * i -1; j++)
                {
                    Console.Write("*");
                    Console.WriteLine();
                }
            }

            // (3)
            for (int i=5; i >= 1; i--)
            {
                for (int j=1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            // (4)
            for (int i=1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j=1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
                
            // (5) 
            for (int i=1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (6)
            for (int i=5; i >= 1; i--)
            {
                for (int j=1; j <= 5 - i; j++)                
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
