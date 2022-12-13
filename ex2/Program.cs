//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
    int sumOfOddElement = 0;
    int[] array = new int[len];
    System.Console.Write("Массив: [");
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if(i % 2 != 0)
        {
            sumOfOddElement += array[i];
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
    return sumOfOddElement;

}

int length = GetNumber("Какой размерности хотите массив: ");
System.Console.WriteLine($"   Сумма элементов на нечетных местах равна  {CreateArray(length)}"); 