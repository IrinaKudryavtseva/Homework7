//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberM = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numberN, int numberM)
{
if(numberN == 0) 
return numberM + 1;
else if (numberM == 0) 
return Akkerman(numberN - 1, 1);
else return Akkerman(numberN -1, Akkerman (numberN, numberM - 1));
}
 Console.WriteLine("A(m,n) = " + Akkerman(numberN, numberM));
 
 Akkerman(numberN, numberM);
