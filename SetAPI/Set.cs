using System;
using System.Collections.Generic;
using System.Text;

namespace SetAPI
{
    public abstract class Set<Integer>
    {
        public abstract bool IsMember(int value);
        public Set<Integer> Union(Set<Integer> set)
        {
            return new UnionSet<Integer>(this, set);
        }
        public Set<Integer> Intersection(Set<Integer> set)
        {
            return new IntersectionSet<Integer>(this, set);
        }
        public Set<Integer> Difference(Set<Integer> set)
        {
            return new DifferenceSet<Integer>(this, set);
        }
        public Set<Integer> Complement()
        {
            return new ComplementSet<Integer>(this);
        }
        public int CompareTo(Set<Integer> set)
        {
            int result = -2;
            HashSet<int> firstSet = this.GetSet();
            HashSet<int> secondSet = set.GetSet();

            if (firstSet.SetEquals(secondSet))
                result = 0;
            else if (firstSet.Count < secondSet.Count)
            {
                bool allInSecond = true;
                foreach(int i in firstSet)
                {
                    if (!set.IsMember(i))
                        allInSecond = false;
                }
                if (allInSecond)
                    result = -1;
            }
            else if (firstSet.Count > secondSet.Count)
            {
                bool allInFirst = true;
                foreach (int i in secondSet)
                {
                    if (!this.IsMember(i))
                        allInFirst = false;
                }
                if (allInFirst)
                    result = 1;
            }

            return result;
        }

        public abstract HashSet<int> GetSet();
    }
}
