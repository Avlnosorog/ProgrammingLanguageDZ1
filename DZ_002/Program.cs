//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее, а также информацию в случае равенства двух чисел.

Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
 int b = Convert.ToInt32(Console.ReadLine());

 if(a>b)
 {
   Console.Write(a+ " > "+b);
 }
 if(b>a)
 {
   Console.Write(b+ " > "+a);
 }
 if(a==b)
 {
   Console.Write(b+ " = "+a);
 }
 
 
