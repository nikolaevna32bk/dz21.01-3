﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}