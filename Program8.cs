
        int n = 1;
        Console.Write("До какого числа тебе нужны четные числа?  ");

        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }