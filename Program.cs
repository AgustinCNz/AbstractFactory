namespace AbstractFactory.Consola.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria fabrica;
            fabrica = new PizzeriaArgentina();

            Pizza pizza = fabrica.CrearPizza();
            Empanada empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");

            // Console.WriteLine(pizza.Descripcion);

            fabrica = new PizzeriaItaliana();
            pizza = fabrica.CrearPizza();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");

            // Console.WriteLine(pizza.Descripcion);

            fabrica = new PizzeriaChina();
            pizza = fabrica.CrearPizza();
            Console.WriteLine(pizza.Descripcion);
            Console.ReadKey();
        }
    }
}