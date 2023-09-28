Console.Clear();

int N = 15;

System.Console.WriteLine($"Значение N -> {N}");

void Interval(int N, int i = 1)
{  
    if (i > N)
    {
        return;
    }
    Interval(N, i + 1);
    System.Console.Write(i + ", ");
}
Interval(N);