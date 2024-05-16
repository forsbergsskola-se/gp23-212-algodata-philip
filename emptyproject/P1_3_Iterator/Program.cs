using System.Collections;

List<int> list = new List<int>();
list.Add(1);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(5);

IEnumerable<int> enumerablelist = list;

var i = 0;
while(i  < list.Count)
{
    Console.WriteLine(list[i]);
    ++i;
}