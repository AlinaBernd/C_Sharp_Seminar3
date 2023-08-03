// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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