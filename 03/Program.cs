// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b; 
System.Console.WriteLine($"Макcимальное из двух чисел = {max}");
