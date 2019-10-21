using System;

namespace HeadsTails
{
    public static class Span
    {
        public static T HeadTail<T>(this ReadOnlySpan<T> span, out ReadOnlySpan<T> tail)
        {
            tail = span[1..];
            return span[0];
        }

        public static ReadOnlySpan<T> HeadsTail<T>(this ReadOnlySpan<T> span, out T tail)
        {
            tail = span[^1];
            return span[..^1];
        }

        public static T HeadTail<T>(this Span<T> span, out Span<T> tail)
        {
            tail = span[1..];
            return span[0];
        }

        public static Span<T> HeadsTail<T>(this Span<T> span, out T tail)
        {
            tail = span[^1];
            return span[..^1];
        }
    }
}
