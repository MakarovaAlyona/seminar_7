//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
        Console.WriteLine("Размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array =RandomArray(size);
        Console.WriteLine("Есть массив:");
        PrintArray(array, 0);
        Console.WriteLine("\nПеревернутый массив:");
        PrintArrayRev(array, array.Length - 1);
    

    static int[] RandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 50);
        }

        return array;
    }

    static void PrintArray(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArray(array, index + 1);
        }
    }

    static void PrintArrayRev(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayRev(array, index - 1);
        }
    }
