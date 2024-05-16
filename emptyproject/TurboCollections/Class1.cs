namespace TurboCollections;

public static class TurboMaths
{
    public static void SayHello()
    {
        Console.WriteLine($"Hello, I'm {typeof(TurboMaths).FullName}");
    }
    
    public static IEnumerable<int> GetEvenNumbers(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 == 0)
            {
                yield return list[i];
            }
        }
    }

    public static IEnumerable<int> GetEvenNumbersList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 == 0)
            {
                list.Add(i);
            }
        }
        return list;
    }
}