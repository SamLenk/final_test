using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine()!);
        string[] firstArray = new string[n];
        for (int i = 0; i < n; i++) {
            Console.Write("Введите строку {0}: ", i + 1);
            firstArray[i] = Console.ReadLine()!;
        }
        Console.WriteLine($"Вы ввели: [{String.Join(",", firstArray)}]");

        string[] secondArray = new string[firstArray.Length];
        int index = 0;

        foreach (string s in firstArray) {
            if (s.Length <= 3) {
                secondArray[index] = s;
                index++;
            }
        }

        string[] finalArray = new string[index];
        for (int i = 0; i < index; i++) {
            finalArray[i] = secondArray[i];
        }

        Console.Write("Новый массив: ");
        Console.Write($"[{String.Join(",", finalArray)}]");
    }
}
