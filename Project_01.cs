using System;

namespace STEP_2
{
    internal class Project_01
    {
        public void A046_MinMax()
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            Console.Write("인원수 를 입력하세요 : (명)");
            int nPerson = int.Parse(Console.ReadLine());

            for (int i=0; i < nPerson; i++)
            {
                Console.Write("키 입력 : (단위: cm): ");
                double h = double.Parse(Console.ReadLine());
                if (h > max)
                    max = h;
                if (h < min)
                    min = h;
                sum += h;
            }

            Console.WriteLine("평균:{0}cm, 최대:{1}cm, 최소:{2}cm", sum / nPerson, max, min);
        }

        // x의 y승을 구하는 프로그램 (x,y는 양의 정수)
        public void A047_Power()
        {
            Console.WriteLine("x의 y승을 계산합니다.");
            Console.Write(" x를 입력하세요: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" y를 입력하세요: ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;
            for (int i=0; i < y; i++)
            {
                pow *= x;
                Console.WriteLine("{0}의 {1}승은 {2}입니다.", x, y, pow);
            }
        }

        // 팩토리얼 구하기
        public void A048_Factorial()
        {
            Console.WriteLine("n!을 계산합니다.");
            Console.Write("정수 n을 입력하세요: ");
            int n = int.Parse(Console.ReadLine());
            
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            // 입력한 값 (n) 1*n,*n,*n.... 으로 계산된다.
            Console.WriteLine("{0} != {1}", n, fact);
        }

        // 소수 판단하기
        public void A049_PrimeNumber()
        {
            // 정수 입력받아, 그 수가 소수인지 아닌지를 판별한다.
            // 소수는 1과 자신 외에는 나누어지지 않는 수이다.
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int index;

            for (index = 2; index < num; index++)
            {
                if (num % index == 0)
                {
                    Console.WriteLine("{0}는 소수가 아닙니다.", num);
                    break;
                }
            }
            // break 문 안타고, 여기로 오면 소수임.
            if (index == num)
                Console.WriteLine("{0}는 소수입니다.", num);
        }

        // 반복문을 이용하여, 라이프니츠의 원주율 공식을 프로그램
        public void A050_FindingPI()
        {
            bool sign = false;
            double pi = 0.0;

            // 반복 횟수가 많아질수록, 정확한 원주율 값과 가까워진다.
            for (int i=1; i <= 10000; i += 2)
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }

                Console.WriteLine("i={0}, PI={1}", i, 4*pi);
            }
        }
    }
}
