
int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
    System.Console.WriteLine();
}

// bool FindNumber(int num, int[] array)
// {
//     foreach (int item in array)
//     {
//         if (item == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }
int[] singInvert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

System.Console.Write("Input size of array; ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value; ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value; ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
PrintArray(singInvert(arr));