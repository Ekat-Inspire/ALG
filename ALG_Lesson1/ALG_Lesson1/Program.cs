using System;


namespace task1
{
    class Program
    {
        public class Lesson1task1
        {
            static string CheckNumber(long number) // Метод по блок-схеме
            {

                long d = 0;
                long i = 2;
                while (i < number)
                {
                    if (number % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (d == 0)
                {
                    return "Простое число!";
                }
                else
                {
                    return "Не простое число!";
                }


                static void Main(string[] args) // вывод результатов
                {
                    Console.Write("Введите число: ");
                    long n = long.Parse(Console.ReadLine());

                    string test = CheckNumber(n);
                    Console.WriteLine(test);
                }
            }
        }

    }

    /*Lesson1task2
     Асимптотическая сложность функции:
    О(1+N*N*(2*N)+1)
    O(2+2*N^3)
    O(N^3)
    */



    public class Lesson1task3
    { 
        public class TestCase
    {
        public long X { get; set; }
        public long Expected { get; set; }
        public Exception ExpectedException { get; set; }
    }
    
        static long FibonachiRecurce(long n) // Рекрусивный метод числа Фибоначчи
        {
            if (n < 0)
                throw new ArgumentException("Число больше нуля");
            else if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
                return FibonachiRecurce(n - 1) + FibonachiRecurce(n - 2);
        }

        static long FibonachiСycle(long n)  // Метод вычисления числа Фибоначчи без рекурсии
        {
            if (n < 0)
                throw new ArgumentException("Число больше нуля");
            if (n == 0 || n == 1)
                return n;

            else
            {
                long result = 0;
                long[] fiboNum = new long[n + 1];
                fiboNum[0] = 0;
                fiboNum[1] = 1;
                for (long i = 2; i < n + 1; i++)
                {
                    fiboNum[i] = fiboNum[i - 1] + fiboNum[i - 2];
                    result = fiboNum[i];
                }
                return result;
            }
        }

        static void TestFibonachiRecurce(TestCase testCase)  // Тестовый код вычисления Рекрусивного метода числа Фибоначчи
        {
            try
            {
                var actual = FibonachiRecurce(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine($"{ex.Message} - VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void TestFibonachiСycle(TestCase testCase) // Тестовый код вычисления Метода числа Фибоначчи без рекурсии
        {
            try
            {
                var actual = FibonachiСycle(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine($"{ex.Message} - VALID TEST");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        


        static void Main(string[] args) // вывод результатов
        {
            var testCase1 = new TestCase()
            {
                X = 1,
                Expected = 1,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = 2,
                Expected = 1,
                ExpectedException = null
            };
            Console.WriteLine("Тест метода с рекурсией");
            TestFibonachiRecurce(testCase1);
            TestFibonachiRecurce(testCase2);
            

            Console.WriteLine("Тест метода без рекурсии");
            TestFibonachiСycle(testCase1);
            TestFibonachiСycle(testCase2);
            
            Console.Write("Введите индекс для поиска числа Фибоначчи: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"Число Фиббоначи рекурсивная версия: {FibonachiRecurce(index)}");
            Console.WriteLine($"Число Фиббоначи без рекурсии(через цикл): {FibonachiСycle(index)}");

        }

    }
    }











