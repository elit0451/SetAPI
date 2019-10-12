using System;
using System.Collections.Generic;
using System.Text;

namespace SetAPI
{
    public class RangeSet<Integer> : Set<Integer>
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public RangeSet(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public override bool IsMember(int value)
        {
            return value >= Min && value <= Max;
        }

        public override HashSet<int> GetSet()
        {
            HashSet<int> set = new HashSet<int>();

            for(int elm = Min; elm <= Max; elm++)
            {
                set.Add(elm);
            }

            return set;
        }
    }
}
