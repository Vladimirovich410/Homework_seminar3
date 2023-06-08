Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if((num < 10000) || (num > 99999))
{
    Console.WriteLine("Неправильное число");
}

int a1 = num % 10;
int b1 = num / 10;
int a2 = b1 % 10;
int b2 = b1 / 10;
int a3 = b2 % 10;
int b3 = b2 / 10;
int a4 = b3 % 10;
int a5 = b3 /10;

if((a1 == a5) && (a2 == a4))
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("Это число НЕ палиндром");
}