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
    public partial class ucEquipo: UC_Pantalla {
        ClsEquipo clsEquipo = new ClsEquipo();
        //se crea un objeto de lista equipo
        List<Object> lst_equipo;
        public ucEquipo() {
            InitializeComponent();

        }
        //funcion registrar equipo con try cacth para la tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsEquipo.Nombre = txtNombre.Text.ToString();
                clsEquipo.Escudo = pictureBox1.Image;

                msj = clsEquipo.registrar();
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

        private void btnAgregarEscudo_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Image.FromFile(foto));
            }
        }
    }
}