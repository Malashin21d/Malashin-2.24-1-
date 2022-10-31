using System;
int chislo1;
int chislo2;
int chislo3;
int result;// Добавить переменные
Console.WriteLine("Введите первое число");
chislo1 =int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число");
chislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третий число");
chislo3 = int.Parse(Console.ReadLine());// Ввод чисел 1 2 и 3
result = chislo2*10+chislo3;
result = (result * 10) + chislo1;// меняем цифры местами
Console.WriteLine("ответ {0}",result);// результат
