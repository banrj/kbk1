// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число:");
int number1 =int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());
Console.Write("Введите четвертое число:");
int number4 = int.Parse(Console.ReadLine());


double quest = ((number1 * number2) + (number3 * number4)) / (number1 * number2);

Console.WriteLine($"{quest:F2}");
