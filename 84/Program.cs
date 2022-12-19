// 84. Определить являются ли введенные с клавиатуры символы 
// правильно записью целого числа. Вычислить сумму цифр введенного числа

int SumDigits(int n)
{
    int sum=0;
    n=Math.Abs(n);
    while(n!=0)
    {
        sum=sum+n%10;
        n=n/10;
    }
    return sum;
}

string s=Console.ReadLine();
int n;
bool flag=int.TryParse(s,out n);
if (flag)
{
    System.Console.WriteLine($"Сумма цифр числа {n} = {SumDigits(n)}");
} 
else System.Console.WriteLine("Не целое число");