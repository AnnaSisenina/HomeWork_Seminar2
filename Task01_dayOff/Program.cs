// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели от 1 до 7 включительно ");
int dayWeekNumber = int.Parse(Console.ReadLine() ?? "0");
if (dayWeekNumber>=1 && dayWeekNumber<=5)
Console.WriteLine ("Это не выходной день");
else if (dayWeekNumber==6 || dayWeekNumber==7)
Console.WriteLine ("Это выходной день");
else 
Console.WriteLine ("Вы ввели число, которое не входит в указанный диапазон :(");