//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int DigitZero (int m)
{
    int val = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        if (Convert.ToInt32(Console.ReadLine()) > 0) val++;
    }
    return val;
}


Console.WriteLine("Сколько чисел вы хотели бы видеть?");
int M = Convert.ToInt32(Console.ReadLine());
int value = DigitZero (M);
Console.WriteLine($"Из {M} чисел, что вы ввели {value} больше нуля");