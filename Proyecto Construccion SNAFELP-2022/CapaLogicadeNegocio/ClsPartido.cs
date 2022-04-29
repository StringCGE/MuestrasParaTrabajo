using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsPartido{

        //Registrar partido
        public virtual String registrar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.partido_insertar(Id_partido, Id_fecha, Nombre, id_equipo_a, id_equipo_b, id_marcador_partido, id_arbitroprincipal);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar partido
        public virtual String modificar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.partido_modificar(Id_partido, Id_fecha, Nombre, id_equipo_a, id_equipo_b, id_marcador_partido, id_arbitroprincipal);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista partido
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.partido_ListarTodo();
        }

        //Lista partido
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_partido) {
            return M.partido_BuscarPorID(Id_partido);
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID_Todo(int Id_partido) {
            return M.partido_BuscarPorID_Todo(Id_partido);
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID_Fecha(int Id_fecha) {
            return M.partido_BuscarPorID_Fecha(Id_fecha);
        }

        public virtual String eliminar(int Id_partido){
            return M.partido_eliminar(Id_partido);
        }




        protected int id_partido;
        protected int id_fecha;
        protected string nombre;
        protected ClsEquipo equipo_a;
        protected ClsEquipo equipo_b;
        protected ClsMarcador marcador_partido;
        protected ClsArbitro arbitroprincipal;

        public ClsPartido(int Id_partido, int Id_fecha, string Nombre) {
            this.Id_partido = Id_partido;
            this.Id_fecha = Id_fecha;
            this.Nombre = Nombre;
            this.Equipo_a = Equipo_a;
            this.Equipo_b = Equipo_b;
            this.Marcador_partido = Marcador_partido;
            this.Arbitroprincipal = Arbitroprincipal;
        }
        public ClsPartido() { }

        public int Id_partido { get => id_partido; set => id_partido = value; }
        public int Id_fecha { get => id_fecha; set => id_fecha = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ClsEquipo Equipo_a { get => equipo_a; set => equipo_a = value; }
        public ClsEquipo Equipo_b { get => equipo_b; set => equipo_b = value; }
        public ClsMarcador Marcador_partido { get => marcador_partido; set => marcador_partido = value; }
        public ClsArbitro Arbitroprincipal { get => arbitroprincipal; set => arbitroprincipal = value; }


        public int id_equipo_a;
        public int id_equipo_b;
        public int id_marcador_partido;
        public int id_arbitroprincipal;


        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();



    }
}