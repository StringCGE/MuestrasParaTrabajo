using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion {
    public partial class Inicio: Form {

        
       
        public Inicio() {
            InitializeComponent();
            uC_Login1.Location = new Point(0, 24);
            pantalla.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e) {
            limpiar();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }
        public void limpiar() {
            /*
            List<Control> ctrl_s = new List<Control>();
            foreach (Control c in this.Controls) {
                if (this.menuStrip1.Equals(c) == false) {
                    ctrl_s.Add(c);
                }
            }
            foreach (Control c in ctrl_s) {
                this.Controls.Remove(c);
                c.Dispose();
            }
            */
            pantalla.Controls.Clear();
        }

        private void consolaToolStripMenuItem_Click(object sender, EventArgs e) {
            PanelDeControl.UC_PanelDeControlGeneral uc = new PanelDeControl.UC_PanelDeControlGeneral();
            agregar(uc);
        }

        public void agregar(UC_Pantalla value) {
            pantalla.Controls.Add(value);
            value.Inicio = this;
            value.Dock = DockStyle.Fill;
            value.BringToFront();
        }

        public void eliminar(UC_Pantalla value) {
            pantalla.Controls.Remove(value);
            value.Dispose();
        }

        private void pantalla_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void Ingresar(int id_persona) {
            uC_Login1.Visible = false;
            uC_Session1.Asignar(id_persona);
        }

        public void Salir() {
            uC_Login1.Visible = true;
            uC_Login1.Limpiar();
        }

        private void CerrarLoAnterior() {
            pantalla.Controls.Clear();
        }

        private void btnAdministrador_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            //Ingresamos a la pantalla del administrador
            ucAdministradorConsultar uc = new ucAdministradorConsultar();
            agregar(uc);
        }
        private void btnJugador_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            //Ingresamos a la pantalla del Jugador
            ucJugadorConsultar uc = new ucJugadorConsultar();
            agregar(uc);
        }
        private void btnArbitro_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            //Ingresamos a la pantalla del arbitro
            ucArbitroConsultar uc = new ucArbitroConsultar();
            agregar(uc);
        }
        private void btnCampeonato_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            //Ingresamos a la pantalla del campeonato
            ucCampeonatoConsultar uc = new ucCampeonatoConsultar();
            agregar(uc);
        }
        private void btnActa_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            //Ingresamos a la pantalla donde estan las actas
            ucActaConsultar uc = new ucActaConsultar();
            agregar(uc);
        }
        private void btnEquipo_Click(object sender, EventArgs e) {
            CerrarLoAnterior();
            ucEquipoConsultar uc = new ucEquipoConsultar();
            agregar(uc);
        }
    }
}
