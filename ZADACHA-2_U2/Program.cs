﻿// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");    // Сообщение пользователю
int Value = Convert.ToInt32(Console.ReadLine());  // конвертируем значение в переменную
int Length = Value.ToString().Length;  // определяем длинну значения строки
if (Length >= 3)  // если длинна значения больше или равна трём
{
while (Value > 999) // пока значение больше 999 третья цифра будет всегда 
{
Value = Value / 10;  // находим вторую цифру
}
int result = Value % 10; // находим третью  цифру записываем её в переменную result
Console.WriteLine("Третья цифра в веденном числе: " + result);   //выводим на консоль 3-ю цифру
}
else // если ввели не трёхзначное число
{
Console.WriteLine("Третьей цифры в ведённом числе НЕТ");  //выводим на консоль что  3-й цифры нет
}