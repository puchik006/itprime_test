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
            Tredecimal myTredecimal = new Tredecimal();

            ulong beautyNumberCount = 0;

            string maxTredecimalNumber = "111111";

            for (int i = 0; i <= myTredecimal.ManySymbolTre2Dig(maxTredecimalNumber); i++)
            {
                for (int j = 0; j <= myTredecimal.ManySymbolTre2Dig(maxTredecimalNumber); j++)
                {
                    if (SumOfNumbersInNumber(i) == SumOfNumbersInNumber(j))
                    {
                        beautyNumberCount++;
                        //Console.WriteLine("i = " + i + " j = " + j);
                    }
                }
            }

            Console.WriteLine("Amount of beaty numbers is : " + beautyNumberCount);

            beautyNumberCount = beautyNumberCount * 12;

            Console.WriteLine("Amount of beaty numbers is : " + beautyNumberCount);
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
                    break;
                case "1":
                    return 1;
                    break;
                case "2":
                    return 2;
                    break;
                case "3":
                    return 3;
                    break;
                case "4":
                    return 4;
                    break;
                case "5":
                    return 5;
                    break;
                case "6":
                    return 6;
                    break;
                case "7":
                    return 7;
                    break;
                case "8":
                    return 8;
                    break;
                case "9":
                    return 9;
                    break;
                case "A":
                    return 10;
                    break;
                case "B":
                    return 11;
                    break;
                case "C":
                    return 12;
                    break;
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
