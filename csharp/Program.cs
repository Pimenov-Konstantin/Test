int rows = 1; //тут у нас массив m 3x4.
int colums = 2;
int[,] array = new int[rows, colums];

FillArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = rand.Next(0, 10);
        }
    }
    PrintArray();
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(" Russia ");
    }
}