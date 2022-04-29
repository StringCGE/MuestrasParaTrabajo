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
    public partial class ucCampeonato: UC_Pantalla {
        ClsCampeonato clsCampeonato = new ClsCampeonato();
        //se crea un objeto lista campeonato
        List<Object> lst_campeonato;
        public ucCampeonato() {
            InitializeComponent();

        }
        //se registra nombre y fecha del campeonato
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsCampeonato.Nombre_campeonado = txtNombre_campeonado.Text.ToString();

                msj = clsCampeonato.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnFechas_Click(object sender, EventArgs e) {
            /*
            //lst_campeonato = clsCampeonato.listar();
            //this.Hide();
            ucFecha uc = new ucFecha();
            var resultado = clsCampeonato.listar();
            lst_campeonato = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();*/
            MessageBox.Show("No soportado por cambios");
        }

        private void btnFechasAgrega_Click(object sender, EventArgs e) {
            
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void txtNombre_campeonado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e) {
            this.Inicio.eliminar(this);
        }
    }
}