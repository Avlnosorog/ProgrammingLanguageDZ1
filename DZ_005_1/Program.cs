﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int numberNeg = 1+1;

while(numberNeg <= number)
{
    Console.WriteLine(numberNeg);
    numberNeg=numberNeg+2;
}