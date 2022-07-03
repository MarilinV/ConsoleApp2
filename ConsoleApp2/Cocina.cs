using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Director
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada
        {
            get { return _pizzaBuilder.ObtenerPizza(); }

        }
    }
}
