using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsCampeonato{

        //Registrar campeonato
        public virtual String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.campeonato_insertar(Id_campeonato, Nombre_campeonado);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar campeonato
        public virtual String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.campeonato_modificar(Id_campeonato, Nombre_campeonado);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista campeonato
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.campeonato_ListarTodo();
        }

        //Lista campeonato
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_campeonato) {
            return M.campeonato_BuscarPorID(Id_campeonato);
        }

        public virtual String eliminar(int Id_campeonato){
            return M.campeonato_eliminar(Id_campeonato);
        }



        protected int id_campeonato;
        protected string nombre_campeonado;
        protected List<ClsFecha> fechas;

        public ClsCampeonato(int Id_campeonato, string Nombre_campeonado) {
            this.Id_campeonato = Id_campeonato;
            this.Nombre_campeonado = Nombre_campeonado;
            this.Fechas = Fechas;
        }
        public ClsCampeonato() { }

        public int Id_campeonato { get => id_campeonato; set => id_campeonato = value; }
        public string Nombre_campeonado { get => nombre_campeonado; set => nombre_campeonado = value; }
        public List<ClsFecha> Fechas { get => fechas; set => fechas = value; }

        


        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}