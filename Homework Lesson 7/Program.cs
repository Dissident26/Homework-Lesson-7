// first subtask
int[] testArray = fillArray();

Console.WriteLine("Исходный массив: ");
consoleArray(testArray);

Console.WriteLine("Соритрованный массив: ");
descendingSort(testArray);
consoleArray(testArray);
// second subtask
int[,] matrix = new int[3,3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

consoleMaxValueOnTwoDimensionArray(matrix);

void consoleMaxValueOnTwoDimensionArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        int result = 0;
        for (int j = 0; j < columns; j++)
        {
         if (array[i, j] > result)
            {
                result = array[i, j];
            }
        }
        Console.WriteLine("{0}ый ряд, макс значение: {1}", i + 1, result);
    }
}


int[] fillArray()
{
    int[] numberAray = new int[6];
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("Введите {0} элемент массива", i + 1);
        int numberFromConsole = int.Parse(Console.ReadLine());
        numberAray[i] = numberFromConsole;
    }

    return numberAray;
}

void consoleArray(int[] intArray)
{
    string resultString = String.Empty;
    foreach (var number in intArray)
    {
        resultString += (number.ToString() + ", ");
    }

    Console.WriteLine(resultString);
}

void descendingSort(int[] intArray)
{
    Array.Sort(intArray);
    Array.Reverse(intArray);
}