using System.Collections.Generic;
using Pizzabox.Domain.Abstracts;
using Pizzabox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
    public class NewYork : APizzaFactory
    {
        public override Pizza Make(Size s, List<Topping> t)
        {
            Crust newYorkCrust = new Crust();
            Pizza pizza = new Pizza()
            {
                Size = s,
                Crust = newYorkCrust
            };
            foreach(Topping topping in t)
            {
                pizza.Toppings.Add(topping);
            }
            
            return pizza;
        }
    }
}