using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsJugador: ClsPersona{

        //Registrar jugador
        public override String registrar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.jugador_insertar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Id_equipo, Numero);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar jugador
        public override String modificar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.jugador_modificar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto, Numero, Id_equipo);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista jugador
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.jugador_ListarTodo();
        }

        //Lista jugador
        public override Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_persona) {
            return M.jugador_BuscarPorID(Id_persona);
        }
        

        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID_Equipo(int Id_equipo) {
            return M.jugador_BuscarPorID_Equipo(Id_equipo);
        }

        public override String eliminar(int Id_persona){
            return M.jugador_eliminar(Id_persona);
        }



        protected int id_equipo;
        protected int numero;

        public ClsJugador(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, int Id_equipo, int Numero) : base(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto) {
            this.Id_equipo = Id_equipo;
            this.Numero = Numero;
        }
        public ClsJugador() { }

        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public int Numero { get => numero; set => numero = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


    }
}