
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
    Console.WriteLine($"Число {A} в степени {B} равно {power} ");
}

void Zadacha_27()
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
{
    Console.WriteLine("Введите натуральное число ");
    int N = Convert.ToInt32(Console.ReadLine());
    
}

//Zadacha_25();
Zadacha_27();