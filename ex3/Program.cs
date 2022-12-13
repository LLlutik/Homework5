//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Функция ввода и проверки введенного числа
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число! Попробуйте еще раз:");
        }
    }
    return result;
}

double CreateArray(int len)
{
    double[] array = new double[len];
    System.Console.Write("Массив: [");
    for (int i = 0; i < len; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() *100, 2) ;     
        if (i != len-1)
        {
            System.Console.Write($"{array[i]}\t");        
        }
        else
        {
            System.Console.WriteLine($"{array[i]}]");        
        }
    }

    double differenceBetweenMinMax = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < len; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    differenceBetweenMinMax = max - min;
    return differenceBetweenMinMax;
}

int length = GetNumber("Какой размерности хотите массив: ");
System.Console.WriteLine($"Разница между минимальным и максимальным значением равна  {CreateArray(length)}"); 