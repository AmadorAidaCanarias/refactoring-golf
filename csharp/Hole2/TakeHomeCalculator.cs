using System;
using System.Collections.Generic;
using System.Linq;

namespace Hole2
{
    public class TakeHomeCalculator
    {
        private readonly int percent;

        public TakeHomeCalculator(int percent)
        {
            this.percent = percent;
        }

        public Pair<int, String> NetAmount(Pair<int, String> first, params Pair<int, String>[] rest)
        {
            List<Pair<int, String>> pairs = rest.ToList();

            Pair<int, String> total = first;

            foreach (Pair<int, String> next in pairs)
            {
                if (!next.currency.Equals(total.currency))
                {
                    throw new Incalculable();
                }
            }

            foreach (Pair<int, String> next in pairs)
            {
                total = new Pair<int, String>(total.value + next.value, next.currency);
            }

            Double amount = total.value * (percent / 100d);
            Pair<int, String> tax = new Pair<int, String>(Convert.ToInt32(amount), first.currency);

            if (!total.currency.Equals(tax.currency))
            {
                throw new Incalculable();
            }

            return new Pair<int, String>(total.value - tax.value, first.currency);
        }
    }
}