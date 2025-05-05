using System.Runtime.CompilerServices;
using AbstractFactory;

namespace AbstractFactory
{
    public class PizzeriaChina : Pizzeria
    {

        public override Pizza CrearPizza()
        {
              return new PizzaSushi() ;

        }
        
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaCeviche();
        }
    }
}