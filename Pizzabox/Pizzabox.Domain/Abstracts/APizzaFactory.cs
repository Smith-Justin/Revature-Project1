using System.Collections.Generic;
using Pizzabox.Domain.Models;

namespace Pizzabox.Domain.Abstracts
{
    public abstract class APizzaFactory
    {
        protected List<AOrderable> _orderables;

        public List<AOrderable> Orderables
        {
            get{return _orderables;}
        }
        
        public abstract Pizza Make(Size s, List<Topping> t);
    }
}