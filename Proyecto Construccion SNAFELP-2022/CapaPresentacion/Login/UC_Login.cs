using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicadeNegocio;

namespace CapaPresentacion {
    public partial class UC_Login: UC_Pantalla {

        ClsArbitro clsArbitro = new ClsArbitro();
        List<Object> lst_arbitro;
        int idUsuario = -1;

        public UC_Login() {
            InitializeComponent();

            this.pbUsuario.Image = global::CapaPresentacion.Properties.Resources.usuario;
            this.pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            if (ParentForm is Inicio) {
                if (clsArbitro.psw(idUsuario, txt_psw.Text)) {
                    ((Inicio)ParentForm).Ingresar(idUsuario);
                }  
            }
        }

        public void Limpiar() {
            txt_Usuario.Text = "";
            txt_psw.Text = "";
            this.pbUsuario.Image = global::CapaPresentacion.Properties.Resources.usuario;
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e) {
            if (txt_Usuario.Text != "") {
                var resultado = clsArbitro.BuscarPorUsuario(txt_Usuario.Text);
                lst_arbitro = resultado.Item1;
                if (lst_arbitro.Count > 0) {
                    System.Type type = lst_arbitro[0].GetType();

                    idUsuario = (int)type.GetProperty("id_persona").GetValue(lst_arbitro[0]);
                    //txtNombres.Text = (string)type.GetProperty("nombres").GetValue(jugador);
                    //txtApellidos.Text = (string)type.GetProperty("apellidos").GetValue(jugador);
                    //txtCedula.Text = (string)type.GetProperty("cedula").GetValue(jugador);
                    //dtpFechanacimiento.Value = (DateTime)type.GetProperty("fechanacimiento").GetValue(jugador);
                    //txtTelefono.Text = (string)type.GetProperty("telefono").GetValue(jugador);
                    //txtNacionalidad.Text = (string)type.GetProperty("nacionalidad").GetValue(jugador);
                    pbUsuario.Image = (Image)type.GetProperty("foto").GetValue(lst_arbitro[0]);
                    //txtNumero.Text = ((int)type.GetProperty("numero").GetValue(jugador)).ToString();

                    //idEquipo = (int)type.GetProperty("id_equipo").GetValue(jugador);
                    //cmbEquipo.SelectedValue = idEquipo;
                } else {
                    pbUsuario.Image = global::CapaPresentacion.Properties.Resources.usuario;
                }
            }
        }
        
        private void BuscarUsuario() {
        }
    }
}
