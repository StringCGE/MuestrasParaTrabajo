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
    public partial class ucActaConsultar: UC_Pantalla {
        ClsActa clsActa = new ClsActa();
        //se crea objeto lista de acta
        List<Object> lst_acta;
        SqlDataAdapter registros;
        public ucActaConsultar() {
            InitializeComponent();
        }
        public ucActaConsultar(List<Object> lst_acta) {
            InitializeComponent();
            //se pasan los datos de la lista acta a esta lista
            this.lst_acta = lst_acta;
        }
        //se llena el datagridview de las actas
        public void llenar_datagridview_Acta() {
            dgvActa.Rows.Clear();
            dgvActa.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var acta in lst_acta) {
                System.Type type = acta.GetType();

                int id_acta = (int)type.GetProperty("id_acta").GetValue(acta);
                int fecha = (int)type.GetProperty("fecha").GetValue(acta);
                int partido = (int)type.GetProperty("partido").GetValue(acta);
                int marcador_acta = (int)type.GetProperty("marcador_acta").GetValue(acta);
                int equipoa_acta = (int)type.GetProperty("equipoa_acta").GetValue(acta);
                int equipob_acta = (int)type.GetProperty("equipob_acta").GetValue(acta);

                
                dgvActa.Rows.Add(id_acta, fecha, partido, marcador_acta, equipoa_acta, equipob_acta);
            }

        }
        //funcion buscar 
        private void buscar() {
            dgvActa.Rows.Clear();
            dgvActa.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var acta in lst_acta) {
                System.Type type = acta.GetType();

                int Id_acta = (int)type.GetProperty("Id_acta").GetValue(acta);
                if (Id_acta.Equals(Convert.ToInt32(txtId_acta.Text))) {
                    
                    int id_acta = (int)type.GetProperty("id_acta").GetValue(acta);
                    int fecha = (int)type.GetProperty("fecha").GetValue(acta);
                    int partido = (int)type.GetProperty("partido").GetValue(acta);
                    int marcador_acta = (int)type.GetProperty("marcador_acta").GetValue(acta);
                    int equipoa_acta = (int)type.GetProperty("equipoa_acta").GetValue(acta);
                    int equipob_acta = (int)type.GetProperty("equipob_acta").GetValue(acta);

                    dgvActa.Rows.Add(id_acta, fecha, partido, marcador_acta, equipoa_acta, equipob_acta);
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_acta.Text.Count() > 0) {
                var resultado = clsActa.BuscarPorID(Convert.ToInt32(txtId_acta.Text));
                lst_acta = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Acta();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (txtId_acta.Text.Count() > 0) {
                clsActa.eliminar(Convert.ToInt32(txtId_acta.Text));
                var resultado = clsActa.listar();
                lst_acta = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Acta();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (txtId_acta.Text.Count() > 0) {
                var resultado = clsActa.BuscarPorID(Convert.ToInt32(txtId_acta.Text));
                lst_acta = resultado.Item1;
                //registros = resultado.Item2;
                MessageBox.Show("No soportado por cambios");
                /*ucActaModificar ucActamodificar = new ucActaModificar(lst_acta);
                ucActamodificar.Show();*/
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        

        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Acta();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucActa ucacta = new ucActa();
            this.Inicio.agregar(ucacta);
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucActaReporte ucactareporte = new ucActaReporte(ds);
            ucactareporte.Show();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}