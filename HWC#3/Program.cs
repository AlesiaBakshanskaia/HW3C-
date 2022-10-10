/*23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N*/

/*Console.WriteLine("Введите положительное число N ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
if (N > 0 ) {
    while (i < N)
    {
        double num = Math.Pow(i, 3);
        Console.Write($"{num}, ");
        i++;
    }
    Console.WriteLine($"{Math.Pow(N, 3)}");
}
else {
    Console.WriteLine("Вы ввели отрицательное число или 0");
}
*/




/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

/*Console.WriteLine("Введите координату AX");
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

Console.WriteLine($"Расстояние между точками A и B  в трехмерном пространстве {rezult:f2}");*/


//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

Console.WriteLine("Введите положительное пятизначное число N ");
string num = Console.ReadLine()!;
if ((num.Length < 5) || (num.Length > 5)) {
    Console.WriteLine("Вы не верно ввели число ");
}
else {
    if ((num[0] == num[4]) && (num[1] == num[3])) {
        Console.WriteLine($"Число {num} палиндром");
    }
    else {
        Console.WriteLine($"Число {num} не палиндром");
    }
}