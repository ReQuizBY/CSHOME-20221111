// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите день недели:");

int d=Convert.ToInt32(Console.ReadLine());

if ((d >= 1) && (d <= 5)) Console.WriteLine("Рабочий день");
else
{
    if ((d >= 6) && (d <= 7)) Console.WriteLine("Выходной день");
            else
            {
                System.Console.WriteLine("Нет такого дня недели");
            }
}







