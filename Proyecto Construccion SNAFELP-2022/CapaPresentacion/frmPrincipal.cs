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
    public partial class frmPrincipal: Form {

        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e) {
            //ucPersonaConsultar uc = new ucPersonaConsultar();
            MessageBox.Show("No soportado por cambios");
        }
        private void btnAdministrador_Click(object sender, EventArgs e) {
            ucAdministradorConsultar uc = new ucAdministradorConsultar();
        }
        private void btnJugador_Click(object sender, EventArgs e) {
            ucJugadorConsultar uc = new ucJugadorConsultar();
        }
        private void btnArbitro_Click(object sender, EventArgs e) {
            ucArbitroConsultar uc = new ucArbitroConsultar();
        }
        private void btnCampeonato_Click(object sender, EventArgs e) {
            ucCampeonatoConsultar uc = new ucCampeonatoConsultar();
        }
        private void btnActa_Click(object sender, EventArgs e) {
            ucActaConsultar uc = new ucActaConsultar();
        }
        private void btnFecha_Click(object sender, EventArgs e) {
            //ucFechaConsultar uc = new ucFechaConsultar();
        }
        private void btnEquipo_Click(object sender, EventArgs e) {
            ucEquipoConsultar uc = new ucEquipoConsultar();
        }
        private void btnMarcador_Click(object sender, EventArgs e) {
            //ucMarcadorConsultar uc = new ucMarcadorConsultar();
            MessageBox.Show("No soportado por cambios");
        }
        private void btnTipoalineacion_Click(object sender, EventArgs e) {
            //ucTipoalineacionConsultar uc = new ucTipoalineacionConsultar();
            MessageBox.Show("No soportado por cambios");
        }
        private void btnAlineacion_Click(object sender, EventArgs e) {
            //ucAlineacionConsultar uc = new ucAlineacionConsultar();
            MessageBox.Show("No soportado por cambios");
        }
        private void btnPartido_Click(object sender, EventArgs e) {
            //ucPartidoConsultar uc = new ucPartidoConsultar();
            MessageBox.Show("No soportado por cambios");
        }

    }
}