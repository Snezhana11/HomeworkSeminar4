// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
 int num1 = 9012;
Console.WriteLine(GetSum(num1));

 int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
