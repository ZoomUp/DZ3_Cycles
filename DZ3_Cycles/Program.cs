using System;

namespace DZ3_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA;
            int numberB;
            int numberN;
            int numberOdd;
            int tmp;
            int tmp2;
            int tmp3;

            // 1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            Console.WriteLine("Первое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());
            tmp = numberA;


            for (int i = 1; i < numberB; i++)
            {
                numberA *= tmp;
            }
            Console.WriteLine("Ответ на первое задание: " + numberA);

            // 2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            Console.WriteLine("Второе задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ответ на второе задание: ");

            for (int i = 1; i < 1000 + 1; i++)
            {
                if (i % numberA == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            Console.WriteLine("Третье задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i * i < numberA; i++)
            {
                tmp = i;
            }
            Console.WriteLine("Ответ на третье задание: " + tmp);

            // 4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            Console.WriteLine("Четвертое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());

            for (int i = numberA - 1; i > 0; i--)
            {
                if (numberA % i == 0)
                {
                    Console.WriteLine("Ответ на четвертое задание: " + i);
                    break;
                }
            }


            // 5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            Console.WriteLine("Пятое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());
            tmp = 0;
            if (numberA > numberB)
            {
                for (int i = numberA - 1; i > numberB; i--)
                {
                    tmp += i;
                }
                Console.WriteLine("Ответ на пятое задание: " + tmp);
            }
            if (numberA < numberB)
            {
                for (int i = numberB - 1; i > numberA; i--)
                {
                    tmp += i;
                }
                Console.WriteLine("Ответ на пятое задание: " + tmp);
            }


            // 6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
            Console.WriteLine("Шестое задание");
            Console.WriteLine("Введите число N");
            numberN = Convert.ToInt32(Console.ReadLine());
            int tmp1 = 1;
            tmp2 = 1;
            int numberFibonacci = 1;

            for (int i = 2; i < numberN; i++)
            {
                numberFibonacci = tmp1 + tmp2;
                tmp1 = tmp2;
                tmp2 = numberFibonacci;
            }

            Console.WriteLine("Ответ на шестое задание: " + numberFibonacci);

            // 7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.WriteLine("Седьмое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());

            int numberGCF = 0;
            if (numberA == numberB)
            {
                for (int i = numberA - 1; i > 0; i--)
                {
                    if (numberA % i == 0)
                    {
                        numberGCF = i;
                        break;
                    }
                }
            }
            else
            {
                while (numberGCF == 0)
                {
                    if (numberA != numberB)
                    {
                        if (numberA > numberB)
                        {
                            numberA -= numberB;
                        }
                        else
                        {
                            numberB -= numberA;
                        }
                    }
                    else
                    {
                        numberGCF = numberA;
                    }
                }
            }

            Console.WriteLine("Ответ на седьмое задание: " + numberGCF);

            // 8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
            Console.WriteLine("Восьмое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            numberN = 1;
            tmp = numberA;
            tmp2 = 0;

            while (numberA != numberN * numberN * numberN)
            {
                if (tmp > numberA / tmp / tmp)
                {
                    tmp2 = tmp;
                    tmp /= 2;

                }
                else if (tmp < numberA / tmp / tmp)
                {
                    tmp = tmp2 + tmp;
                }
                else
                {
                    numberN = tmp;
                    break;
                }
            }
            Console.WriteLine("Ответ на восьмое задание: " + numberN);



            // 9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            Console.WriteLine("Девятое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            numberOdd = 0;

            while (numberA / 10 > 0 || numberA % 10 > 0)
            {
                tmp = numberA % 10;
                numberA /= 10;
                if (tmp % 2 != 0)
                {
                    numberOdd++;
                }
            }
            Console.WriteLine("Ответ на девятое задание: " + numberOdd);

            // 10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
            Console.WriteLine("Десятое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            tmp = 0;

            while (numberA / 10 > 0 || numberA % 10 > 0)
            {
                tmp = numberA % 10 + tmp;
                numberA /= 10;
                if (numberA / 10 > 0 || numberA % 10 > 0)
                {
                    tmp *= 10;
                }
            }
            Console.WriteLine("Ответ на десятое задание: " + tmp);

            // 11. Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            Console.WriteLine("Одиннадцатое задание");
            Console.WriteLine("Введите число N");
            numberN = Convert.ToInt32(Console.ReadLine());
            int numberSumOdd;
            int numberSumEven;

            Console.WriteLine("Ответ на одиннадцатое задание: ");
            for (int i = 1; i < numberN + 1; i++)
            {
                int j = i;
                numberSumOdd = 0;
                numberSumEven = 0;
                while (j / 10 > 0 || j % 10 > 0)
                {
                    tmp = j % 10;
                    j /= 10;
                    if (tmp % 2 != 0)
                    {
                        numberSumOdd += tmp;
                    }
                    else
                    {
                        numberSumEven += tmp;
                    }


                }
                if (numberSumEven > numberSumOdd)
                {
                    Console.WriteLine(i);
                }
            }

            // 12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            Console.WriteLine("Седьмое задание");
            Console.WriteLine("Введите число A");
            numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = Convert.ToInt32(Console.ReadLine());

            int numberCounter = 0;
            if (numberA > numberB)
            {
                tmp = numberA;
                numberA = numberB;
                numberB = tmp;
            }


            while (numberA / 10 > 0 || numberA % 10 > 0)
            {
                tmp2 = numberB;
                tmp = numberA % 10;
                numberA /= 10;
                while (tmp != tmp2 && (tmp2 / 10 > 0 || tmp2 % 10 > 0))
                {
                    tmp3 = tmp2 % 10;
                    if (tmp == tmp3)
                    {
                        numberCounter++;
                        break;
                    }
                    tmp2 /= 10;
                }
                if (tmp == tmp2)
                {
                    numberCounter++;
                    break;
                }

            }
            if (numberCounter > 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

        }

    }
}
