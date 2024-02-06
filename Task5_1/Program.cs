using System;

int[] firstArray = new int[6];
int[] secondArray = new int[6];
Random random = new Random();
int result = 0;

for (int i = 0; i < firstArray.Length; i++) 
{
    firstArray[i] = random.Next();
    secondArray[i] = random.Next();
}
for(int i = 0; i < firstArray.Length; i++)
{
    result += firstArray[i] * secondArray[i];
}

Console.WriteLine(result);




