Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    double square = Math.Pow((count),3);
    Console.Write($"{square} ");

    count++;
    
}

