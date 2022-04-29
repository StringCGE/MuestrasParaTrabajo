using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsPersona{

        //Registrar persona
        public virtual String registrar() {
            string msj = "";
            
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.persona_insertar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Registrar persona
        public virtual String modificar() {
            string msj = "";
        
            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                M.persona_modificar(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad, Foto);
                msj = "Modificado correctamente";
            } catch (Exception ex) {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Lista persona
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.persona_ListarTodo();
        }

        //Lista persona
        public virtual Tuple<List<Object>, SqlDataAdapter> BuscarPorID(int Id_persona) {
            return M.persona_BuscarPorID(Id_persona);
        }

        public virtual String eliminar(int Id_persona){
            return M.persona_eliminar(Id_persona);
        }



        protected int id_persona;
        protected string nombres;
        protected string apellidos;
        protected string cedula;
        protected DateTime fechanacimiento;
        protected string telefono;
        protected string nacionalidad;
        protected Image foto;

        public ClsPersona(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto) {
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Fechanacimiento = Fechanacimiento;
            this.Telefono = Telefono;
            this.Nacionalidad = Nacionalidad;
            this.Foto = Foto;
        }
        public ClsPersona() { }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public Image Foto { get => foto; set => foto = value; }




        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();


        
    }
}