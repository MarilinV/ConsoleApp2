using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Builder
    public abstract class PizzaBuilder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Pizza _pizza;
        public string Tamaño { get; set; }

        public Pizza ObtenerPizza() { return _pizza; }

        // Un paso para cada una de las propiedades
        public virtual void PasoPrepararMasa()
        {
        }

        public virtual void PasoAñadirSalsa()
        {
        }

        public virtual void PasoPrepararRelleno()
        {
        }

        public virtual void PasoDoblarPoizza()
        {
        }
    }
}
