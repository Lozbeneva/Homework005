// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArray(int i) //функция заполнения массива случайными числами от 100 до 999 (трехзначными)
{
    int[] array = new int[i];

    for (int count = 0; count < i; count++)
    {
        array[count] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] massivePrint) //функция вывода массива на экран
{
    for (int count = 0; count < massivePrint.Length; count++)
    {
        Console.Write(massivePrint[count] + " ");
    }
    Console.WriteLine();
}

//**********************************************************
/* Console.Write("Введите размер массива -> ");
int razmer = int.Parse(Console.ReadLine());

int[] array = FillArray(razmer);
PrintArray(array);

int counter = 0; // счетчик положительных элементов

for (int element = 0; element < razmer; element++)
{
    counter += array[element]%2 == 0 ? 1 : 0; // тернарный оператор как на семинаре
}
Console.WriteLine("Количество четных элементов -> " + counter); */
//**********************************************************



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//**********************************************************
/* Console.Write("Введите размер массива -> ");
int razmer2 = int.Parse(Console.ReadLine());

int[] array2 = FillArray(razmer2);
PrintArray(array2);

int summa = 0; // сумма элементов на нечетных позициях

for (int i = 1; i < razmer2; i += 2)
{
    summa += array2[i];
}

Console.WriteLine("Сумма элементов на нечетных позициях -> " + summa); */
//**********************************************************



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/* Console.Write("Введите размер массива -> ");
int razmer3 = int.Parse(Console.ReadLine());

double first_number;
double second_number;
double[] array3 = new double[razmer3];

for (int i = 0; i < razmer3; i++) //цикл заполнения массива вещественными числами путем деления двух рандомных целых чисел друг на друга
{
    first_number = new Random().Next(-100, 100);
    second_number = new Random().Next(-100, 100);

    array3[i] = first_number / second_number;
}


double max_element = array3[0];
double min_element = array3[0];

for (int i = 0; i < razmer3; i++) //цикл поиска максимума и минимума массива, а заодно и вывода его на экран
{
    if (array3[i] > max_element)
    {
        max_element = array3[i];
    }
    if (array3[i] < min_element)
    {
        min_element = array3[i];
    }
    Console.Write(array3[i] + "; ");
}


Console.WriteLine();
Console.Write($"Максимум - > {max_element}  Минимум - > {min_element}");
max_element = Math.Abs(max_element);
min_element = Math.Abs(min_element);
Console.WriteLine();
Console.Write($"Разница максимального и минимального элемента -> {max_element - min_element}"); */

