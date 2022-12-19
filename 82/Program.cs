// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s=Console.ReadLine();
int k=0;
foreach(char a in s)
    if (char.IsDigit(a)) k++;
System.Console.WriteLine(k);    



