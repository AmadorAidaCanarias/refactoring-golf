namespace Hole5
{
    public class TaxRate
    {
        public readonly int percent;

        public TaxRate(int percent)
        {
            this.percent = percent;
        }

        public static TaxRate Of(int percent) {
            return new TaxRate(percent);
        }
    }
}