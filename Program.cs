// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if((num < 10000) || (num > 99999))
// {
//     Console.WriteLine("Неправильное число");
// }

// int a1 = num % 10;
// int b1 = num / 10;
// int a2 = b1 % 10;
// int b2 = b1 / 10;
// int a3 = b2 % 10;
// int b3 = b2 / 10;
// int a4 = b3 % 10;
// int a5 = b3 /10;

// if((a1 == a5) && (a2 == a4))
// {
//     Console.WriteLine("Это число палиндром");
// }
// else
// {
//     Console.WriteLine("Это число НЕ палиндром");
// }


// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double Lenght(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    return Math.Round(Math.Sqrt(Math.Pow((X1 - X2),2) + Math.Pow((Y1 - Y2),2) + Math.Pow((Z1 - Z2),2)), 2);
// double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
}
Console.Write("Расстояние между заданными точками: ");
Console.Write(Lenght(x1, y1, z1, x2, y2, z2));