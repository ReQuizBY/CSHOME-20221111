// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x, y;
System.Console.WriteLine("Введите координату x:");
x = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y:");
y = Convert.ToDouble(Console.ReadLine());
if ((x > 0) && (y > 0)) Console.WriteLine("I четверть");
else
{
    if ((x < 0) && (y > 0)) Console.WriteLine("II четверть");
    else
    {
        if ((x < 0) && (y < 0)) Console.WriteLine("III четверть");
        else
        {
            if ((x > 0) && (y < 0)) System.Console.WriteLine("IV четверть");
            else
            {
                System.Console.WriteLine("Координаты x и y = 0");
            }
        }
    }
}


