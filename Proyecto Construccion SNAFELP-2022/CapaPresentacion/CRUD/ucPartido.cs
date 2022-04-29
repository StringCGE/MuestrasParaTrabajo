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
using System.Data.SqlClient;

namespace CapaPresentacion {
    /// <summary>
    /// Fecha, Fecha que juega en un equipo de futboll
    /// </summary>
    public partial class ucPartido : UC_Pantalla {
        ClsPartido clsPartido = new ClsPartido();
        ClsEquipo clsEquipo = new ClsEquipo();
        ClsArbitro clsArbitro = new ClsArbitro();

        List<Object> lst_partido;
        List<Object> lst_equipo;
        List<Object> lst_arbitro;


        SqlDataAdapter registros;

        int idFecha = -1;
        

        int id = 0;
        public ucPartido(int idfecha, String nombreFecha) {
            InitializeComponent();

            idFecha = idfecha;
            txtNombreFecha.Text = nombreFecha;

            cmbEquipo_A.DisplayMember = "Nombre";
            cmbEquipo_B.DisplayMember = "Nombre";
            cmbArbitro.DisplayMember = "Apellidos";

            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;

            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                string nombre = (string)type.GetProperty("nombre").GetValue(equipo);
                Image escudo = (Image)type.GetProperty("escudo").GetValue(equipo);

                cmbEquipo_A.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
                cmbEquipo_B.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
            }

            resultado = clsArbitro.listar();
            lst_arbitro = resultado.Item1;
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                string usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                string psw = (string)type.GetProperty("psw").GetValue(arbitro);
                string puesto = (string)type.GetProperty("puesto").GetValue(arbitro);
                int id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                string nombres = (string)type.GetProperty("nombres").GetValue(arbitro);
                string apellidos = (string)type.GetProperty("apellidos").GetValue(arbitro);
                string cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(arbitro);
                string telefono = (string)type.GetProperty("telefono").GetValue(arbitro);
                string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(arbitro);
                Image foto = (Image)type.GetProperty("foto").GetValue(arbitro);
                string licencia = (string)type.GetProperty("licencia").GetValue(arbitro);
                
                cmbArbitro.Items.Add(new ClsArbitro(usuario, psw, puesto, id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, foto, licencia));
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        protected int id_equipo_a;
        protected int id_equipo_b;
        protected int id_marcador_partido;
        protected int id_arbitroprincipal;

        private void cmbEquipo_A_SelectedIndexChanged(object sender, EventArgs e) {
            ClsEquipo cls = (ClsEquipo)cmbEquipo_A.SelectedItem;
            id_equipo_a = cls.Id_equipo;
        }

        private void cmbEquipo_B_SelectedIndexChanged(object sender, EventArgs e) {
            ClsEquipo cls = (ClsEquipo)cmbEquipo_B.SelectedItem;
            id_equipo_b = cls.Id_equipo;
        }

        private void cmbArbitro_SelectedIndexChanged(object sender, EventArgs e) {
            ClsArbitro cls = (ClsArbitro)cmbArbitro.SelectedItem;
            id_arbitroprincipal = cls.Id_persona;
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsPartido.Id_fecha = idFecha;
                clsPartido.Nombre = txtNombre.Text;
                clsPartido.id_equipo_a = id_equipo_a;
                clsPartido.id_equipo_b = id_equipo_b;

                clsPartido.id_arbitroprincipal = id_arbitroprincipal;

                msj = clsPartido.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
