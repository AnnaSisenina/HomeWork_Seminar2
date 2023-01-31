// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber==secondNumber*secondNumber)
Console.WriteLine("Первое число является квадратом второго");
else if (secondNumber==firstNumber*firstNumber)
Console.WriteLine("Второе число является квадратом первого");
else
Console.WriteLine("Ни одно из чисел не является квадратом другого");