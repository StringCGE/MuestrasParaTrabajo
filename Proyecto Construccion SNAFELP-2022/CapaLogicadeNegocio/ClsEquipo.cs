using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio {
    public class ClsEquipo {

        //Registrar equipo
        public virtual String registrar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.equipo_insertar(Id_equipo, Nombre, Escudo);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar equipo
        public virtual String modificar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.equipo_modificar(Id_equipo, Nombre, Escudo);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista equipo
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.equipo_ListarTodo();
        }

        //Lista equipo
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_equipo) {
            return M.equipo_BuscarPorID(Id_equipo);
        }

        public virtual String eliminar(int Id_equipo) {
            return M.equipo_eliminar(Id_equipo);
        }



        protected int id_equipo;
        protected string nombre;
        protected Image escudo;

        public ClsEquipo(int Id_equipo, string Nombre, Image Escudo) {
            this.Id_equipo = Id_equipo;
            this.Nombre = Nombre;
            this.Escudo = Escudo;
        }
        public ClsEquipo() { }

        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Image Escudo { get => escudo; set => escudo = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();



    }
}