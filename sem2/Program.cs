


// void MinusSecond(int num)
// {
//    int ed = num % 10;
//    int set = num / 100;
//    Console.WriteLine($"{num} -> {set * 10 + ed}");
// }

// int MinusSecondInt (int num)
// {
//    int ed = num % 10;
//    int set = num / 100;
//    Console.WriteLine($"{num} -> {set * 10 + ed}");
//    int result = set * 10 + ed;
//    return result;
// }

// int SecondToThird(int num)
// {
//    int ed = num % 10 ;
//    int dec = num / 10 % 10;
//    int res = 1;
//    for (int i =0; i < ed; i ++ )
//    {
//        res = res * dec;
//    }
//    return res;
// }

// void FirstDifSecond(int a, int b)
// {
// if(a % b ==0)
// {
// System.Console.WriteLine($"{a} кратно {b}");
// }
// else 
// {
//     System.Console.WriteLine($"{a}  не кратно {b}, остаток {a % b}");

// }
// }

// System.Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// FirstDifSecond(num1, num2);
// //System.Console.WriteLine(result);


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 7 == 0 && number % 23 == 0)
//         {
//             Console.WriteLine($"{number} кратно 7 и 23");
//         }
//         else
//         {
//             Console.WriteLine($"{number} не кратно 7 и 23");
//         }
//     }
// }

// class Program
// {
//    static void Main(string[] args)
//    {
//       System.Console.WriteLine("Введите число ");
//       int number = int.Parse(Console.ReadLine());
//       if (number %7 == 0 && number % 23 == 0)
//       {
//          System.Console.WriteLine($"{number} кратно 7 и 23");
//       }
//       else
//       {
//          System.Console.WriteLine($"{number} не картно 7 и 23");
//       }
//    }

// }
// class Program
// {
//    static void Main(string[] args)
//    {
//       System.Console.Write("Введите координату X: ");
//       double x = double.Parse(Console.ReadLine());

//       System.Console.Write("Введите координату y: ");
//       double y = double.Parse(Console.ReadLine());

//       if (x > 0 && y > 0)
//       {
//          System.Console.WriteLine("Точка находится в 1-Й координатной четверти");
//       }
//       else if (x < 0 && y > 0)
//       {
//          System.Console.WriteLine("Точка нахлдится во 2-Й координатной четверти");
//       }
//       else if (x < 0 && y < 0)
//       {
//          System.Console.WriteLine("Точка находится в 3-Й координатной четверти");
//       }
//       else if (x > 0 && y < 0)
//       {
//          System.Console.WriteLine("Точка находится в 4-Й координатной четверти ");
//       }
//       else
//       {
//          System.Console.WriteLine("Точка находится на оси координат ");
//       }
//    }
// }


// class Program

// {
//    static void Main(string[] args)
//    {
//       System.Console.Write("Введите целое число от 10 до 99: ");
//       int number = int.Parse(Console.ReadLine());

//       if (number < 10 || number > 99)
//       {
//          System.Console.WriteLine("Числа должны быть оти 10 до 99");
//          return;
//       }

//       int firstDigit = number / 10;
//       int secondDigit = number % 10;

//       if (firstDigit > secondDigit)
//       {
//          System.Console.WriteLine($"Наибольшая цифра числа {number} - это {firstDigit}");
//       }

//       else
//       {
//          System.Console.WriteLine($"Наибольшая цифра числа {number} - это {secondDigit}");
//       }

//    }
// }
using System.ComponentModel;

class Program
{

   static void Main(string[] args)
   {
      System.Console.WriteLine("Введите натуральное чимло ");
      int number = int.Parse(Console.ReadLine());

      if (number <= 0)
      {
         System.Console.WriteLine("Число должно быть натуральным");
         return;
      }

      System.Console.WriteLine("Цифры числа {0}: ", number);

      while (number > 0)
      {
         int digit = number % 10;
         System.Console.Write("{0}, ", digit);
         number /= 10;
      }
      System.Console.WriteLine("/b/b ");
   }
}