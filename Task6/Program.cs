// Программа для проверки, делится ли число на 2 без остатка
Console.Write("Введитечисло: ");
int number = int.Parse(Console.ReadLine());
if (number%2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}