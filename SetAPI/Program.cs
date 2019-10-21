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
            // Create 2 sets
            RangeSet<int> rangeSet1 = new RangeSet<int>(5, 25);
            RangeSet<int> rangeSet2 = new RangeSet<int>(1, 4);
            
            // Get result which will tell if the 2 sets are comparable or if one is a subset of the other
            int result = rangeSet1.CompareTo(rangeSet2);

            Console.WriteLine(result);
        }
    }
}
