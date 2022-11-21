// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
int c=Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b; 
if (max < c) max = c;
System.Console.WriteLine($"Макcимальное из трех чисел = {max}");