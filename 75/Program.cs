// 75. Написать программу вычисления функции Аккермана

int Func(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return Func(m - 1, 1);
			}
			return Func(m - 1, Func(m, n - 1));
		}
		
		System.Console.WriteLine(Func(2,2));
