// Генерация 1 и -1
void BinaryFunc()
{
    Random random = new Random();
    for (int i = 0; i < 10; i ++)
    {
        Console.WriteLine(random.Next(0, 2) *2 - 1);
    }
}

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
void Zadacha_39()
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int halfSize = size/2;
    int maxIndex = size - 1;
    for (int i = 0; i < halfSize; i++)
    {
        int temp = array[i];
        array[i] = array[maxIndex - i];
        array[maxIndex - i] = temp;
    }
    Console.WriteLine("Полученный массив ");
    PrintArray(array);
}

void Zadacha_40() 
// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины
{
    Console.WriteLine("Введите первое число ");
    int A = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите второе число ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число ");
    int C = Convert.ToInt32(Console.ReadLine());
    if ((A + B > C) && (A + C > B) && (B + C > A))
    Console.WriteLine("Треугольник с такими сторонами существует ");
    else Console.WriteLine("Треугольник с такими сторонами не существует ");
}

void Zadacha_42() //Перевод десятичного числа в двоичное 45 -> 101101
{
    Console.WriteLine("Введите число для перевода ");
    int N = Convert.ToInt32(Console.ReadLine());
    int num10 = N;
    int num2 = 0;
    int sdvig = 1;
    
    while (num10 > 0)
    {
        num2 = num2 + num10 % 2 * sdvig;
        sdvig *= 10;
        num10 = num10 / 2;       
    }  
    Console.WriteLine(num2);   
}

void Zadacha_44() // Задача 44: Не используя рекурсию, выведите первые N
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
{
    double numberFirst = 0;
    double numberSecond = 1;

    Console.WriteLine("Введите число ");
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(numberFirst);
        double temp = numberFirst;
        numberFirst = numberSecond;
        numberSecond = numberFirst + temp;      
    }
}

void Zadacha_44_1() // другой способ
{
    Console.WriteLine("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    int k = 2;
    array[0] = 0;
    array[1] = 1;
    while (k < N)
    {
        array[k] = array[k-1] + array[k-2];
        k++;
    }
    PrintArray(array);
}

void Zadacha_45() //Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);

    int[] arraySecond = new int[size];
    for (int i = 0; i < size; i++)
    {
        arraySecond[i] = array[i];
    }
    Console.WriteLine("Полученный массив ");
    PrintArray(array);
}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(startNumber, finishNumber);
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

// BinaryFunc();
// Zadacha_39();
// Zadacha_40();
// Zadacha_42();
// Zadacha_44();
// Zadacha_44_1();
Zadacha_45();