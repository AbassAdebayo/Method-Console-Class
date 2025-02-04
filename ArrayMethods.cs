namespace Method_Class;

public class ArrayMethods
{
    public void IndexOfLetters(string letters)
    {
        char [] LatinLetters = new char[26];

        for (int i = 0; i < LatinLetters.Length; i++)
        {
            LatinLetters[i] = (char)(i + 'a');
        }

        foreach (char letter in letters)
        {
            int index = Array.IndexOf(LatinLetters, letter);
            if (char.IsLetter(letter))
            {
                Console.WriteLine($"{letter} => {index}");
            }
            else
            {
                Console.WriteLine($"{letter} => Not Found!");
            }
        }
    }

    public void PrintMatrix(int[,] matrix, int rows, int cols)
    { 
        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                Console.Write($"matrix[{0},{1}] = ");
                matrix[row, col] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}