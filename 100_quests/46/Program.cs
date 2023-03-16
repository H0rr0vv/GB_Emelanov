//46. Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, 
//чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"


int[,] CreateFigure (int corner)
{
    int[,] DefFigure = new int [corner,corner];
    for (int i = 0; i < corner; i++)
    {
        Console.WriteLine($"Введите координаты {i + 1} точки");
        Console.WriteLine($"Координата X {i + 1} точки");
        
        for (int j = 0; j < corner; j++)
        {
            Console.WriteLine($"Координата Y {j + 1} точки");
            DefFigure[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return DefFigure;
}

void PrintDefaultFigure (int[,] DefFigure)
{
    Console.Write("(");
    for (int i = 0; i < DefFigure.GetLength(0); i++)
    {
        for (int j = 0; j < DefFigure.GetLength(1); j++)
        {
            Console.Write(DefFigure[i, j]);
        }
        if (i < DefFigure.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество углов");
int valueCorners = Convert.ToInt32(Console.ReadLine());
int[,] defaultFigure = CreateFigure (valueCorners);;
PrintDefaultFigure(defaultFigure);