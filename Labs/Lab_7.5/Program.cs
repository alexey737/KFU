using System.Diagnostics.CodeAnalysis;

void Task1()
{
    int n = int.Parse(Console.ReadLine());
    if (n == 3 || n == 5 || n == 7 || n == 9)
    {
        int[,] matrix = new int[n, n];
        Console.WriteLine("Введите элементы по строкам");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        int[,] clone1 = (int[,])matrix.Clone();
        int[,] clone2 = (int[,])matrix.Clone();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int center = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!(i == center) && !(j == center))
                    clone1[i, j] = 0;
               
                Console.Write(clone1[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!(i == j) && !(j + i == n - 1))
                    clone2[i, j] = 0;
             
                Console.Write(clone2[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            int mx = matrix[i, 0];
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > mx)
                    mx = matrix[i, j];
            }
            Console.WriteLine($"str{i}: max: {mx}");
        }
        Console.WriteLine();
        int sum = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i == j)
                    sum += matrix[i, j];
        Console.WriteLine($"sum diagonal:{sum}");
        Console.WriteLine();
        int maxx = matrix[0,0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > maxx)
                    maxx = matrix[i, j];
            }
        }
        Console.WriteLine($"max matrix: {maxx}");

    }



    else
        Console.WriteLine("error");
}
Task1();