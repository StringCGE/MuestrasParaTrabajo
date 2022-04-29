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
    public partial class ucEquipoModificar: UC_Pantalla {
        ClsEquipo clsEquipo = new ClsEquipo();
        //se crea lista equipo
        List<Object> lst_equipo;
        public ucEquipoModificar(List<Object> lst_equipo) {
            InitializeComponent();
            /*
            //se pasan los datos de la lista equipo a esta lista
            this.lst_equipo = lst_equipo;
            
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                txtId_equipo.Text = ((int)type.GetProperty("id_equipo").GetValue(equipo)).ToString();
                clsEquipo.Jugadores = new ClsJugador();
                txtJugadores.Text = ((ClsJugador)type.GetProperty("jugadores").GetValue(equipo)).ToString();

            }*/
            MessageBox.Show("No soportado por cambios");
        }
        //funcion modificar con try catch para la tolerancia a fallos
        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            String msj = "";
            try {
                clsEquipo.Id_equipo = Convert.ToInt32(txtId_equipo.Text);
                clsEquipo.Jugadores = new ClsJugador();
                clsEquipo.Jugadores.Id_persona = Convert.ToInt32(txtJugadores.Text);


                msj = clsEquipo.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }*/
            MessageBox.Show("No soportado por cambios");
        }
        //funcion de listar jugadores en un equipo
        private void btnJugadores_Click(object sender, EventArgs e) {
            
        }
        //cerrrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}