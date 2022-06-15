using ProyectoVigilante2.Modelos;

namespace ProyectoVigilante2
{
    public class UserClass
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public string TL { get; set; }
        public bool esContratista { get; set; }
        public bool retroalimentacion { get; set; }
        public DataForm datosFormUsuario;

        public UserClass()
        {
        }
    }
}