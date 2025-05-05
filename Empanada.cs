namespace AbstractFactory
{
    public abstract class Empanada 
    {
         protected string _descripcion = string.Empty;

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}