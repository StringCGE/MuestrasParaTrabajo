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
    public partial class ucAdministrador: UC_Pantalla {

        ClsAdministrador clsAdministrador = new ClsAdministrador();
        //se crea un objeto lista administrador 
        List<Object> lst_administrador;
        public ucAdministrador() {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        }
        //funcion registrar administrador con try catch para tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsAdministrador.Usuario = txtUsuario.Text.ToString();
                clsAdministrador.Psw = txtPsw.Text.ToString();
                clsAdministrador.Puesto = "Arbitro";
                clsAdministrador.Nombres = txtNombres.Text.ToString();
                clsAdministrador.Apellidos = txtApellidos.Text.ToString();
                clsAdministrador.Cedula = txtCedula.Text.ToString();
                clsAdministrador.Fechanacimiento = DateTime.Parse(dtpFechanacimiento.Value.ToString());
                clsAdministrador.Telefono = txtTelefono.Text.ToString();
                clsAdministrador.Nacionalidad = txtNacionalidad.Text.ToString();
                clsAdministrador.Foto = pictureBox1.Image;

                msj = clsAdministrador.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Image.FromFile(foto));
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void ucAdministrador_Load(object sender, EventArgs e) {

        }
    }
}