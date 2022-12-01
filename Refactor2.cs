using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGeneric
{
    public class Refactor2<T> where T : IComparable<T>
        {
            public T first, second, third;

            public Refactor2(T first, T second, T third)
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }

            public static T findmax(T first, T second, T third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                    first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
                {
                    return first;
                }
                if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
                {
                    return second;
                }
                if (third.CompareTo(second) > 0 && first.CompareTo(first) > 0 ||
                    third.CompareTo(second) >= 0 && first.CompareTo(first) > 0 ||
                    third.CompareTo(second) > 0 && first.CompareTo(first) >= 0)
                {
                    return third;
                }
                return default;
            }
            public T MaxMethod()
            {
                T max = Refactor2<T>.findmax(this.first, this.second, this.third);
                return max;
            }
        }
}
