// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Пример: 645-> 5, 78-> нет цифры, 32679-> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num > 100 && num < 1000)
{
    num = num % 10;
    Console.WriteLine($"Трехзначное {num}");
    return;
}
if (num >= 1000)
{
    num = num % 100;
    num = num / 10;
    Console.WriteLine($"Четырехзначное {num}");
}
else {
    Console.WriteLine($"Нет третьей цифры");
}

dddd



