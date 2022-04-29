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
    public partial class ucCampeonatoModificar: UC_Pantalla {
        ClsCampeonato clsCampeonato = new ClsCampeonato();
        //se crea un objeto campeonato
        List<Object> lst_campeonato;
        int idcampeonato = -1;
        public ucCampeonatoModificar(List<Object> lst_campeonato) {
            InitializeComponent();
            //se pasan los datos lista campeonato a esta lista
            this.lst_campeonato = lst_campeonato;
            //se buscan los datos de lista campeonato 
            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();

                idcampeonato = (int)type.GetProperty("id_campeonato").GetValue(campeonato);
                txtNombre_campeonado.Text = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
                clsCampeonato.Fechas = new List<ClsFecha>();
                //txtFechas.Text = ((ClsFecha)type.GetProperty("fechas").GetValue(campeonato)).ToString();

            }
        }
        //funcion modficar los datos de campeonato
        private void btnModificar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsCampeonato.Id_campeonato = idcampeonato;
                clsCampeonato.Nombre_campeonado = txtNombre_campeonado.Text.ToString();
                clsCampeonato.Fechas = new List<ClsFecha>();
                //clsCampeonato.Fechas[clsCampeonato.Fechas.Count - 1].Id_fecha = Convert.ToInt32(txtFechas.Text);


                msj = clsCampeonato.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechas_Click(object sender, EventArgs e) {
            lst_campeonato = clsCampeonato.listar().Item1;
            //this.Hide();
            //ucFecha uc = new ucFecha();
            //uc.Show();//Dialog();
            //this.Show();
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
    }
}