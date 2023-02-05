// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");
if (firstNumber==secondNumber*secondNumber)
Console.WriteLine("Первое число является квадратом второго");
else if (secondNumber==firstNumber*firstNumber)
Console.WriteLine("Второе число является квадратом первого");
else
Console.WriteLine("Ни одно из чисел не является квадратом другого");