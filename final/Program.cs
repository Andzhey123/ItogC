void PrintArray(string[] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    Console.WriteLine(result);
}
string[] NewArrayWithLengthNotHigherThan(string[] array, int a)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= a) count += 1;
    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= a)
        {
            result[count] = array[i];
            count += 1;
        }
        return result;
}
string[] array = new string[] { "345", "7851", "-2", "big data" };
PrintArray(array);
PrintArray (NewArrayWithLengthNotHigherThan(array,3));