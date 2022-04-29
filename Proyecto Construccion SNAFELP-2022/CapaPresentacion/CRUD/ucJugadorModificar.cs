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
    public partial class ucJugadorModificar : UC_Pantalla {
        ClsJugador clsJugador = new ClsJugador();
        ClsEquipo clsEquipo = new ClsEquipo();
        //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        List<Object> lst_jugador;

        protected int idEquipo = -1;
        List<Object> lst_equipo;

        public ucJugadorModificar(int idJugador) {
            InitializeComponent();

            var resultado = clsJugador.BuscarPorID(idJugador);
            lst_jugador = resultado.Item1;
            foreach (var jugador in lst_jugador) {
                System.Type type = jugador.GetType();
                
                txtId_persona.Text = ((int)type.GetProperty("id_persona").GetValue(jugador)).ToString();
                txtNombres.Text = (string)type.GetProperty("nombres").GetValue(jugador);
                txtApellidos.Text = (string)type.GetProperty("apellidos").GetValue(jugador);
                txtCedula.Text = (string)type.GetProperty("cedula").GetValue(jugador);
                dtpFechanacimiento.Value = (DateTime)type.GetProperty("fechanacimiento").GetValue(jugador);
                txtTelefono.Text = (string)type.GetProperty("telefono").GetValue(jugador);
                txtNacionalidad.Text = (string)type.GetProperty("nacionalidad").GetValue(jugador);
                pictureBox1.Image = (Image)type.GetProperty("foto").GetValue(jugador);
                txtNumero.Text = ((int)type.GetProperty("numero").GetValue(jugador)).ToString();
                
                idEquipo = (int)type.GetProperty("id_equipo").GetValue(jugador);
                //cmbEquipo.SelectedValue = idEquipo;
            }

            resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            cmbEquipo.Items.Clear();
            cmbEquipo.ValueMember = "Id_equipo";
            cmbEquipo.DisplayMember = "Nombre";

            string nombreEquipo = "";
            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                string nombre = (string)type.GetProperty("nombre").GetValue(equipo);
                Image escudo = (Image)type.GetProperty("escudo").GetValue(equipo);

                cmbEquipo.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
                if(idEquipo == id_equipo) {
                    nombreEquipo = nombre;
                }
            }

            cmbEquipo.Text = nombreEquipo;
            //cmbEquipo.SelectedValue = idEquipo;
        }
        

        

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Image.FromFile(foto));
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsJugador.Id_persona = Convert.ToInt32(txtId_persona.Text);
                clsJugador.Nombres = txtNombres.Text.ToString();
                clsJugador.Apellidos = txtApellidos.Text.ToString();
                clsJugador.Cedula = txtCedula.Text.ToString();
                clsJugador.Fechanacimiento = DateTime.Parse(dtpFechanacimiento.Value.ToString());
                clsJugador.Telefono = txtTelefono.Text.ToString();
                clsJugador.Nacionalidad = txtNacionalidad.Text.ToString();
                clsJugador.Foto = pictureBox1.Image;
                clsJugador.Numero = Convert.ToInt32(txtNumero.Text);
                clsJugador.Id_equipo = Convert.ToInt32(idEquipo);
                
                msj = clsJugador.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e) {
            
        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e) {
            this.idEquipo = (int)((ClsEquipo)cmbEquipo.SelectedItem).Id_equipo;
        }
    }
}