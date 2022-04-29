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
    /// Jugador, jugador que juega en un equipo de futboll
    /// </summary>
    public partial class ucJugador: UC_Pantalla {
        

        /// <summary>
        /// Clase en la capa Logica de negocio par ainteractuar cin jugador
        /// </summary>
        ClsJugador clsJugador = new ClsJugador();
        ClsEquipo clsEquipo = new ClsEquipo();

        /// <summary>
        /// Lista para enviar multiples registros de jugador a la capa logica de negocio
        /// </summary>
        List<Object> lst_jugador;

        List<Object> lst_equipo;
        protected int idEquipo = -1;
        /// <summary>
        /// Bob construye; ¿Podrán hacerlo?; Bob construye; ¡Sí podremos!
        /// </summary>
        public ucJugador(int idEquipo, string nombre) {
            InitializeComponent();
            cmbEquipo.ValueMember = "Id_equipo";
            cmbEquipo.DisplayMember = "Nombre";
            cmbEquipo.Text = nombre;
            this.idEquipo = idEquipo;
            init();
            cmbEquipo.SelectedValue = idEquipo;
            cmbEquipo.Enabled = false;
        }
        public ucJugador() {
            InitializeComponent();
            cmbEquipo.ValueMember = "Id_equipo";
            cmbEquipo.DisplayMember = "Nombre";
            this.idEquipo = -1;
            init();
            cmbEquipo.Enabled = true;
        }
        protected void init() {
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            llenar_cmbEquipo();
            
        }
        /// <summary>
        /// Metodo controlador de evento del boton Registrar que llama a un metodo Registrar
        /// </summary>
        /// <param name="sender">objeto en el que ocurre el evento</param>
        /// <param name="e">argumento de evento que indica las sircunstancias del eevento (EFE porque justamente este evento no trae nada adicional en esta variable)</param>
        private void btnRegistrar_Click(object sender, EventArgs e) {
            Registrar();
        }
        

        /// <summary>
        ///  Metodo Registrar en el cual se lee los valores de los campos y se los envia almacenados en la lista a travez de clsJugador
        /// </summary>
        /// <returns></returns>
        public bool Registrar() {
            String msj = "";
            try {
                //clsJugador.Id_persona;
                clsJugador.Nombres = txtNombres.Text.ToString();
                clsJugador.Apellidos = txtApellidos.Text.ToString();
                clsJugador.Cedula = txtCedula.Text.ToString();
                clsJugador.Fechanacimiento = dtpFechanacimiento.Value;
                clsJugador.Telefono = txtTelefono.Text.ToString();
                clsJugador.Nacionalidad = txtNacionalidad.Text;
                clsJugador.Numero = Convert.ToUInt16(txtNumero.Text);
                clsJugador.Foto = pictureBox1.Image;

                clsJugador.Id_equipo = this.idEquipo;
                msj = clsJugador.registrar();

                
                MessageBox.Show(msj);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void llenar_cmbEquipo() {
            cmbEquipo.Items.Clear();
            cmbEquipo.ValueMember = "Id_equipo";
            cmbEquipo.DisplayMember = "Nombre";
            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                string nombre = (string)type.GetProperty("nombre").GetValue(equipo);
                Image escudo = (Image)type.GetProperty("escudo").GetValue(equipo);

                cmbEquipo.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
            }

        }

        /// <summary>
        /// evento para cerrar ventana a travez del boton Regresar
        /// </summary>
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        /// <summary>
        /// cerrar ventana y regresar
        /// </summary>
        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String foto = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Image.FromFile(foto));
            }
        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e) {
            this.idEquipo = (int)((ClsEquipo)cmbEquipo.SelectedItem).Id_equipo;
        }
    }
}