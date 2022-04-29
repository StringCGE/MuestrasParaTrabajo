using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaLogicadeNegocio;

namespace CapaPresentacion {
    public partial class ucAdministradorConsultar: UC_Pantalla {
        ClsAdministrador clsAdministrador = new ClsAdministrador();
        //se crea un obejto lista
        List<Object> lst_administrador;
        SqlDataAdapter registros;
        public ucAdministradorConsultar() {
            InitializeComponent();
        }
        public ucAdministradorConsultar(List<Object> lst_administrador) {
            InitializeComponent();
            //se le pasa los datos de la lista adminisrador a esta lista
            this.lst_administrador = lst_administrador;
        }
        //Funcion de llenar el datagridview con la lista de los administradores registrados
        public void llenar_datagridview_Administrador() {
            dgvAdministrador.Rows.Clear();
            dgvAdministrador.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var administrador in lst_administrador) {
                System.Type type = administrador.GetType();
                
                int id_persona = (int)type.GetProperty("id_persona").GetValue(administrador);
                string nombres = (string)type.GetProperty("nombres").GetValue(administrador);
                string apellidos = (string)type.GetProperty("apellidos").GetValue(administrador);
                string cedula = (string)type.GetProperty("cedula").GetValue(administrador);
                DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(administrador);
                string telefono = (string)type.GetProperty("telefono").GetValue(administrador);
                string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(administrador);
                Image foto = (Image)type.GetProperty("foto").GetValue(administrador);
                string usuario = (string)type.GetProperty("usuario").GetValue(administrador);
                string psw = (string)type.GetProperty("psw").GetValue(administrador);
                string puesto = (string)type.GetProperty("puesto").GetValue(administrador);
                
                dgvAdministrador.Rows.Add(id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, usuario, psw, puesto);
            }



        }
        
        private void buscar() {
            dgvAdministrador.Rows.Clear();
            dgvAdministrador.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var administrador in lst_administrador) {
                System.Type type = administrador.GetType();

                int Id_persona = (int)type.GetProperty("Id_persona").GetValue(administrador);
                if (Id_persona.Equals(Convert.ToInt32(txtId_persona.Text))) {
                    
                    int id_persona = (int)type.GetProperty("id_persona").GetValue(administrador);
                    string nombres = (string)type.GetProperty("nombre_persona").GetValue(administrador);
                    string apellidos = (string)type.GetProperty("apellido").GetValue(administrador);
                    string cedula = (string)type.GetProperty("cedula").GetValue(administrador);
                    string usuario = (string)type.GetProperty("usuario").GetValue(administrador);
                    string psw = (string)type.GetProperty("psw").GetValue(administrador);

                    dgvAdministrador.Rows.Add(id_persona, nombres, apellidos, cedula, usuario, psw);
                    break;
                }
            }
        }
        //Funcion buscar administradores en la lista por medio de su Id
        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsAdministrador.BuscarPorID(Convert.ToInt32(txtId_persona.Text));
                lst_administrador = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Administrador();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (txtId_persona.Text.Count() > 0) {
                clsAdministrador.eliminar(Convert.ToInt32(txtId_persona.Text));
                var resultado = clsAdministrador.listar();
                lst_administrador = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Administrador();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsAdministrador.BuscarPorID(Convert.ToInt32(txtId_persona.Text));
                lst_administrador = resultado.Item1;
                //registros = resultado.Item2;
                
                ucAdministradorModificar ucAdministradormodificar = new ucAdministradorModificar(lst_administrador);
                ucAdministradormodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        
        //Funcion todo, para consultar todos los administradores registrados
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsAdministrador.listar();
            lst_administrador = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Administrador();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucAdministrador ucadministrador = new ucAdministrador();
            this.Inicio.agregar(ucadministrador);
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            //ucAdministradorReporte ucadministradorreporte = new ucAdministradorReporte(ds);
            //ucadministradorreporte.Show();
            MessageBox.Show("No soportado por cambios");
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}