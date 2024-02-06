int[] myArray = new int[6] { 2, 7, 4, 7, 5, 1 };
int number = 4;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] == number)
    {
        Console.WriteLine("Число" + " " + number + " " + "найдено");
        break;
    }
}
