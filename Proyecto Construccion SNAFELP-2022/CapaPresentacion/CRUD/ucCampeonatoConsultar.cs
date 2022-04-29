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
using CapaPresentacion.CRUD;

namespace CapaPresentacion {
    public partial class ucCampeonatoConsultar: UC_Pantalla {
        ClsCampeonato clsCampeonato = new ClsCampeonato();
        //se crea un objeto lista de campeonato
        List<Object> lst_campeonato;
        SqlDataAdapter registros;
        public ucCampeonatoConsultar() {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            dgvCampeonato.RowHeadersVisible = false;
            dgvFecha.RowHeadersVisible = false;
            todo();
        }
        //public ucCampeonatoConsultar(List<Object> lst_campeonato) {
        //    InitializeComponent();
        //    //los datos de la lista campeonato se pasan a esta lista
        //    this.lst_campeonato = lst_campeonato;
        //}
        //se llena el datagridview para con los campeonatos registrados
        public void llenar_datagridview_Campeonato() {
            dgvCampeonato.Rows.Clear();
            dgvCampeonato.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();
                int id_campeonato = (int)type.GetProperty("id_campeonato").GetValue(campeonato);
                string nombre_campeonado = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
                dgvCampeonato.Rows.Add(id_campeonato, nombre_campeonado);
            }

        }
        //funcion buscar
        private void buscar() {
            dgvCampeonato.Rows.Clear();
            dgvCampeonato.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();

                int Id_campeonato = (int)type.GetProperty("Id_campeonato").GetValue(campeonato);
                if (Id_campeonato.Equals(Convert.ToInt32(txtId_campeonato.Text))) {
                    
                    int id_campeonato = (int)type.GetProperty("id_campeonato").GetValue(campeonato);
                    string nombre_campeonado = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
                    int fechas = (int)type.GetProperty("fechas").GetValue(campeonato);

                    dgvCampeonato.Rows.Add(id_campeonato, nombre_campeonado, fechas);
                    break;
                }
            }
        }
        //funcion de buscar por id y llenar el datagridview
        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_campeonato.Text.Count() > 0) {
                var resultado = clsCampeonato.BuscarPorID(Convert.ToInt32(txtId_campeonato.Text));
                lst_campeonato = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Campeonato();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            int index;
            if (dgvCampeonato.SelectedCells.Count > 0) {
                index = dgvCampeonato.SelectedCells[0].RowIndex;
                idCampeonato = (int)dgvCampeonato[0, index].Value;
                if (MessageBox.Show("Esta segudo que desea eliminar al jugador: " + (string)dgvCampeonato[1, index].Value + " " + (string)dgvCampeonato[2, index].Value, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    clsCampeonato.eliminar(idCampeonato);
                    var resultado = clsCampeonato.listar();
                    lst_campeonato = resultado.Item1;
                    registros = resultado.Item2;
                    llenar_datagridview_Campeonato();
                }
            } else {
                MessageBox.Show("No a seleccionado un campeonato");
            }
        }
        //funcion modificar, si el de id del campeonato esta, abre otra ventana para 
        private void btnModificar_Click(object sender, EventArgs e) {
            if (idCampeonato >= 0) {
                var resultado = clsCampeonato.BuscarPorID(idCampeonato);
                lst_campeonato = resultado.Item1;
                //registros = resultado.Item2;
                
                ucCampeonatoModificar ucCampeonatomodificar = new ucCampeonatoModificar(lst_campeonato);
                this.Inicio.agregar(ucCampeonatomodificar);
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        //funcion de todo, para consultar todos los campeonatos
        private void btnTodo_Click(object sender, EventArgs e) {
            todo();
        }

        private void todo() {
            var resultado = clsCampeonato.listar();
            lst_campeonato = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Campeonato();
        }

        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        //agregar campeonato
        private void btnAgregar_Click(object sender, EventArgs e) {
            ucCampeonato uccampeonato = new ucCampeonato();
            this.Inicio.agregar(uccampeonato);
        }
        //funcion para crear el reporte del campeonato
        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucCampeonatoReporte uccampeonatoreporte = new ucCampeonatoReporte(ds);
            uccampeonatoreporte.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void dgvCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }
        
        private void dgvCampeonato_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                lbNombreDeCampeonato.Text = dgvCampeonato[1, e.RowIndex].Value + "";
                idCampeonato = (int)dgvCampeonato[0, e.RowIndex].Value;
                FechaPor_ID_Campeonato();
            }
        }

        ClsFecha clsFecha = new ClsFecha();
        List<Object> lst_fecha;

        private void FechaPor_ID_Campeonato() {
            var resultado = clsFecha.BuscarPorID_Campeonato(idCampeonato);
            lst_fecha = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Fecha();
        }



        public void llenar_datagridview_Fecha() {
            dgvFecha.Rows.Clear();
            dgvFecha.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var fecha in lst_fecha) {
                System.Type type = fecha.GetType();

                int id_fecha = (int)type.GetProperty("id_fecha").GetValue(fecha);
                string nombre = (string)type.GetProperty("nombre").GetValue(fecha);
                int numero_fecha = (int)type.GetProperty("numero_fecha").GetValue(fecha);
                DateTime fechainicio = (DateTime)type.GetProperty("fechainicio").GetValue(fecha);
                DateTime fechafin = (DateTime)type.GetProperty("fechafin").GetValue(fecha);


                dgvFecha.Rows.Add(id_fecha, nombre, numero_fecha, fechainicio, fechafin);
            }

        }

        private void btnBuscarFecha_Click(object sender, EventArgs e) {

        }

        private void btnAgregarFecha_Click(object sender, EventArgs e) {
            if (idCampeonato >= 0) {
                ucFecha uc = new ucFecha(idCampeonato, lbNombreDeCampeonato.Text);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha selecciondo un campeonato para agregar Fechas","Alerta de no seleccion");
            }
        }

        private void btnModificarFecha_Click(object sender, EventArgs e) {
            if (idFecha >= 0) {
                var resultado = clsFecha.BuscarPorID(idFecha);
                lst_fecha = resultado.Item1;
                ucFechaModificar uc = new ucFechaModificar(lst_fecha);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha selecciondo una fecha para modificar", "Alerta de no seleccion");
            }
        }

        private void btnEliminarFecha_Click(object sender, EventArgs e) {

            int index;
            if (dgvFecha.SelectedCells.Count > 0) {
                index = dgvFecha.SelectedCells[0].RowIndex;
                idFecha = (int)dgvFecha[0, index].Value;
                if (MessageBox.Show("Esta segudo que desea eliminar la fecha: " + (string)dgvFecha[1, index].Value + " " + (int)dgvFecha[2, index].Value, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    clsFecha.eliminar(idFecha);
                    var resultado = clsFecha.listar();
                    lst_fecha = resultado.Item1;
                    registros = resultado.Item2;
                    llenar_datagridview_Fecha();
                }
            } else {
                MessageBox.Show("No a seleccionado una fecha");
            }
        }

        private void btnTodoFecha_Click(object sender, EventArgs e) {
            FechaPor_ID_Campeonato();
        }

        private void btnBuscarPartidos_Click(object sender, EventArgs e) {
            if (idFecha >= 0) {
                var resultado = clsFecha.BuscarPorID(idFecha);
                lst_fecha = resultado.Item1;
                ucFechaModificar uc = new ucFechaModificar(lst_fecha);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha selecciondo una fecha para modificar", "Alerta de no seleccion");
            }
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e) {
            if (idFecha >= 0) {
                ucPartido uc = new ucPartido(idFecha, lbNombreDeFecha.Text);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha selecciondo una Fecha para agregar Partidos", "Alerta de no seleccion");
            }
        }

        private void btnModificarPartido_Click(object sender, EventArgs e) {
            try {
                idPartido = Int32.Parse(txtPartido.Text);
            } catch (Exception ex) {
                MessageBox.Show("No ha insertado un Id");
            }

            if (idPartido >= 0) {
                ucPartidoModificar uc = new ucPartidoModificar(idPartido);
                this.Inicio.agregar(uc);
            } else {
                MessageBox.Show("No ha selecciondo una Fecha para agregar Partidos", "Alerta de no seleccion");
            }
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e) {
            try {
                idPartido = Int32.Parse(txtPartido.Text);
                if (idPartido > 0) {
                    if (MessageBox.Show("Esta segudo que desea eliminar el partido con id: " + idPartido, "Eliminando", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        clsPartido.eliminar(idPartido);
                        PartidoPor_ID_Fecha();
                    }
                } else {
                    MessageBox.Show("No a seleccionado una fecha");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ingresa un pinshi numero");
            }
            
        }

        private void btnTodoPartido_Click(object sender, EventArgs e) {
            PartidoPor_ID_Fecha();
        }

        private void dgvFecha_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                lbNombreDeFecha.Text = dgvFecha[1, e.RowIndex].Value + "";
                idFecha = (int)dgvFecha[0, e.RowIndex].Value;
                PartidoPor_ID_Fecha();
            }
        }

        ClsPartido clsPartido = new ClsPartido();
        List<Object> lst_partido;

        private void PartidoPor_ID_Fecha() {
            var resultado = clsPartido.BuscarPorID_Fecha(idFecha);
            lst_partido = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Partido();
        }
        public void llenar_datagridview_Partido() {
            flp_Partidos.Controls.Clear();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var partido in lst_partido) {
                System.Type type = partido.GetType();

                int id_partido = (int)type.GetProperty("id_partido").GetValue(partido);
                //int id_fecha = (int)type.GetProperty("id_fecha").GetValue(partido);
                //string nombre = (string)type.GetProperty("nombre").GetValue(partido);

                flp_Partidos.Controls.Add(new ucItemPartido(id_partido));
            }

        }


        private void dgvPartido_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        int idCampeonato = -1;
        int idFecha = -1;
        int idPartido = -1;

        private void label1_Click(object sender, EventArgs e) {
            todo();
        }

        private void label2_Click(object sender, EventArgs e) {
            FechaPor_ID_Campeonato();
        }

        private void lbNombreDeCampeonato_Click(object sender, EventArgs e) {
            FechaPor_ID_Campeonato();
        }

        private void label4_Click(object sender, EventArgs e) {
            PartidoPor_ID_Fecha();
        }

        private void lbNombreDeFecha_Click(object sender, EventArgs e) {
            PartidoPor_ID_Fecha();
        }
        
    }
}