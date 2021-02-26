using System.Collections;
using MD2_4.Models;

namespace MD2_4.Helpers
{
    public class AnimalCompare : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Animal;
            var y = second as Animal;

            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}