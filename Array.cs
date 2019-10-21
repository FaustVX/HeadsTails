namespace HeadsTails
{
    public static class Array
    {
        public static T HeadTail<T>(this T[] array, out T[] tail)
        {
            tail = array[1..];
            return array[0];
        }

        public static T[] HeadsTail<T>(this T[] array, out T tail)
        {
            tail = array[^1];
            return array[..^1];
        }
    }
}
