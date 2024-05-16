namespace TurboCollections
{
    public static class ListClass
    {
        public static List<int> list = new List<int>();

        static ListClass()
        {
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);
        }

        public static void Main(string[] args)
        {
            IEnumerable<int> enumerablelist = list;

            var i = 0;
            while (i < list.Count)
            {
                Console.WriteLine(list[i]);
                ++i;
            }

            TurboMaths.GetEvenNumbers
        }
    }
}