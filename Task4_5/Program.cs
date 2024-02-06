int[] myArray = new int[6] { 2, 8, 5, 4, 2, 0 };
int averageNumber = 0;
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    sum = myArray[i] + sum;
}
averageNumber = sum / myArray.Length;
Console.WriteLine(averageNumber);