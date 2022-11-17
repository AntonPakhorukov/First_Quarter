Console.Clear();
Console.Write("Вы хотите использовать исходный массив(1) или задать вручную(2)?: ");
int solution = Convert.ToInt32(Console.ReadLine());
switch (solution)
{
    case 1:
        Solution1();
        break;
    case 2:
        Solution2();
        break;
}
void Solution1()
{
    string[] array = { "Hello", "all", "world", "we", "good", "woman", "and", "man", ":-)", "we", "win" };
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    string[] GetResultArray(string[] inputArray)
    {
        int newSizeArray = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newSizeArray++;
            }
        }
        string[] resultArray = new string[newSizeArray];
        int index = 0;
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[j].Length <= 3)
            {
                resultArray[index] = inputArray[j];
                index++;
            }
        }
        return resultArray;
    }
    string[] res = GetResultArray(array);
    Console.WriteLine("[" + String.Join(", ", res) + "]");
}
void Solution2()
{
    Console.Write("Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[sizeArray];
    Console.WriteLine("Введите данные массива:");
    string[] GetArray(string[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = Console.ReadLine();
        }
        return inputArray;
    }
    array = GetArray(array);
    Console.Clear();
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}


