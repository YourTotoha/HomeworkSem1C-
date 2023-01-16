// Программа которая на вход принимает число N, а на выходе показывается все четные числа от 1 до N
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int x = 1;
while ( x <= number)
{
    if (x%2==0)
    {
        Console.Write(x + ", ");
        x++; 
    }
    else 
    {
        x++; 
    }
}
