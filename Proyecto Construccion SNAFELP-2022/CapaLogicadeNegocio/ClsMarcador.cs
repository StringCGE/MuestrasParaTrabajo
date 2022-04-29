using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsMarcador{

        //Registrar marcador
        public virtual String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.marcador_insertar(Id_marcador, Goleaequipoa, Golesequipob);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar marcador
        public virtual String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.marcador_modificar(Id_marcador, Goleaequipoa, Golesequipob);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista marcador
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.marcador_ListarTodo();
        }

        //Lista marcador
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_marcador) {
            return M.marcador_BuscarPorID(Id_marcador);
        }

        public virtual String eliminar(int Id_marcador){
            return M.marcador_eliminar(Id_marcador);
        }



        protected int id_marcador;
        protected ushort goleaequipoa;
        protected ushort golesequipob;

        public ClsMarcador(int Id_marcador, ushort Goleaequipoa, ushort Golesequipob) {
            this.Id_marcador = Id_marcador;
            this.Goleaequipoa = Goleaequipoa;
            this.Golesequipob = Golesequipob;
        }
        public ClsMarcador() { }

        public int Id_marcador { get => id_marcador; set => id_marcador = value; }
        public ushort Goleaequipoa { get => goleaequipoa; set => goleaequipoa = value; }
        public ushort Golesequipob { get => golesequipob; set => golesequipob = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}