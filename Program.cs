using System;

namespace СеминарCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ведите число");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(Num1,2));

            //Задача 1

            Console.WriteLine("Введи число от 1 до 7");
            int Num2 = int.Parse(Console.ReadLine());
            if (Num2 == 1)
            {
                Console.WriteLine("1 -> Понедельник");
            }
            if (Num2 == 2)
            {
                Console.WriteLine("2 -> Вторник");
            }
            if (Num2 == 3)
            {
                Console.WriteLine("3 -> Среда");
            }
            if (Num2 == 4)
            {
                Console.WriteLine("4 -> Четверг");
            }
            if (Num2 == 5)
            {
                Console.WriteLine("5 -> Пятница");
            }
            if (Num2 == 6)
            {
                Console.WriteLine("6 -> Суббота");
            }
            if (Num2 == 7)
            {
                Console.WriteLine("7 -> Воскресенье");
            }
            else if(Num2>7)
            {
                Console.WriteLine("Ввели неверное число");
            }

            //Задача 3 */

            /*Console.WriteLine("Ведите число");
            int Num3 = int.Parse(Console.ReadLine());
            if (Num3>0)
            {
                int Num4 = Num3*-1;
                while (Num4<=Num3)
                {
                Console.Write($"{Num4}, ");
                Num4 += 1;
                }
            }
            else
            {int Num4 = Num3*-1;
                while (Num3<=Num4)
                {
                Console.Write($"{Num3}, ");
                Num3 += 1; 
                }
            }*/

                // ____ДОМШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 1____ 
        
        //_Задача_2
        /*Console.WriteLine("Введите первое число");
        int Num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int Num2 = int.Parse(Console.ReadLine());
        
        if (Num1>Num2)
        {
            Console.WriteLine($"Число {Num1} больше числа {Num2}");    
        }
        else
        {
            Console.WriteLine($"Число {Num2} больше числа {Num1}");
        }*/

         //_Задача_4

        /*Console.WriteLine("Введите первое число");
        int Num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int Num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        int Num3 = int.Parse(Console.ReadLine());

        if (Num1>Num2)
        {
            if (Num1>Num3)
            {
                Console.WriteLine($"Максимальное число: {Num1}");
            }
            else 
            {
                Console.WriteLine($"Максимальное число: {Num3}");
            }
        }
        else
        {
            if (Num2>Num3)
            {
              Console.WriteLine($"Максимальное число: {Num2}");  
            }
            else
            {
                Console.WriteLine($"Максимальное число: {Num3}"); 
            }
        }
        */ 

        //_Задача_6

        /*Console.WriteLine("Введите число");
        int Num = int.Parse(Console.ReadLine());
        if (Num%2==0)
        {
            Console.WriteLine($"Число {Num} - чётное");
        }
        else
        {
            Console.WriteLine($"Число {Num} - нечётное");
        }
        */

        //_Задача_8

        Console.WriteLine("Введите число");
        int Num = int.Parse(Console.ReadLine());
        int index = 1;
        while (index<Num)
        {
            if(index%2==0)
            {
                if(index+2==Num)
                {
                    Console.Write($"{index} - четные числа от 1 до {Num}");
                }
                else
                {
                    Console.Write($"{index}, ");
                }    
            }
            index++;
        }
        }

        

    
        
    
    }
}
