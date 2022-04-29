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
    public partial class ucJugadorConsultar: UC_Pantalla {
        ClsJugador clsJugador = new ClsJugador();
        //Se crea un objeto lista jugador
        List<Object> lst_jugador;
        SqlDataAdapter registros;
        int idJugador = -1;

        public ucJugadorConsultar() {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            Todo();
        }
        public ucJugadorConsultar(List<Object> lst_jugador) {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            //Se pasa los datos de la lista jugador a esta lista jugador
            this.lst_jugador = lst_jugador;
        }
        //Funcion de llenar datagridview jugador y se muestren los jugadores registrados
        public void llenar_datagridview_Jugador() {
            dgvJugador.Rows.Clear();
            dgvJugador.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var jugador in lst_jugador) {
                System.Type type = jugador.GetType();

                int id_persona = (int)type.GetProperty("id_persona").GetValue(jugador);
                string nombres = (string)type.GetProperty("nombres").GetValue(jugador);
                string apellidos = (string)type.GetProperty("apellidos").GetValue(jugador);
                string cedula = (string)type.GetProperty("cedula").GetValue(jugador);
                DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(jugador);
                string telefono = (string)type.GetProperty("telefono").GetValue(jugador);
                string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(jugador);
                Image foto = (Image)type.GetProperty("foto").GetValue(jugador);
                int numero = (int)type.GetProperty("numero").GetValue(jugador);
                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(jugador);


                dgvJugador.Rows.Add(id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, numero, id_equipo);
            }

        }
        


        //Funcion para eliminar
        private void btnEliminar_Click(object sender, EventArgs e) {
            int index;
            if (dgvJugador.SelectedCells.Count > 0) {
                index = dgvJugador.SelectedCells[0].RowIndex;
                idJugador = (int)dgvJugador[0, index].Value;
                if (MessageBox.Show("Esta segudo que desea eliminar al jugador: " + (string)dgvJugador[1, index].Value + " " + (string)dgvJugador[2, index].Value, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    clsJugador.eliminar(Convert.ToInt32(idJugador));
                    var resultado = clsJugador.listar();
                    lst_jugador = resultado.Item1;
                    registros = resultado.Item2;
                    llenar_datagridview_Jugador();
                }
            } else {
                MessageBox.Show("No a seleccionado a un jugador");
            }
            /*MessageBox.Show("No soportado por cambios");*/
        }
        int idEquipo = -1;
        private void btnModificar_Click(object sender, EventArgs e) {
            if (idJugador >= 0) {
                ucJugadorModificar uc = new ucJugadorModificar(idJugador);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("Selecione al jugador ue quiere modificar");
            }
        }

        private void Todo() {
            var resultado = clsJugador.listar();
            lst_jugador = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Jugador();
        }

        private void btnTodo_Click(object sender, EventArgs e) {
            Todo();
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        
        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucJugadorReporte ucjugadorreporte = new ucJugadorReporte(ds);
            ucjugadorreporte.Show();

            MessageBox.Show("No soportado por cambios");*/
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucJugador uc = new ucJugador();
            this.Inicio.agregar(uc);
        }

        private void dgvJugador_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                idJugador = (int)dgvJugador[0, e.RowIndex].Value;
            }
        }
    }
}