// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
//  неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int rec(int m, int n)
{
    if (m == 0 )
        return n+1;
    else 
    if (m>0&&n==0)
        return rec(m-1,1);
    else
    if(m>0&&n>0)
        return rec(m-1,rec(m,n-1));
    else
        return 0;
}
Console.Clear();
Console.WriteLine("Vvedite 2 chisla");
Console.Write("Vvedite m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Funkcia Akkermana 2 chisel({m},{n}) ravna {rec(m, n)}");