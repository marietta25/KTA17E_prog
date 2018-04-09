using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_04
{
    class Month
    {
        public KeyValuePair<int, int> findMonth(List<DateTime> dates)
        {
            List<int> months = new List<int> { };

            foreach (var item in dates)
            {
                var month = item.Month;
                months.Add(month);
            }

            var birthdayMonths = new Dictionary<int, int>();
            var g = months.GroupBy(i => i);
            foreach (var item in g)
            {
                birthdayMonths.Add(item.Key, item.Count());
            }

            var max = birthdayMonths.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var maxValue = birthdayMonths.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;

            return new KeyValuePair<int, int>(max, maxValue);
        }
    }
}
