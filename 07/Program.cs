// 7. Выяснить является ли число чётным.

System.Console.WriteLine("Введите число :");
int a=Convert.ToInt32(Console.ReadLine());
bool flag=false;//флаг
{
    if (a %2==0) flag=true;
}

if (flag) System.Console.WriteLine("Является четным"); else System.Console.WriteLine("Не является четным");