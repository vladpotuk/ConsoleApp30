using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.Write("Введіть початкове значення діапазону: ");
        int startRange = int.Parse(Console.ReadLine());

        Console.Write("Введіть кінцеве значення діапазону: ");
        int endRange = int.Parse(Console.ReadLine());

        int multiplicationResult = MathOperations.MultiplyNumbersInRange(startRange, endRange);
        Console.WriteLine($"Добуток чисел у вказаному діапазоні: {multiplicationResult}");

        // Завдання 2
        Console.Write("Введіть число для перевірки на належність до послідовності Фібоначчі: ");
        int fibonacciNumber = int.Parse(Console.ReadLine());

        bool isFibonacci = FibonacciChecker.IsFibonacciNumber(fibonacciNumber);
        Console.WriteLine($"{fibonacciNumber} {(isFibonacci ? "є" : "не є")} числом Фібоначчі.");

        // Завдання 3
        Console.Write("Введіть розмір масиву (кількість елементів): ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Console.Write("Введіть елементи масиву (через пробіл): ");
        string[] inputArray = Console.ReadLine().Split(' ');

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.Write("Виберіть напрямок сортування (1 - зростання, 2 - спадання): ");
        int sortDirection = int.Parse(Console.ReadLine());

        bool ascending = sortDirection == 1;

        int[] sortedArray = ArraySorter.SortArray(array, ascending);

        Console.WriteLine("Відсортований масив:");
        Console.WriteLine(string.Join(" ", sortedArray));
    }
}
