
namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected string _descripcion = "";

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}