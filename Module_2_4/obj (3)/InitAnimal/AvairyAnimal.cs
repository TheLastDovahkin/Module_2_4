using MD2_4.Models;

namespace MD2_4.InitAnimal
{
    public abstract class AvairyAnimal : Init
    {
        protected AvairyAnimal(int weight, string name, int quantity)
            : base(weight, name, quantity)
        {
        }

        public abstract AnimalArr[] Animal { get; }
    }
}
