
Console.Clear();


System.Console.WriteLine("Введите значение M : ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение N : ");
int n = int.Parse(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

