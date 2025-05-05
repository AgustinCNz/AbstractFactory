namespace AbstractFactory
{
    public abstract class Empanada 
    {
         protected string _descripcion;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}