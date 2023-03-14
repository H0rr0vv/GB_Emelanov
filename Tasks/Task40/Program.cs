//Задача 40:
//Напишите программу, которая принимат на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины
//теорема - каждая сторона треугольника меньше суммы двух других сторон


bool CheckTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Длина первой стороны = ");
int ASide = Console.Read();
Console.WriteLine("Длина второй стороны = ");
int BSide = Console.Read();
Console.WriteLine("Длина третьей стороны = ");
int CSide = Console.Read();

Console.Write(CheckTriangle(ASide, BSide, CSide) 
    ? "Треугольник с такими сторонами может существовать" 
    : "Треугольника с такими сторонами существовать не может");