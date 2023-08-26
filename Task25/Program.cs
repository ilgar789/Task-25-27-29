Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());

        int result = 1;
        
        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"{A}^{B} = {result}");