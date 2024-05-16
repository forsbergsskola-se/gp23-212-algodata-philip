using System.Collections;

List<int> list = new List<int>();
list.Add(137);
list.Add(1000);
list.Add(-200);

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

ArrayList arrayList = new ArrayList();
arrayList.Add(true);
arrayList.Add("Forsbergs");
arrayList.Add('a');
arrayList.Add(1000);
arrayList.Add(.12f);

for (int i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}