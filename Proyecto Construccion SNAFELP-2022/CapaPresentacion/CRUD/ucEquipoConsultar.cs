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
    public partial class ucEquipoConsultar: UC_Pantalla {
        ClsEquipo clsEquipo = new ClsEquipo();
        //se crea un objeto lista equipo
        List<Object> lst_equipo;
        SqlDataAdapter registros;
        ClsJugador clsJugador = new ClsJugador();
        //Se crea un objeto lista jugador
        List<Object> lst_jugador;

        int idEquipo = -1;
        int idJugador = -1;

        public ucEquipoConsultar() {
            InitializeComponent();
            Todo();
        }
        public ucEquipoConsultar(List<Object> lst_equipo) {
            InitializeComponent();
            //se pasan los datos de la lista equipo a esta lista
            this.lst_equipo = lst_equipo;
            Todo();
        }
        //funcion de llenar datagridview de equipo para consultar los equipos registrados
        public void llenar_datagridview_Equipo() {
            dgvEquipo.Rows.Clear();
            dgvEquipo.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                string nombre = (string)type.GetProperty("nombre").GetValue(equipo);
                Image escudo = (Image)type.GetProperty("escudo").GetValue(equipo);


                dgvEquipo.Rows.Add(id_equipo, nombre, escudo);
            }

        }
        //
        private void buscar() {
            /*
            dgvEquipo.Rows.Clear();
            dgvEquipo.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int Id_equipo = (int)type.GetProperty("Id_equipo").GetValue(equipo);
                if (Id_equipo.Equals(Convert.ToInt32(txtId_equipo.Text))) {
                    
                    int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                    int jugadores = (int)type.GetProperty("jugadores").GetValue(equipo);

                    dgvEquipo.Rows.Add(id_equipo, jugadores);
                    break;
                }
            }*/
            MessageBox.Show("No soportado por cambios");
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            /*
            //buscar();
            if (txtId_equipo.Text.Count() > 0) {
                var resultado = clsEquipo.BuscarPorID(Convert.ToInt32(txtId_equipo.Text));
                lst_equipo = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Equipo();
            } else {
                MessageBox.Show("No ha ingresado id");
            }*/
            MessageBox.Show("No soportado por cambios");
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idEquipo >= 0) {
                clsEquipo.eliminar(idEquipo);
            } else {
                MessageBox.Show("No ha seleccionado un equipo", "Ver jugadores");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            if (txtId_equipo.Text.Count() > 0) {
                var resultado = clsEquipo.BuscarPorID(Convert.ToInt32(txtId_equipo.Text));
                lst_equipo = resultado.Item1;
                //registros = resultado.Item2;
                
                ucEquipoModificar ucEquipomodificar = new ucEquipoModificar(lst_equipo);
                ucEquipomodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }*/
            MessageBox.Show("No soportado por cambios");

        }
        
        //Funcion todo, para consultar todo los equipos registrados
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Equipo();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucEquipo ucequipo = new ucEquipo();
            this.Inicio.agregar(ucequipo);
        }

        

        private void Close() {
            this.Inicio.eliminar(this);
        }
        
        private void dgvEquipo_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                lbNombreDeEquipo.Text = dgvEquipo[1, e.RowIndex].Value + "";
                idEquipo = (int)dgvEquipo[0, e.RowIndex].Value;
                JugadorPor_ID_Equipo();
            }
        }
        
        private void JugadorPor_ID_Equipo() {
            var resultado = clsJugador.BuscarPorID_Equipo(idEquipo);
            lst_jugador = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Jugador();
        }

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

        private void btnAgregarJugador_Click(object sender, EventArgs e) {
            if (idEquipo >= 0) {
                ucJugador uc = new ucJugador(idEquipo, lbNombreDeEquipo.Text);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha seleccionado un equipo", "Ver jugadores");
            }
        }
        private void Todo() {
            if (idEquipo >= 0) {
                JugadorPor_ID_Equipo();
            }
        }
        private void btnTodoJugador_Click(object sender, EventArgs e) {
            Todo();
            //if (idEquipo >= 0) {
            //    var resultado = clsJugador.BuscarPorID_Equipo(idEquipo);
            //    lst_jugador = resultado.Item1;
            //    registros = resultado.Item2;
            //    llenar_datagridview_Jugador();
            //} else {
            //    MessageBox.Show("No ha seleccionado un equipo","Ver jugadores");
            //}
        }

        private void btnModificarJugador_Click(object sender, EventArgs e) {
            if (idJugador >= 0) {
                ucJugadorModificar uc = new ucJugadorModificar(idJugador);
                this.Inicio.agregar(uc);
                Todo();
            } else {
                MessageBox.Show("No ha seleccionado un jugador", "Ver jugadores");
            }
        }

        private void dgvJugador_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                //lbNombreDeEquipo.Text = dgvEquipo[1, e.RowIndex].Value + "";
                idJugador = (int)dgvJugador[0, e.RowIndex].Value;
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e) {
            if (idJugador >= 0) {
                int index = dgvJugador.SelectedCells[0].RowIndex;
                if (MessageBox.Show("Esta segudo que desea eliminar al jugador: " + (string)dgvJugador[1, index].Value + " " + (string)dgvJugador[2, index].Value, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    clsJugador.eliminar(Convert.ToInt32(idJugador));
                    var resultado = clsJugador.listar();
                    lst_jugador = resultado.Item1;
                    registros = resultado.Item2;
                    llenar_datagridview_Jugador();
                }
            } else {
                MessageBox.Show("No ha seleccionado un jugador", "Ver jugadores");
            }
        }
    }
}