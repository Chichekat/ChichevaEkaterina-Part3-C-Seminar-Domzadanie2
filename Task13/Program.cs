// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Пример: 645-> 5, 78-> нет цифры, 32679-> 6./

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
    {
        Console.WriteLine($"Нет третьей цифры: {num}");
    }
    else 
        {
            while (num > 1000){
              num /= 10;  
            }
            Console.WriteLine($"{num % 10}");
        }