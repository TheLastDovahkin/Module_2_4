using System;

namespace MD2_4.Models
{
   public abstract class Animal
    {
        protected Animal(int weight, string name, int quantity)
        {
            Weight = weight;
            Name = name;
            BornDate = DateTime.Now;
            Quantity = quantity;
        }

        public int Weight { get; }

        public string Name { get; }

        public DateTime BornDate { get; }

        public double Quantity { get; }
    }
}
