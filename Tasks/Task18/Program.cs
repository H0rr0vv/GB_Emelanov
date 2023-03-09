//Задача 18:
//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат в этой четверти (x, y)

//X>0 Y>0 = 1
//X>0 Y<0 = 2
//X<0 Y<0 = 3
//X<0 Y>0 = 4

Console.WriteLine("Введите коордитаты четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string range = Range(quarter);

Console.WriteLine(range);

string Range(int quart)
{
    if (quart == 1) return "x > 0, y > 0";
    if (quart == 2) return "x > 0, y < 0";
    if (quart == 3) return "x < 0, y < 0";
    if (quart == 4) return "x < 0, y > 0";
    return "Неверно указан номер четверти";
}
