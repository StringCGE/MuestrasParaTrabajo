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
    public partial class ucArbitroModificar: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto lista arbitro
        List<Object> lst_arbitro;
        string puesto = "";
        int idArbitro = -1;
        public ucArbitroModificar(List<Object> lst_arbitro) {
            InitializeComponent();
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            //se pasan los datos de la lista arbitro a esta lista
            this.lst_arbitro = lst_arbitro;
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                txtUsuario.Text = (string)type.GetProperty("usuario").GetValue(arbitro);
                txtPsw.Text = (string)type.GetProperty("psw").GetValue(arbitro);
                puesto = (string)type.GetProperty("puesto").GetValue(arbitro);
                idArbitro = (int)type.GetProperty("id_persona").GetValue(arbitro);
                txtNombres.Text = (string)type.GetProperty("nombres").GetValue(arbitro);
                txtApellidos.Text = (string)type.GetProperty("apellidos").GetValue(arbitro);
                txtCedula.Text = (string)type.GetProperty("cedula").GetValue(arbitro);
                dtpFechanacimiento.Value = (DateTime)type.GetProperty("fechanacimiento").GetValue(arbitro);
                txtTelefono.Text = (string)type.GetProperty("telefono").GetValue(arbitro);
                txtNacionalidad.Text = (string)type.GetProperty("nacionalidad").GetValue(arbitro);
                pbFoto.Image = (Image)type.GetProperty("foto").GetValue(arbitro);
                txtLicencia.Text = (string)type.GetProperty("licencia").GetValue(arbitro);

            }
        }
        //funcion modificar con try catch para la tolerancia a fallos
        private void btnModificar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsArbitro.Usuario = txtUsuario.Text.ToString();
                clsArbitro.Psw = txtPsw.Text.ToString();
                clsArbitro.Puesto = puesto;
                clsArbitro.Id_persona = idArbitro;
                clsArbitro.Nombres = txtNombres.Text.ToString();
                clsArbitro.Apellidos = txtApellidos.Text.ToString();
                clsArbitro.Cedula = txtCedula.Text.ToString();
                clsArbitro.Fechanacimiento = DateTime.Parse(dtpFechanacimiento.Value.ToString());
                clsArbitro.Telefono = txtTelefono.Text.ToString();
                clsArbitro.Nacionalidad = txtNacionalidad.Text.ToString();
                clsArbitro.Foto = pbFoto.Image;
                clsArbitro.Licencia = txtLicencia.Text.ToString();


                msj = clsArbitro.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pbFoto.Image = new Bitmap(Image.FromFile(foto));
            }
        }
    }
}