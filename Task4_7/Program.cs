static List<int> GetPrimes(int max)
{
    List<int> primes = new List<int>();
    for (int i = 2; i <= max; i++)
    {
        bool isPrime = true;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            primes.Add(i);
        }
    }
    return primes;
}