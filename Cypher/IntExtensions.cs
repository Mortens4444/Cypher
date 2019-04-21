namespace Cypher
{
    public class IntExtensions
    {
        public static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}