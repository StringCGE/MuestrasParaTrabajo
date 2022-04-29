using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsActa{

        //Registrar acta
        public virtual String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.acta_insertar(Id_acta, Nombre, id_fecha, id_partido, id_marcador_acta, id_equipoa_acta, id_equipob_acta);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar acta
        public virtual String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.acta_modificar(Id_acta, Nombre, id_fecha, id_partido, id_marcador_acta, id_equipoa_acta, id_equipob_acta);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista acta
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.acta_ListarTodo();
        }

        //Lista acta
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_acta) {
            return M.acta_BuscarPorID(Id_acta);
        }

        public virtual String eliminar(int Id_acta){
            return M.acta_eliminar(Id_acta);
        }



        protected int id_acta;
        protected string nombre;
        protected ClsFecha fecha;
        protected ClsPartido partido;
        protected ClsMarcador marcador_acta;
        protected ClsEquipo equipoa_acta;
        protected ClsEquipo equipob_acta;

        public ClsActa(int Id_acta, string Nombre) {
            this.Id_acta = Id_acta;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
            this.Partido = Partido;
            this.Marcador_acta = Marcador_acta;
            this.Equipoa_acta = Equipoa_acta;
            this.Equipob_acta = Equipob_acta;
        }
        public ClsActa() { }

        public int Id_acta { get => id_acta; set => id_acta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ClsFecha Fecha { get => fecha; set => fecha = value; }
        public ClsPartido Partido { get => partido; set => partido = value; }
        public ClsMarcador Marcador_acta { get => marcador_acta; set => marcador_acta = value; }
        public ClsEquipo Equipoa_acta { get => equipoa_acta; set => equipoa_acta = value; }
        public ClsEquipo Equipob_acta { get => equipob_acta; set => equipob_acta = value; }


        protected int id_fecha;
        protected int id_partido;
        protected int id_marcador_acta;
        protected int id_equipoa_acta;
        protected int id_equipob_acta;


        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}