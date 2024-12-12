namespace Assignment6_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment6.4");
            Console.WriteLine("==============\n");
            // Example matrix
            int[][] matrix = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7, 8},
                new int[] {9, 10, 11, 12},
                new int[] {13, 14, 15, 16}
            };

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            Rotate90Clockwise(matrix);

            Console.WriteLine("\nRotated Matrix:");
            PrintMatrix(matrix);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void Rotate90Clockwise(int[][] matrix)
        {
            int n = matrix.Length;

            // Consider all squares one by one
            for (int i = 0; i < n / 2; i++)
            {
                // Consider elements in group o 4 in current square
                for (int j = i; j < n - i - 1; j++)
                {
                    // Store current cell in temp var
                    int temp = matrix[i][j];

                    // Move values from right to top
                    matrix[i][j] = matrix[n - 1 - j][i];

                    // Move values from bottom to right
                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];

                    // Move values from left to bottom
                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];

                    // Assign temp to left
                    matrix[j][n - 1 - i] = temp;
                }
            }
        }

        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j].ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}