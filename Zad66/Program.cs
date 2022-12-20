// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int rec(int a, int b)
{
    if (a > b )
        return 0;
    return rec(a+1, b) +a;
}
Console.Clear();
Console.WriteLine("Vvedite 2 chisla");
Console.Write("Vvedite m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summa elementov v promezhutke({m},{n}) ravna {rec(m, n)}");