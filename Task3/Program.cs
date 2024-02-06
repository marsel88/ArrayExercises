int[] myArray = new int[6] { 2, 8, 5, 4, 2, 0 };
int number = 2;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = myArray[i] * number;
    Console.WriteLine(myArray[i]);
}
