using System;

//В данной задаче будут рассматриваться 13-ти значные числа в тринадцатиричной системе исчисления (цифры 0,1,2,3,4,5,6,7,8,9, A, B, C) с ведущими нулями.
//Например, ABA98859978C0, 6789110551234, 0000007000000 Назовем число красивым, если сумма его первых шести цифр равна сумме шести последних цифр.
//Пример: Число 0055237050A00 - красивое, так как 0+0+5+5+2+3 = 0+5+0+A+0+0 Число 1234AB988BABA - некрасивое, так как 1+2+3+4+A+B != 8+8+B+A+B+A

//​Задача: написать программу печатающую в стандартный вывод количество 13-ти значных красивых чисел с ведущими нулями в тринадцатиричной системе исчисления. 

//В качестве решения должен быть предоставлено: 
//1) ответ - количество таких чисел.Ответ должен быть представлен в десятичной системе исчисления.
//2) исходный код программы.

namespace itprime_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tredecimal myTredecimal = new Tredecimal();

            //ulong beautyNumberCount = 0;
            //ulong beautyNumberCount2 = 0;

            //string maxTredecimalNumber = "9999";

            //int numberT = 11;

            //for (int i = 0; i < numberT; i++)
            //{
            //    for (int j = 0; j < numberT; j++)
            //    {
            //        if (SumOfNumbersInNumber(i) == SumOfNumbersInNumber(j))
            //        {
            //            beautyNumberCount++;

            //        }
            //    }
            //}


            //for (int i = 0; i < SumOfNumbersInNumber(numberT); i++)
            //{
            //    for (int j = 0; j <= numberT; j++)
            //    {

            //        if (SumOfNumbersInNumber(j) == i)
            //        {
            //            beautyNumberCount2++;
            //            //Console.WriteLine("beaty numbers count is : " + beautyNumberCount2 + " j = " + j + " i= " + i);
            //        }
            //    }
            //}

            int N1 (int k)
            {
                if (0 <= k && k <= 9 )
                {
                   return 1;
                }
                else
                {
                   return 0;
                }
            }


            int N2 (int k)
            {
                int res = 0;

                for (int i = 0; i <= 9; i++)
                {
                    res = res + N1(k - i);
                }

                return res;
            }

            int N3(int k)
            {
                int res = 0;

                for (int i = 0; i <= 9; i++)
                {
                    res = res + N2(k - i);
                }

                return res;
            }


            int N(int k, int n)
            {
                int res = 0;

                if (n == 1)
                {
                    if (0 <= k && k <= 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }

                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        res = res + N(k - j, i) - N(k-j,i-1);
                    }
                }

                return res;

            }

            int NNN = 24;


            Console.WriteLine("Amount of beaty numbers2 is : " + 
                 " N= " + N(NNN,3).ToString());

            //beautyNumberCount = beautyNumberCount * 12;

            //Console.WriteLine("Amount of beaty numbers is : " + beautyNumberCount);

            //Console.WriteLine(myTredecimal.ManySymbolTre2Dig("110"));
        }

        static int SumOfNumbersInNumber(int number)
        {
            int sumOfNumbers = 0;

            while (number > 0)
            {
                sumOfNumbers = sumOfNumbers + number % 10;
                number = number / 10;
            }

            return sumOfNumbers;
        }

    }

    public class Tredecimal
    {
        private int OneSymbolTre2Dig(string treNumber)
        {
            switch (treNumber)
            {
                case "0":
                    return 0;
                    
                case "1":
                    return 1;
                    
                case "2":
                    return 2;
                    
                case "3":
                    return 3;
                    
                case "4":
                    return 4;
                    
                case "5":
                    return 5;
                    
                case "6":
                    return 6;
                    
                case "7":
                    return 7;
                    
                case "8":
                    return 8;
                    
                case "9":
                    return 9;
                    
                case "A":
                    return 10;
                    
                case "B":
                    return 11;
                    
                case "C":
                    return 12;

            }
            return 0;
        }

        public int ManySymbolTre2Dig(string treNumber)
        {
            int digitNumber = 0;
            int oneSymbolLength = 1;
            int powerDegreeDown = 1;

            for (int i = 0; i < treNumber.Length; i++)
            {
                digitNumber = digitNumber + OneSymbolTre2Dig(treNumber.Substring(i, oneSymbolLength)) * (int)MathF.Pow(10, treNumber.Length - powerDegreeDown - i);
            }

            return digitNumber;
        }

    }
}
