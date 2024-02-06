string[] myArray = new string[12];
DateTime months = DateTime.Now;
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = string.Format("{0:MMMM}", DateTime.Now.AddMonths(i-1));
    months = DateTime.Now;
}

for(int i = 0;i < myArray.Length; i++)
{
    if (myArray[i].Length > 5)
    {
        Console.WriteLine(myArray[i]);
    }
}
