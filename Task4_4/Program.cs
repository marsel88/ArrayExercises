int[] myArray = new int[6] { 2, 8, 5, 4, 2, 0 };
int maxValue = myArray[0];
int minValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (maxValue < myArray[i])
    {
        maxValue = myArray[i];
    }
}
for(int i = 0;i < myArray.Length; i++)
{
    if(minValue > myArray[i])
    {
        minValue = myArray[i];
    }
}
Console.WriteLine(maxValue);
Console.WriteLine(minValue);
