//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());

string Numbers(int numberM, int numberN)
{   if(numberM <= numberN)
    return $"{numberM}  "+ Numbers(numberM+1, numberN);
    else return string.Empty;
}
Console.WriteLine(Numbers(numberM, numberN));
Numbers(numberM, numberN);

