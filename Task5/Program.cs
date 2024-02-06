int[] myArray = new int[6] { 2, 8, 5, 4, 2, 0 };
Array.Sort(myArray, Comparer<int>.Create((x, y) => y.CompareTo(x)));
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
