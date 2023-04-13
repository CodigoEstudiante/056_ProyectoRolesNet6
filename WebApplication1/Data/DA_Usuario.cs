using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DA_Usuario
    {
        //USAR REFERENCIAS MODELS

        public List<Usuario> ListaUsuario() {

            return new List<Usuario>
            {
                new Usuario{ Nombre ="jose", Correo = "administrador@gmail.com", Clave= "123" , Roles = new string[]{"Administrador"} },
                new Usuario{ Nombre ="maria", Correo = "supervisor@gmail.com", Clave= "123" , Roles = new string[]{"Supervisor"} },
                new Usuario{ Nombre ="juan", Correo = "empleado@gmail.com", Clave= "123" , Roles = new string[]{"Empleado"} },
                new Usuario{ Nombre ="oscar", Correo = "superempleado@gmail.com", Clave= "123" , Roles = new string[]{"Supervisor","Empleado"} }

            };

        }

        public Usuario ValidarUsuario(string _correo, string _clave) {

            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();

        }

    }
}
