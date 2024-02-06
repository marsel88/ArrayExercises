int[] myArray = new int[6];
Random random = new Random();
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next();
    sum += myArray[i];
}
Console.WriteLine(sum);
