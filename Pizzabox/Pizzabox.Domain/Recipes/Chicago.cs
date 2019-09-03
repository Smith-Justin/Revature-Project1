using System.Collections.Generic;
using Pizzabox.Domain.Models;
using Pizzabox.Domain.Abstracts;

namespace PizzaBox.Domain.Recipes
{
    public class Chicago : APizzaFactory
    {
        public override Pizza Make(Size s, List<Topping> t)
        {
            Crust chicagoCrust = new Crust();
            Pizza pizza = new Pizza()
            {
                Size = s,
                Crust = chicagoCrust
            };
            foreach(Topping topping in t)
            {
                pizza.Toppings.Add(topping);
            }
            
            return pizza;
        }
    }
}