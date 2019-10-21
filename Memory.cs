using System;

namespace HeadsTails
{
    public static class Memory
    {
        public static T HeadTail<T>(this ReadOnlyMemory<T> memory, out ReadOnlyMemory<T> tail)
        {
            tail = memory[1..];
            return memory.Span[0];
        }

        public static ReadOnlyMemory<T> HeadsTail<T>(this ReadOnlyMemory<T> memory, out T tail)
        {
            tail = memory.Span[^1];
            return memory[..^1];
        }

        public static T HeadTail<T>(this Memory<T> memory, out Memory<T> tail)
        {
            tail = memory[1..];
            return memory.Span[0];
        }

        public static Memory<T> HeadsTail<T>(this Memory<T> memory, out T tail)
        {
            tail = memory.Span[^1];
            return memory[..^1];
        }
    }
}
