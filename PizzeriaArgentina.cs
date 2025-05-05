
namespace AbstractFactory 
{
     
     public class PizzeriaArgentina : Pizzeria
     {

        public override Pizza CrearPizza()
        {
            return new PizzaCancha();
        }

          public override Empanada CrearEmpanada()
        {
            return new EmpanadaDeCarne();
        }
     }
}