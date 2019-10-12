using System;
using System.Collections.Generic;
using System.Text;

namespace SetAPI
{
    public class ComplementSet<Integer> : Set<Integer>
    {
        public Set<Integer> CurrentSet { get; set; }
        public ComplementSet(Set<Integer> current)
        {
            CurrentSet = current;
        }
        public override bool IsMember(int value)
        {
            return !CurrentSet.IsMember(value);
        }
        public override HashSet<int> GetSet()
        {
            HashSet<int> set = new HashSet<int>(CurrentSet.GetSet());
            set.ExceptWith(set);

            return set;
        }
    }
}
