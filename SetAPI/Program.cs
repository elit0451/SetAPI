using System;

namespace SetAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadKey();
        }

        private void Run()
        {
            RangeSet<int> rangeSet1 = new RangeSet<int>(5, 25);
            RangeSet<int> rangeSet2 = new RangeSet<int>(1, 4);
            int result = rangeSet1.CompareTo(rangeSet2);


            Console.WriteLine(result);
        }
    }
}
