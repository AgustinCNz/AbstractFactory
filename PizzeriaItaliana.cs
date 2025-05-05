
namespace AbstractFactory
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza()
        {
            return new PizzaNapolitana();    
        }
        

     public override Empanada CrearEmpanada()
        {
            return new EmpanadaCapresse();
        }
    }
}