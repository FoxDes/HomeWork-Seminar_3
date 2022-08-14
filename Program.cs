// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string str = Convert.ToString(num);
// if (str[0] == str[4] || str[1] == str[3])
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine();
int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");
int Coordinate(string Axis, string Point)
{
    Console.Write($"Введите координату {Axis} точки {Point}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double xA, double xB, 
                double yA, double yB, 
                double zA, double zB){
  return Math.Sqrt(Math.Pow((xB-xA), 2) + 
                   Math.Pow((yB-yA), 2) + 
                   Math.Pow((zB-zA), 2));
}
double Result =  Math.Round (Decision(xA, xB, yA, yB, zA, zB), 2 );
Console.WriteLine($"Расстояние между точками  {Result}");