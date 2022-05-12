namespace Hole2
{
    public class Pair<A, B>
    {
        public readonly A value;
        public readonly B currency;

        public Pair(A value, B currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
}