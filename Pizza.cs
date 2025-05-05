
namespace AbstractFactory
{
    public abstract class Pizza
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