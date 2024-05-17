using System.Collections;
using TurboCollections;

List<int> iterator = new List<int>();
iterator.Add(1);
iterator.Add(1);
iterator.Add(2);
iterator.Add(3);
iterator.Add(5);

IEnumerator enumerator = iterator.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(iterator.Sum());
}

List<int> evennumbers = (List<int>)TurboMaths.GetEvenNumbersList(1_000_000_000);
foreach (var item in evennumbers)
{
    Console.WriteLine(item);
}

foreach (var item in TurboMaths.GetEvenNumbers(1_000_000_000))
{
    Console.WriteLine(item);
}