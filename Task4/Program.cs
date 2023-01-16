// Программа для проверки какое число больше
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = 0; //Добавляем переменную чтобы у нас были "максимум"
if (a > b)
{
   max = a;
}
if (b > a)
{
   max = b;
}
if (max> c)
{
   Console.Write(max);
}
if (c> max)
{
   Console.Write(c);
}