/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Пожалуйста, введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());          // вводим число, считывается как строка
int[] numbers = new int[size]; // создаем массив
FillArrayRandomNumbers(numbers); //команда, генерирующая случайные числа
Console.WriteLine("Массив: ");  //выводим и демонстрируем наш массив
PrintArray(numbers); //передаем массив в метод печати (вывода)
int count = 0; //отсюда видно, что была объявлена переменная count типа int и инициализирована значением 0

for (int r = 0; r < numbers.Length; r++) // проверка на четность рандомных чисел
if (numbers[r] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)  //метод 
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a]; //вводим и храним элементы массива
int sum = 0;

for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(-100,101);  //может быть

if(i % 2 !=0) 

{

    sum += randomArray[i];
}

}

Console.WriteLine(String.Join(", ", randomArray));
Console.WriteLine($"Сумма нечетных элементов = {sum}" );

*/


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = { 1, 2, 3, 5 };
 
Console.WriteLine(String.Join(", ", array));

int imin = 0, imax = 0;
    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }

Console.WriteLine("min : array[" + imin + "] = " + array[imin]);
Console.WriteLine("max : array[" + imax + "] = " + array[imax]);
Console.WriteLine($"Разница чисел {imax-imin}");

