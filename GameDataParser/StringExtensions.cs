static class StringExtensions
{
    public static bool IsEmpty(this string str) => str.Length == 0;
    public static bool IsNull(this string str) => str == null;
}
