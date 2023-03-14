//Задача 26:
//Напишите прогшрамму, которая принимает на вход число
// и выдает количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int NumOfValue(int num)
{
    int index = 10;
    int summ = 1; 
    while (num / index != 0)
    {
        index = index * 10;
     summ++;
    }
    
    
    summ = 1;
    for (int i = 10; num / i != 0; i = i * 10)
    {
     summ++;
    }

    return summ;   
}

int numOfValue = NumOfValue(number);
Console.WriteLine(numOfValue);
