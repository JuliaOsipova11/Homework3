
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Five digit number");
// string? number = Console.ReadLine();

// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else 
// Console.WriteLine($"Enter five digit number");

// void CheckingNumber(string number)
// {
//   if (number [number!.Length-5] == number [number!.Length-1] && number [number!.Length-4] == number [number!.Length-2])
//   {
//     Console.WriteLine($"Палиндром");
//   }
//   else 
//   Console.WriteLine($"Не палиндром");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Input coordinate X for first point:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for first point:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for first point:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X for second point:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for second point:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for first point:");
// double zb = Convert.ToDouble(Console.ReadLine());

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)), 2);
// }

// Console.Write (FindDistance (xa,ya,za,xb,yb,zb));

// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Number");
// int N = Convert.ToInt32(Console.ReadLine());

// void Cube (int N)
// {
//     int y=1;
//     while (y <= N)
//     {
//     Console.WriteLine(Math.Pow(y,3));
//     y++;
//     }
// } 
// Cube (N);