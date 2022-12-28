// Задача 1 - легкая:
// Сформировать и заполнить массив случайным числами и вывести максимальное, минимальное и среднее значение.
// Для генерации случайного числа использовать метод Math.random(), который возвращает значение в промежутке [0, 1].

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] arrayRandomNumbers = new double[sizeArray];
double minValue = Double.MaxValue;
double maxValue = Double.MinValue;
double averageValue = 0;
for (int i = 0; i < sizeArray; i++)
{
    arrayRandomNumbers[i] = Math.Round(new Random().NextDouble(), 2);
    System.Console.Write(arrayRandomNumbers[i] + "\t");
    if (minValue > arrayRandomNumbers[i]) minValue = arrayRandomNumbers[i];
    if (maxValue < arrayRandomNumbers[i]) maxValue = arrayRandomNumbers[i];
    averageValue = averageValue + arrayRandomNumbers[i];
}
Console.WriteLine();
Console.WriteLine($"Минимальное значение: {minValue}");
Console.WriteLine($"Максимальное значение: {maxValue}");
Console.WriteLine($"Среднее значение: {Math.Round(averageValue / sizeArray, 2)}");