// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4:");
int quarter = int.Parse(Console.ReadLine() ?? "0");
if (quarter==1)
Console.WriteLine("Диапазон возможных координат: x>0 и y>0");
else if (quarter==2)
Console.WriteLine("Диапазон возможных координат: x<0 и y>0");
else if (quarter==3)
Console.WriteLine("Диапазон возможных координат: x<0 и y<0");
else if (quarter==4)
Console.WriteLine("Диапазон возможных координат: x>0 и y<0");
else
Console.WriteLine("Вы ввели число, которое не соответствует ни одной четверти");
