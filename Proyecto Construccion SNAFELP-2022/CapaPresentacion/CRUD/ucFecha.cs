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
    /// <summary>
    /// Fecha, Fecha que juega en un equipo de futboll
    /// </summary>
    public partial class ucFecha : UC_Pantalla {
        ClsFecha clsFecha = new ClsFecha();

        List<Object> lst_fecha;
        int id = 0;
        public ucFecha(int id, string nombre) {
            InitializeComponent();
            this.id = id;
            txtNombreCampeonato.Text = nombre;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        }

        private void btnRegistrar_Click_(object sender, EventArgs e) {
            String msj = "";
            try {
                clsFecha.Id_campeonato = Convert.ToInt32(id);
                clsFecha.Nombre = txtNombre.Text.ToString();
                clsFecha.Numero_fecha = Convert.ToInt32(txtNumero_fecha.Text);
                clsFecha.Fechainicio = DateTime.Parse(dtpFechainicio.Value.ToString());
                clsFecha.Fechafin = DateTime.Parse(dtpFechafin.Value.ToString());

                msj = clsFecha.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
        
    }
}
