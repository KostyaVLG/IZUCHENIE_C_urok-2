﻿// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели от 1 до 7:  ");    // Сообщение пользователю
int Day = Convert.ToInt32(Console.ReadLine());   // конвертируем значение в переменную
if (Day >= 1 && Day <=7)  // определяем диапозон переменная должна быть больше 1 и меньше 7
{
if (Day >= 6) // если переменная польше или ровна 6-ти
{
Console.Write("Это выходной день"); // выводим на консоль что день выходной
}
else // значение меьше 6-ти
{
Console.Write("Рабочий день");  // выводим на консоль что день рабочий
}
}
else // если ввели не с 1 до 7 пишем баранам что надо вводит как надо см строку ниже
{
Console.Write("Пожалуйста введите число в диапазоне от 1 до 7"); // Сообщение пользователю
}