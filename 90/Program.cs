// 90. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.


int BitsToInteger(int[] d)
{ 
    double sum = 0; 
    for (int n = 0; n < d.Length; n++) 
    { 
        sum = sum + Math.Pow(2, n) * d[d.Length - n - 1]; 
    } 
    return Convert.ToInt32(sum);
} 

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int f = -1;
for (int i = 0; i < info.Length; i++)
{ 
    int[] d = new int[info[i]]; 
    for (int j = 0; j < info[i]; j++) 
    { 
        f++; 
        d[j] = data[f]; 
    } 
    System.Console.Write($"{BitsToInteger(d)},");
}
