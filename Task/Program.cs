Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
string[] GetArray(string[] inputArray) {
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}
array = GetArray(array);
Console.WriteLine("[" + String.Join(", ", array) + "]");
