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
    public partial class ucPartidoModificar : UC_Pantalla {
        ClsPartido clsPartido = new ClsPartido();

        List<Object> lst_partido;

        ClsFecha clsFecha = new ClsFecha();
        List<Object> lst_fecha;

        int idPartido = -1;
        int id_fecha = -1;
        public ucPartidoModificar(int idPartido) {
            InitializeComponent();
            this.idPartido = idPartido;
            //this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;

            cmbEquipo_A.DisplayMember = "Nombre";
            cmbEquipo_B.DisplayMember = "Nombre";
            cmbArbitro.DisplayMember = "Apellidos";

            var resultado = clsPartido.BuscarPorID(idPartido);
            lst_partido = resultado.Item1;

            foreach (var partido in lst_partido) {
                System.Type type = partido.GetType();
                
                //txtId_fecha.Text = ((int)type.GetProperty("id_fecha").GetValue(partido)).ToString();
                txtNombre.Text = (string)type.GetProperty("nombre").GetValue(partido);


                //id_partido = (int)type.GetProperty("id_partido").GetValue(partido);
                id_fecha = (int)type.GetProperty("id_fecha").GetValue(partido);
                txtNombre.Text = (string)type.GetProperty("nombre").GetValue(partido);
                id_equipo_a = (int)type.GetProperty("equipo_a").GetValue(partido);
                id_equipo_b = (int)type.GetProperty("equipo_b").GetValue(partido);
                id_marcador_partido = (int)type.GetProperty("marcador_partido").GetValue(partido);
                id_arbitroprincipal = (int)type.GetProperty("arbitroprincipal").GetValue(partido);
            }
            lbID_Marcador.Text = id_marcador_partido + "";
            resultado = clsFecha.BuscarPorID(id_fecha);
            lst_fecha = resultado.Item1;

            foreach (var fecha in lst_fecha) {
                System.Type type = fecha.GetType();
                txtNombreFecha.Text = (string)type.GetProperty("nombre").GetValue(fecha);
            }
            
            resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            int index = 0;
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                string nombre = (string)type.GetProperty("nombre").GetValue(equipo);
                Image escudo = (Image)type.GetProperty("escudo").GetValue(equipo);

                cmbEquipo_A.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
                cmbEquipo_B.Items.Add(new ClsEquipo(id_equipo, nombre, escudo));
                if (id_equipo_a == id_equipo) {
                    cmbEquipo_A.SelectedIndex = index;
                }
                if (id_equipo_b == id_equipo) {
                    cmbEquipo_B.SelectedIndex = index;
                }
                index++;
            }

            resultado = clsArbitro.listar();
            lst_arbitro = resultado.Item1;
            index = 0;
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
                if (id_arbitroprincipal == id_persona) {
                    cmbArbitro.SelectedIndex = index;
                }
                index++;
            }

            resultado = clsMarcador.BuscarPorID(id_marcador_partido);
            lst_marcador = resultado.Item1;
            foreach (var marcador in lst_marcador) {
                System.Type type = marcador.GetType();

                txtGoles_A.Text = ((ushort)type.GetProperty("goleaequipoa").GetValue(marcador)).ToString();
                txtGoles_B.Text = ((ushort)type.GetProperty("golesequipob").GetValue(marcador)).ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsMarcador.Id_marcador = Convert.ToInt32(id_marcador_partido);
                clsMarcador.Goleaequipoa = Convert.ToUInt16(txtGoles_A.Text);
                clsMarcador.Golesequipob = Convert.ToUInt16(txtGoles_B.Text);
                msj = clsMarcador.modificar();

                clsPartido.Id_partido = Convert.ToInt32(idPartido);
                clsPartido.Id_fecha = Convert.ToInt32(id_fecha);
                clsPartido.Nombre = txtNombre.Text.ToString();
                clsPartido.id_equipo_a = id_equipo_a;
                clsPartido.id_equipo_b = id_equipo_b;
                clsPartido.id_marcador_partido = id_marcador_partido;
                clsPartido.id_arbitroprincipal = id_arbitroprincipal;
                msj = clsPartido.modificar();


                

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

        protected int id_equipo_a;
        protected int id_equipo_b;
        protected int id_marcador_partido;
        protected int id_arbitroprincipal;

        private void cmbEquipo_A_SelectedIndexChanged(object sender, EventArgs e) {
            ClsEquipo cls = (ClsEquipo)cmbEquipo_A.SelectedItem;
            id_equipo_a = cls.Id_equipo;
            Cargar_Equipo_A();
        }

        private void cmbEquipo_B_SelectedIndexChanged(object sender, EventArgs e) {
            ClsEquipo cls = (ClsEquipo)cmbEquipo_B.SelectedItem;
            id_equipo_b = cls.Id_equipo;
            Cargar_Equipo_B();
        }

        private void cmbArbitro_SelectedIndexChanged(object sender, EventArgs e) {
            ClsArbitro cls = (ClsArbitro)cmbArbitro.SelectedItem;
            id_arbitroprincipal = cls.Id_persona;
        }

        public void Cargar_Equipo_A() {

            var resultado = clsEquipo.BuscarPorID(id_equipo_a);
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;

            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                //this.id_equipo_a = (int)type.GetProperty("id_equipo").GetValue(equipo);
                lbNombre_Equipo_A.Text = (string)type.GetProperty("nombre").GetValue(equipo);
                pbEscudo_Equipo_A.Image = (Image)type.GetProperty("escudo").GetValue(equipo);

            }
        }

        public void Cargar_Equipo_B() {
            var resultado = clsEquipo.BuscarPorID(id_equipo_b);
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;

            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                //this.marcador_partido = (int)type.GetProperty("id_equipo").GetValue(equipo);
                lbNombre_Equipo_B.Text = (string)type.GetProperty("nombre").GetValue(equipo);
                pbEscudo_Equipo_B.Image = (Image)type.GetProperty("escudo").GetValue(equipo);
            }
        }
        

        ClsEquipo clsEquipo = new ClsEquipo();
        List<Object> lst_equipo;
        ClsMarcador clsMarcador = new ClsMarcador();
        List<Object> lst_marcador;
        ClsArbitro clsArbitro = new ClsArbitro();
        List<Object> lst_arbitro;
        SqlDataAdapter registros;
        
    }
}
