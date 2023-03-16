//Задача 43:
//Напишите программу, которая будет преобразовывать
//десятичное число в двоичное
//45 -> 101101
//3 -> 11
//2 -> 10

int ConvertToBinary (int dig)
{
    int binaryDig = 0;
	int i = 0;
    while (dig > i)    
    {
        binaryDig = binaryDig + (dig % 2);
        binaryDig = binaryDig * 10;
		dig = dig / 2;
    }
    return binaryDig / 10;
}

Console.WriteLine ("Введите число в десятичной системе");
int digit = Convert.ToInt32(Console.ReadLine());

int binaryDigit = ConvertToBinary(digit);
Console.WriteLine(binaryDigit);