// See https://aka.ms/new-console-template for more information
int[] array = new int[8]; // Создаем массив из 8 элементов

        // Заполняем массив значениями, можно изменить значения по своему усмотрению
        array[0] = 1;
        array[1] = 2;
        array[2] = 5;
        array[3] = 7;
        array[4] = 19;
        array[5] = 6;
        array[6] = 1;
        array[7] = 33;

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");