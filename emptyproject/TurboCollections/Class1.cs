namespace TurboCollections;

public static class TurboMaths
{
    public static void SayHello()
    {
        Console.WriteLine($"Hello, I'm {typeof(TurboMaths).FullName}");
    }
    
    public static IEnumerable<int> GetEvenNumbers(int maxNumber)
    {
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }

    public static IEnumerable<int> GetEvenNumbersList(int maxNumber)
    {
        List<int> evenNumbers = new List<int>();
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }
        }

        return evenNumbers;
    }
}