﻿// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Программа, показывает вторую цифру вашего трёхзначного числа."); // Сообщение пользователю
Console.Write("Введите трёхзначное число: ");   // Сообщение пользователю
int Value = Convert.ToInt32(Console.ReadLine()); // конвертируем значение 
int Length = Value.ToString().Length; // определяем длинну значения строки
if (Length == 3) // если длинна равна трем
{
int result = ( Value/10 ) % 10; // определяем вторую цифру
Console.WriteLine("Вторая цифра числа: " + result);  //выводим на консоль 2ю цифру
}
else  // если длинна равна НЕ трем
{
Console.WriteLine("Вы ввели не трёхзначное число. "); //выводим на консоль что число не трёхзначное
}
