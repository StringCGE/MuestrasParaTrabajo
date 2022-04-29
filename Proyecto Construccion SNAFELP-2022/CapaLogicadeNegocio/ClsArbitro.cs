using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsArbitro: ClsAdministrador{

        //Registrar arbitro
        public override String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.arbitro_insertar(Usuario, Psw, Puesto, Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Licencia);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar arbitro
        public override String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.arbitro_modificar(Usuario, Psw, Puesto, Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Licencia);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista arbitro
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.arbitro_ListarTodo();
        }

        //Lista arbitro
        public override Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_persona) {
            return M.arbitro_BuscarPorID(Id_persona);
        }

        public override String eliminar(int Id_persona){
            return M.arbitro_eliminar(Id_persona);
        }

        public Tuple<List<Object>, SqlDataAdapter> BuscarPorUsuario(string usuario) {
            return M.arbitro_BuscarPorUsuario(usuario);
        }

       public bool psw(int idUsuario, string psw) {
           return  M.arbitro_psw(idUsuario,psw); // M.administrador_eliminar(Id_persona);
       }

        protected string licencia;

        public ClsArbitro(string Usuario, string Psw, string Puesto, int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Licencia) : base(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Usuario, Psw, Puesto) {
            this.Licencia = Licencia;
        }
        public ClsArbitro() { }

        public string Licencia { get => licencia; set => licencia = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}