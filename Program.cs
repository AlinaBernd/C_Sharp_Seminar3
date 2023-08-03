// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
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
*/
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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
