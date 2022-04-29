using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsAdministrador: ClsPersona{

        //Registrar administrador
        public override String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.administrador_insertar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Usuario, Psw, Puesto);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar administrador
        public override String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.administrador_modificar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Usuario, Psw, Puesto);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista administrador
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.administrador_ListarTodo();
        }

        //Lista administrador
        public override Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_persona) {
            return M.administrador_BuscarPorID(Id_persona);
        }

        public override String eliminar(int Id_persona){
            return M.administrador_eliminar(Id_persona);
        }

        public bool psw(int Id_persona, string psw) {
            return false; // M.administrador_eliminar(Id_persona);
        }

        protected string usuario;
        protected string psw_;
        protected string puesto;

        public ClsAdministrador(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Usuario, string Psw, string Puesto) : base(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto) {
            this.Usuario = Usuario;
            this.Psw = Psw;
            this.Puesto = Puesto;
        }
        public ClsAdministrador() { }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Psw { get => psw_; set => psw_ = value; }
        public string Puesto { get => puesto; set => puesto = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}