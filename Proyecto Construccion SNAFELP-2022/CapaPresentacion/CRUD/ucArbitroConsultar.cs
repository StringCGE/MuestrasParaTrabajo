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
    public partial class ucArbitroConsultar: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto de lista arbitro
        List<Object> lst_arbitro;
        SqlDataAdapter registros;
        public ucArbitroConsultar() {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        }
        public ucArbitroConsultar(List<Object> lst_arbitro) {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            //se pasan los datos de lista arbitro a esta lista
            this.lst_arbitro = lst_arbitro;
        }
        //funcion de llenar el datagridview para la consulta de los arbitros registrados
        public void llenar_datagridview_Arbitro() {
            dgvArbitro.Rows.Clear();
            dgvArbitro.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                int id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                string usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                string psw = (string)type.GetProperty("psw").GetValue(arbitro);
                string puesto = (string)type.GetProperty("puesto").GetValue(arbitro);
                string nombres = (string)type.GetProperty("nombres").GetValue(arbitro);
                string apellidos = (string)type.GetProperty("apellidos").GetValue(arbitro);
                string cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(arbitro);
                string telefono = (string)type.GetProperty("telefono").GetValue(arbitro);
                string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(arbitro);
                Image foto = (Image)type.GetProperty("foto").GetValue(arbitro);
                string licencia = (string)type.GetProperty("licencia").GetValue(arbitro);


                dgvArbitro.Rows.Add(id_persona, usuario, "****", puesto, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, licencia);
            }

        }
        //Funcion buscar un arbitro
        private void buscar() {
            dgvArbitro.Rows.Clear();
            dgvArbitro.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                int Id_persona = (int)type.GetProperty("Id_persona").GetValue(arbitro);
                if (Id_persona.Equals(Convert.ToInt32(txtId_persona.Text))) {
                    
                    string usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                    string psw = (string)type.GetProperty("psw").GetValue(arbitro);
                    int id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                    string nombres = (string)type.GetProperty("nombre_persona").GetValue(arbitro);
                    string apellidos = (string)type.GetProperty("apellido").GetValue(arbitro);
                    string cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                    string licencia = (string)type.GetProperty("licencia").GetValue(arbitro);

                    dgvArbitro.Rows.Add(usuario, psw, id_persona, nombres, apellidos, cedula, licencia);
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsArbitro.BuscarPorID(Convert.ToInt32(txtId_persona.Text));
                lst_arbitro = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Arbitro();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        int idArbitro = -1;
        //funcion eliminar un arbitro registrado
        private void btnEliminar_Click(object sender, EventArgs e) {
            int index;
            if (dgvArbitro.SelectedCells.Count > 0) {
                index = dgvArbitro.SelectedCells[0].RowIndex;
                idArbitro = (int)dgvArbitro[0, index].Value;
                if (MessageBox.Show("Esta segudo que desea eliminar al arbitro: " + (string)dgvArbitro[5, index].Value + " " + (string)dgvArbitro[6, index].Value, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    clsArbitro.eliminar(idArbitro);
                    var resultado = clsArbitro.listar();
                    lst_arbitro = resultado.Item1;
                    registros = resultado.Item2;
                    llenar_datagridview_Arbitro();
                }
            } else {
                MessageBox.Show("No a seleccionado al Arbitro");
            }
        }
        //funcion modificar un arbitro registrado y nos abre la ventana donde lo modificaremos
        private void btnModificar_Click(object sender, EventArgs e) {
            int index;
            if (dgvArbitro.SelectedCells.Count > 0) {
                index = dgvArbitro.SelectedCells[0].RowIndex;
                idArbitro = (int)dgvArbitro[0, index].Value;

                var resultado = clsArbitro.BuscarPorID(idArbitro);
                lst_arbitro = resultado.Item1;
                //registros = resultado.Item2;
                
                ucArbitroModificar ucArbitromodificar = new ucArbitroModificar(lst_arbitro);
                this.Inicio.agregar(ucArbitromodificar);
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        //funcion todo, para consultar los arbitros registrados
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsArbitro.listar();
            lst_arbitro = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Arbitro();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucArbitro ucarbitro = new ucArbitro();
            this.Inicio.agregar(ucarbitro);
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucArbitroReporte ucarbitroreporte = new ucArbitroReporte(ds);
            ucarbitroreporte.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}