// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число для проверки ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
   Console.WriteLine(number+ " является чётным");
}
else
{
    Console.WriteLine(number+" является не чётным");
}