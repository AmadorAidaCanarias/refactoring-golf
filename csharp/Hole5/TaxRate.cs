using System;

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

        public Money Aply(Money total)
        {
            Double amount = total.value * (this.percent / 100d);
            Money tax = Money.Create(Convert.ToInt32(amount), total.currency);
            return tax;
        }
    }
}