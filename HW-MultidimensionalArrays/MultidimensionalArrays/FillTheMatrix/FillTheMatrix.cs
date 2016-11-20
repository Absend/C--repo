using System;

class FillTheMatrix
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var ch = Console.ReadLine();

        switch (ch)
        {
            case "a":
                CaseA(n);
                break;
            case "b":
                CaseB(n);
                break;
            case "c":
                CaseC(n);
                break;
            case "d":
                CaseD(n);
                break;
        }

    }

    static void Print(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n - 1)
                {
                    Console.Write(matrix[i, j]);
                }
                else
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintA(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n - 1)
                {
                    Console.Write(matrix[j, i]);
                }
                else
                {
                    Console.Write(matrix[j, i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    static void CaseA(int n)
    {
        int[,] matrix = new int[n, n];
        int p = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = p;
                p++;
            }
        }

        PrintA(n, matrix);
    }

    static void CaseB(int n)
    {
        int[,] matrix = new int[n, n];
        int p = 1;
        for (int j = 0; j < n; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[j, i] = p;
                    p++;
                }
            }
            else
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    matrix[j, i] = p;
                    p++;
                }
            }
        }

        PrintA(n, matrix);
    }

    static void CaseC(int n)
    {
        int[,] matrix = new int[n, n];
        int p = 1;
        int rows = 0;
        int cols = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = p++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = p++;
            }
        }

        Print(n, matrix);
    }

    static void CaseD(int n)
    {
        int[,] matrix = new int[n, n];
        int p = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                matrix[i, j] = p;
                p++;

            }

            for (int j = 0; j < n - 1 - i * 2; j++)
            {
                matrix[j + 1 + i, n - i - 1] = p;
                p++;
            }


            for (int j = 0; j < n - 1 - i * 2; j++)
            {
                matrix[n - 1 - i, n - j - 2 - i] = p;
                p++;
            }


            for (int j = 0; j < n - 2 - i * 2; j++)
            {
                matrix[n - j - 2 - i, i] = p;
                p++;
            }
        }

        PrintA(n, matrix);
    }
}
