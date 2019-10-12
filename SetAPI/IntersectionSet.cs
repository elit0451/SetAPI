using System;
using System.Collections.Generic;
using System.Text;

namespace SetAPI
{
    public class IntersectionSet<Integer> : Set<Integer>
    {
        public Set<Integer> FirstSet { get; set; }
        public Set<Integer> SecondSet { get; set; }
        public IntersectionSet(Set<Integer> first, Set<Integer> second)
        {
            FirstSet = first;
            SecondSet = second;
        }
        public override bool IsMember(int value)
        {
            return FirstSet.IsMember(value) && SecondSet.IsMember(value);
        }
        public override HashSet<int> GetSet()
        {
            HashSet<int> set = new HashSet<int>(FirstSet.GetSet());
            set.IntersectWith(SecondSet.GetSet());

            return set;
        }
    }
}
