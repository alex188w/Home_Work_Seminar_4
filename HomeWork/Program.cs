
void Zadacha_25()
// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два
// натуральных числа (A и B) и возводит число A в степень B
{
    Console.WriteLine("Введите число A ");
    int A = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число B ");
    int B = Convert.ToInt32(Console.ReadLine());
    int power = 1;
    if (B == 0) Console.WriteLine($"А в степени В равно {power} ");
    else 
    for (int i = 1; i <= B; i++)
    {
        power = power * A;
    }
    Console.WriteLine($"Число {A} в степени {B} равно {power}");
}

void Zadacha_27()
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
{
    Console.WriteLine("Введите натуральное число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (N > 0)
    {
        
        sum = sum + N % 10;
        N = N / 10;        
    }
    Console.WriteLine($"Сумма цифр данного числа составляет {sum}");
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

//Zadacha_25();
//Zadacha_27();
Zadacha_29();