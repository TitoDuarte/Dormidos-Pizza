using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormidos_Pizza
{
    class Sucursales
    {
        public string Nombre;
        public List<Pizza> listPizza = new List<Pizza>();

        public Sucursales(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public void agregarPizza(Pizza pizza)
        {
            listPizza.Add(pizza);
        }
    }
}

