// РЕШЕНИЕ ЗАДАЧИ  ПОМОЩЬЮ ВЫЗОВА ПРОЦЕДУРЫ

void Zadacha_25()
// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два
// натуральных числа (A и B) и возводит число A в степень B
{
    Console.WriteLine("Введите число A ");
    int A = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число B ");
    int B = Convert.ToInt32(Console.ReadLine());
    Power(A, B);    //обращение, вызов процедуры
}

void Zadacha_27()
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
{
    Console.WriteLine("Введите натуральное число ");
    int N = Convert.ToInt32(Console.ReadLine());
    Sum(N); //названия переменных могут не совпадать. Number из процедуры присваивается N    
    Sum(178345967); //для примера
    Sum(1783467);
}

void Zadacha_29()
// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный
// по модулю массив
{
    int size = 8;
    int[] massive = new int[size]; 
    int index = 0;
    Console.Write("Исходный массив [ ");
    while (index < size)
    {
        massive[index] = new Random().Next(-99, 100); 
        Console.Write(massive[index] + " ");
        index++;    
    }
    Console.WriteLine("]");
    Console.Write("Отсортированный массив [ ");
    for (int i = 0; i < size; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < size; j++)
        {
            if(Math.Abs(massive[j]) < Math.Abs(massive[minPosition])) minPosition = j;
        }
        int temporary = massive[i];
        massive[i] = massive[minPosition];
        massive[minPosition] = temporary;
        Console.Write(massive[i] + " ");        
    }
    Console.WriteLine("]");
}

void Zadacha_29_1() //другой метод
{
    int size = 8;
    int[] massive = new int[size];

    FillArray(massive);
    Console.WriteLine("Исходный массив");
    PrintArray(massive);
    SortArray(massive);
    Console.WriteLine("Отсортированный массив");
    PrintArray(massive);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(-99, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SortArray(int [] massive)
{
    for (int i = massive.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if(Math.Abs(massive[j]) < Math.Abs(massive[j + 1]))
            {
                int temporary = massive[j];
                massive[j] = massive[j + 1];
                massive[j + 1] = temporary;
            }
        }
    }
}

void Power(int A, int B) //инициализация процедуры
{
    int power = 1;
    if (B == 0) Console.WriteLine($"А в степени В равно {power} ");
    else 
    for (int i = 1; i <= B; i++)
    {
        power = power * A;
    }
    Console.WriteLine($"Число {A} в степени {B} равно {power}");
}

void Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        
        sum = sum + number % 10;
        number = number / 10;        
    }
    Console.WriteLine($"Сумма цифр данного числа составляет {sum}");
}


//Zadacha_25();
//Zadacha_27();
//Zadacha_29();
Zadacha_29_1();