//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Метод определения точки пересечения двух прямых
string GetPointIntersectionTwoLines(double k1, double b1, double k2, double b2)
{
    string result = string.Empty;
    if (k1 == k2 && b1 == b2) result = "Прямые совпадают"; 
    else if (k1 == k2) result = "Прямые параллельны";
    else
    {
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    result = $"Координаты точки пересечения:({x},{y})";
    }
    return result;
}

// Определяем входные данные
Console.WriteLine("Введите координаты первой прямой:");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй прямой:");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

string PointIntersectionTwoLines = GetPointIntersectionTwoLines(k1, b1, k2, b2);
Console.WriteLine(PointIntersectionTwoLines);