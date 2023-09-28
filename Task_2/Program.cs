
Console.Clear();

System.Console.WriteLine("Введите значение M : ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение N : ");
int n = int.Parse(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

