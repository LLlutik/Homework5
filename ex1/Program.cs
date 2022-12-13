//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int CreateArray(int len)
{
    int countOfEnenElement = 0;
    int[] array = new int[len];
    System.Console.Write("Массив: [");
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(array[i] % 2 == 0)
        {
            countOfEnenElement ++;
        }
        if (i != len-1)
        {
            System.Console.Write($"{array[i]}, ");        
        }
        else
        {
            System.Console.Write($"{array[i]}]");        
        }
    }
    return countOfEnenElement;

}

int length = GetNumber("Какой размерности хотите массив: ");
System.Console.WriteLine($"   Количество четных элементов в массиве: {CreateArray(length)}"); 