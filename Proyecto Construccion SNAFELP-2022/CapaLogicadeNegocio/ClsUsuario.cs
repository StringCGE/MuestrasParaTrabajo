using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicadeNegocio {
    class ClsUsuario {

        ClsAdministrador clsAdministrador = new ClsAdministrador();
        ClsArbitro clsArbitro = new ClsArbitro();

        protected int id_persona;
        protected string usuario;
        protected string puesto;
        protected Image foto;

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public Image Foto { get => foto; set => foto = value; }

        public ClsUsuario() {

        }

        public void BuscarUsuario(string usuario) {

        }

        
        List<Object> lst_administrador;

        public Boolean PswAdministrador(string psw) {
            //var resultado = clsAdministrador.buscarid(Convert.ToInt32(txtId_persona.Text));
            //lst_administrador = resultado.Item1;

            ////Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            //foreach (var administrador in lst_administrador) {
            //    System.Type type = administrador.GetType();

            //    int id_persona = (int)type.GetProperty("id_persona").GetValue(administrador);
            //    string nombres = (string)type.GetProperty("nombres").GetValue(administrador);
            //    string apellidos = (string)type.GetProperty("apellidos").GetValue(administrador);
            //    string cedula = (string)type.GetProperty("cedula").GetValue(administrador);
            //    DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(administrador);
            //    string telefono = (string)type.GetProperty("telefono").GetValue(administrador);
            //    string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(administrador);
            //    Image foto = (Image)type.GetProperty("foto").GetValue(administrador);
            //    string usuario = (string)type.GetProperty("usuario").GetValue(administrador);
            //    string psw = (string)type.GetProperty("psw").GetValue(administrador);
            //    string puesto = (string)type.GetProperty("puesto").GetValue(administrador);


            //    dgvAdministrador.Rows.Add(id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, usuario, psw, puesto);
            //}
            return false;
        }
    }
}
