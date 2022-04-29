using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsFecha {

        //Registrar fecha
        public virtual String registrar() {
            string msj = "";

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.fecha_insertar(Id_fecha, Id_campeonato, Nombre, id_partidos, Numero_fecha, Fechainicio, Fechafin);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar fecha
        public virtual String modificar() {
            string msj = "";
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.fecha_modificar(Id_fecha, Id_campeonato, Nombre, Numero_fecha, Fechainicio, Fechafin);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }
            return msj;
        }

        //Lista fecha
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.fecha_ListarTodo();
        }

        //Lista fecha
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_fecha) {
            return M.fecha_BuscarPorID(Id_fecha);
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID_Campeonato(int Id_fecha) {
            return M.fecha_BuscarPorID_Campeonato(Id_fecha);
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID_Fecha(int Id_fecha) {
            return M.fecha_BuscarPorID_Campeonato(Id_fecha);
        }

        public virtual String eliminar(int Id_fecha) {
            return M.fecha_eliminar(Id_fecha);
        }



        protected int id_fecha;
        protected int id_campeonato;
        protected string nombre;
        protected List<ClsPartido> partidos;
        protected int numero_fecha;
        protected DateTime fechainicio;
        protected DateTime fechafin;

        public ClsFecha(int Id_fecha, int Id_campeonato, string Nombre, int Numero_fecha, DateTime Fechainicio, DateTime Fechafin) {
            this.Id_fecha = Id_fecha;
            this.Id_campeonato = Id_campeonato;
            this.Nombre = Nombre;
            this.Partidos = Partidos;
            this.Numero_fecha = Numero_fecha;
            this.Fechainicio = Fechainicio;
            this.Fechafin = Fechafin;
        }
        public ClsFecha() { }

        public int Id_fecha { get => id_fecha; set => id_fecha = value; }
        public int Id_campeonato { get => id_campeonato; set => id_campeonato = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<ClsPartido> Partidos { get => partidos; set => partidos = value; }
        public int Numero_fecha { get => numero_fecha; set => numero_fecha = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }


        protected int id_partidos;


        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();



    }
}