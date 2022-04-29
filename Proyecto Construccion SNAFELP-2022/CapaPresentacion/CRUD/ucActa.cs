using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicadeNegocio;

namespace CapaPresentacion {
    public partial class ucActa: UC_Pantalla {
        ClsActa clsActa = new ClsActa();
        //se crea objeto lista de acta
        List<Object> lst_acta;
        public ucActa() {
            InitializeComponent();
        }
        //funcion regitrar acta con try catch para tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            /*
            String msj = "";
            try {
                clsActa.Fecha = new ClsFecha();
                clsActa.Fecha.Id_fecha = Convert.ToInt32(txtFecha.Text);
                clsActa.Partido = new ClsPartido();
                clsActa.Partido.Id_partido = Convert.ToInt32(txtPartido.Text);
                clsActa.Marcador_acta = new ClsMarcador();
                clsActa.Marcador_acta.Id_marcador = Convert.ToInt32(txtMarcador_acta.Text);
                clsActa.Equipoa_acta = new ClsEquipo();
                clsActa.Equipoa_acta.Id_equipo = Convert.ToInt32(txtEquipoa_acta.Text);
                clsActa.Equipob_acta = new ClsEquipo();
                clsActa.Equipob_acta.Id_equipo = Convert.ToInt32(txtEquipob_acta.Text);

                msj = clsActa.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }*/
            MessageBox.Show("No soportado por cambios");
        }
        //funcion consultar para abrir la ventana de consultas
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de acta registrados para que sean
            //tratados en el otro formulario.
            ucActaConsultar ucActaCons = new ucActaConsultar(lst_acta);
            ucActaCons.Show();
        }

        private void btnFecha_Click(object sender, EventArgs e) {
            /*
            //lst_acta = clsActa.listar();
            //this.Hide();
            ucFecha uc = new ucFecha();
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }

        private void btnPartido_Click(object sender, EventArgs e) {
            /*
            //lst_acta = clsActa.listar();
            //this.Hide();
            ucPartido uc = new ucPartido();
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }
        //Funcion del marcador para ver el resultado
        private void btnMarcador_acta_Click(object sender, EventArgs e) {
            /*
            //lst_acta = clsActa.listar();
            //this.Hide();
            ucMarcador uc = new ucMarcador();
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }
        //Funcion para obtener la acta del equipo a
        private void btnEquipoa_acta_Click(object sender, EventArgs e) {
            //lst_acta = clsActa.listar();
            //this.Hide();
            ucEquipo uc = new ucEquipo();
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
        }
        //Funcion para obtener la acta del equipo b
        private void btnEquipob_acta_Click(object sender, EventArgs e) {
            //lst_acta = clsActa.listar();
            //this.Hide();
            ucEquipo uc = new ucEquipo();
            var resultado = clsActa.listar();
            lst_acta = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}