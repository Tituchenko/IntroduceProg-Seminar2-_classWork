// Случайное число от 10 до 99, вывести максимальную цифру
int number=new Random().Next(10,100);
int num1=number/10;
int num2=number%10;

int max=num1;
if (max<num2) max=num2;
Console.WriteLine ($"Максимальная цифра числа {number} это {max}");