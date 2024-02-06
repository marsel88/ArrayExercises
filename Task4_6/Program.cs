int[] myArray = new int[10];

for (int i = 0; i < myArray.Length;i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
int maxValue = myArray[0];
int minValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (maxValue < myArray[i])
    {
        maxValue = myArray[i];
    }
}
for (int i = 0; i < myArray.Length; i++)
{
    if (minValue > myArray[i])
    {
        minValue = myArray[i];
    }
}
Console.WriteLine("Наибольший элемент массива" + " " + maxValue);
Console.WriteLine("Наименьший элемент массива" + " " + minValue);

