﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели и проверяет является ли этот день выходным 

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num <= 5){
    Console.WriteLine($"{num} -> нет");
    return;
    }
    if (num > 5 && num <= 7){
        Console.WriteLine($"{num} -> да");
    }
    else {
        Console.WriteLine("Вы ввели не верное число");
    }

