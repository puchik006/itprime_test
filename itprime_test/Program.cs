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
            ulong _answer = 0;

            int _decimalSystem = 12; //cause count start from 0;

            int _sumOfNumbers = 72; // 12 * 6

            int _qntyOfNumbers = 12;

            ulong BeautyfullNumberCount(int summOfNumbers, int qntyOfNumbers)
            {
                ulong result = 0;

                if (qntyOfNumbers == 1)
                {
                    if (0 <= summOfNumbers && summOfNumbers <= _decimalSystem)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }

                for (int i = 1; i < qntyOfNumbers; i++)
                {
                    for (int j = 0; j <= _decimalSystem; j++)
                    {
                        result = result + BeautyfullNumberCount(summOfNumbers - j, i) - BeautyfullNumberCount(summOfNumbers - j, i - 1);
                    }
                }

                return result;

            }

            _answer = BeautyfullNumberCount(_sumOfNumbers, _qntyOfNumbers) * 13; // cause midle number can be any of 0-C;

            Console.WriteLine("Amount of beatyfull numbers is : " + _answer.ToString());

        }
    }
}
