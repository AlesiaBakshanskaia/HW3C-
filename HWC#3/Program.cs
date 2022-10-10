/*23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N*/

/*Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i < N)
{
    double num = Math.Pow(i, 3);
    Console.Write($"{num}, ");
    i++;
}
Console.WriteLine($"{Math.Pow(N, 3)}");*/


/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите координату AX");
int AX = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату AY");
int AY = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату AZ");
int AZ = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату BX");
int BX = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату BY");
int BY = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату BZ");
int BZ = int.Parse(Console.ReadLine()!);

double rezult = Math.Sqrt(Math.Pow(BX-AX, 2) + Math.Pow(BY-AY, 2) + Math.Pow(BZ-AZ, 2));

Console.WriteLine($"Расстояние между точками A и B  в трехмерном пространстве {rezult:f2}");