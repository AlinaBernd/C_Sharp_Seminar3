// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palidrome(string num)
{
    int i = 0;
    int len = num.Length;
    while (i < len / 2)
    {
        if (num[i] != num[len - i - 1]) return false;
        i++;
    }
    return true;
}
Console.WriteLine("Input a number: ");
string number = Console.ReadLine();
bool res = Palidrome(number);
if (res == true) Console.WriteLine("Yes");
else Console.WriteLine("No");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = x2 - x1;
    double b = y2 - y1;
    double c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c * c);
}
Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(x2, y2, z2, x1, y1, z1));

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void WriteCube(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {current * current * current}");
        current++;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteCube (number);

