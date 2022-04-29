using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion.PanelDeControl {
    public partial class UC_PanelDeControlGeneral: UC_Pantalla {

        

        public UC_PanelDeControlGeneral() {
            //Este es el panel de control general donde tendremos accesos a los modulos
            InitializeComponent();
        }

        private void btn_persona_Click(object sender, EventArgs e) {
            
        }

        private void btn_regresar_Click(object sender, EventArgs e) {
            //retrocedemos
            Inicio.eliminar(this);
        }

        private void btnPersona_Click(object sender, EventArgs e) {
            
        }

        private void btnAdministrador_Click(object sender, EventArgs e) {
            //Ingresamos a la pantalla del administrador
            ucAdministradorConsultar uc = new ucAdministradorConsultar();
            Inicio.agregar(uc);
        }
        private void btnJugador_Click(object sender, EventArgs e) {
            //Ingresamos a la pantalla del Jugador
            ucJugadorConsultar uc = new ucJugadorConsultar();
            Inicio.agregar(uc);
        }
        private void btnArbitro_Click(object sender, EventArgs e) {
            //Ingresamos a la pantalla del arbitro
            ucArbitroConsultar uc = new ucArbitroConsultar();
            Inicio.agregar(uc);
        }
        private void btnCampeonato_Click(object sender, EventArgs e) {
            //Ingresamos a la pantalla del campeonato
            ucCampeonatoConsultar uc = new ucCampeonatoConsultar();
            Inicio.agregar(uc);
        }
        private void btnActa_Click(object sender, EventArgs e) {
            //Ingresamos a la pantalla donde estan las actas
            ucActaConsultar uc = new ucActaConsultar();
            Inicio.agregar(uc);
        }
        private void btnEquipo_Click(object sender, EventArgs e) {
            ucEquipoConsultar uc = new ucEquipoConsultar();
            Inicio.agregar(uc);
        }
        private void btnFecha_Click(object sender, EventArgs e) {
           
        }
        private void btnMarcador_Click(object sender, EventArgs e) {
            
        }
        private void btnTipoalineacion_Click(object sender, EventArgs e) {
           
        }
        private void btnAlineacion_Click(object sender, EventArgs e) {
            
        }
        private void btnPartido_Click(object sender, EventArgs e) {
            
        }
    }
}
