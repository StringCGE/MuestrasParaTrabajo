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
    /// Fecha, Fecha que juega en un equipo de futboll
    /// </summary>
    public partial class ucFechaModificar : UC_Pantalla {
        ClsFecha clsFecha = new ClsFecha();
        List<Object> lst_fecha;

        ClsCampeonato clsCampeonato = new ClsCampeonato();
        List<Object> lst_campeonato;

        int idfecha = -1;
        int idcampeonato = -1;

        string nombrecampeonado = "";

        public ucFechaModificar(List<Object> lst_fecha) {
            InitializeComponent();

            this.lst_fecha = lst_fecha;

            foreach (var fecha in lst_fecha) {
                System.Type type = fecha.GetType();

                idfecha = (int)type.GetProperty("id_fecha").GetValue(fecha);
                idcampeonato = (int)type.GetProperty("id_campeonato").GetValue(fecha);
                txtNombre.Text = (string)type.GetProperty("nombre").GetValue(fecha);
                txtNumero_fecha.Text = ((int)type.GetProperty("numero_fecha").GetValue(fecha)).ToString();
                dtpFechainicio.Value = (DateTime)type.GetProperty("fechainicio").GetValue(fecha);
                dtpFechafin.Value = (DateTime)type.GetProperty("fechafin").GetValue(fecha);

            }

            var resultado = clsCampeonato.BuscarPorID(idcampeonato);
            lst_campeonato = resultado.Item1;

            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();
                txtNombreCampeonato.Text = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsFecha.Id_fecha = idfecha;
                clsFecha.Id_campeonato = idcampeonato;
                clsFecha.Nombre = txtNombre.Text.ToString();
                clsFecha.Numero_fecha = Convert.ToInt32(txtNumero_fecha.Text);
                clsFecha.Fechainicio = DateTime.Parse(dtpFechainicio.Value.ToString());
                clsFecha.Fechafin = DateTime.Parse(dtpFechafin.Value.ToString());
                
                msj = clsFecha.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}
