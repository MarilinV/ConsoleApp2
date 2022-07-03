using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // BuilderConcreto
    public class HawaianaBuilder : PizzaBuilder
    {
        public HawaianaBuilder(string tamaño)
        {
            _pizza = new Pizza
            {
                Tamaño = tamaño
            };
        }      

        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "piña+tomate+jamón";
        }
    }
}
