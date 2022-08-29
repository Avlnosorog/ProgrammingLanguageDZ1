//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberNeg = 1;
while(numberNeg <= number)
{
if(numberNeg % 2 == 0)
{
   Console.WriteLine(numberNeg);
   numberNeg++;
}   
else
{
    numberNeg++;
}
}