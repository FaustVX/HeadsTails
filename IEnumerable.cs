using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadsTails
{
    public static class Enumerable
    {
        public static T HeadTail<T>(this IEnumerable<T> source, out IEnumerable<T> tail)
        {
            tail = source.Skip(1);
            return source.First();

            var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
                throw new InvalidOperationException();

            var head = enumerator.Current;

            tail = Tail(enumerator);
            return head;

            static IEnumerable<T> Tail(IEnumerator<T> source)
            {
                while (source.MoveNext())
                    yield return source.Current;
            }
        }

        public static IEnumerable<T> HeadsTail<T>(this IEnumerable<T> source, out T tail)
        {
            tail = source.Last();
            return source.SkipLast(1);
        }
    }
}
