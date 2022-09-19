/*// Случайное число от 10 до 99, вывести максимальную цифру
int number=new Random().Next(10,100);
int num1=number/10;
int num2=number%10;

int max=num1;
if (max<num2) max=num2;
Console.WriteLine ($"Максимальная цифра числа {number} это {max}");*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46

//782 -> 72

//918 -> 98
int number=new Random().Next(100,1000);
int num1=number/100;
int num3=number%10;
int newNumber=num1*10+num3;
Console.WriteLine ($"Максимальная цифра числа {number} это {newNumber}");
