int[] myArray = new int[6] { 2, 8, 5, 4, 2, 0 };
int maxValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
    {
    if (maxValue < myArray[i])
    {
        maxValue = myArray[i];
    }
    }
Console.WriteLine(maxValue);
