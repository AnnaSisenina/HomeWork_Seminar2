// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координаты первой точки (a,b,0)/(a,b,c)");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine()?? "0");
int c = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты второй точки (d,e,0)/(d,e,f)");
int d = int.Parse(Console.ReadLine()?? "0");
int e = int.Parse(Console.ReadLine()?? "0");
int f = int.Parse(Console.ReadLine()?? "0");
double distance = Math.Sqrt((d-a)*(d-a)+(e-b)*(e-b)+(f-c)*(f-c));
Console.WriteLine("Расстояние между точками равно "+distance);