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
    public partial class ucArbitro: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto lista arbitro
        List<Object> lst_arbitro;
        public ucArbitro() {
            InitializeComponent();
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;

        }
        //funcion registrar arbitro con try cacth para tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsArbitro.Usuario = txtUsuario.Text.ToString();
                clsArbitro.Psw = txtPsw.Text.ToString();
                clsArbitro.Puesto = "Arbitro";
                clsArbitro.Nombres = txtNombres.Text.ToString();
                clsArbitro.Apellidos = txtApellidos.Text.ToString();
                clsArbitro.Cedula = txtCedula.Text.ToString();
                clsArbitro.Fechanacimiento = DateTime.Parse(dtpFechanacimiento.Value.ToString());
                clsArbitro.Telefono = txtTelefono.Text.ToString();
                clsArbitro.Nacionalidad = txtNacionalidad.Text.ToString();
                clsArbitro.Foto = pictureBox1.Image;
                clsArbitro.Licencia = txtLicencia.Text.ToString();

                msj = clsArbitro.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        //cerrrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void btnFoto_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Image.FromFile(foto));
            }
        }
    }
}