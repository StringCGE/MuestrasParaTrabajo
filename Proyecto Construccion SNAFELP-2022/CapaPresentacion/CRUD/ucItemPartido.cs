using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaLogicadeNegocio;

namespace CapaPresentacion.CRUD {
    public partial class ucItemPartido : UserControl {
        ClsPartido clsPartido = new ClsPartido();
        List<Object> lst_partido;
        ClsEquipo clsEquipo = new ClsEquipo();
        List<Object> lst_equipo;
        ClsMarcador clsMarcador = new ClsMarcador();
        List<Object> lst_marcador;
        ClsArbitro clsArbitro = new ClsArbitro();
        List<Object> lst_arbitro;
        SqlDataAdapter registros;

        int id_partido;
        int id_fecha;
        string nombre;
        int equipo_a;
        int equipo_b;
        int marcador_partido;
        int arbitroprincipal;

        public ucItemPartido(int id_partido) {
            InitializeComponent();
            this.id_partido = id_partido;
            lbIdPartido.Text = id_partido +"";
            var resultado = clsPartido.BuscarPorID_Todo(id_partido);
            lst_partido = resultado.Item1;
            registros = resultado.Item2;

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var partido in lst_partido) {
                System.Type type = partido.GetType();

                //this.id_partido = (int)type.GetProperty("id_partido").GetValue(partido);
                this.id_fecha = (int)type.GetProperty("id_fecha").GetValue(partido);
                this.nombre = (string)type.GetProperty("nombre").GetValue(partido);
                this.equipo_a = (int)type.GetProperty("equipo_a").GetValue(partido);
                this.equipo_b = (int)type.GetProperty("equipo_b").GetValue(partido);
                this.marcador_partido = (int)type.GetProperty("marcador_partido").GetValue(partido);
                this.arbitroprincipal = (int)type.GetProperty("arbitroprincipal").GetValue(partido);
            }

            resultado = clsEquipo.BuscarPorID(equipo_a);
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;

            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                //this.id_equipo_a = (int)type.GetProperty("id_equipo").GetValue(equipo);
                lbNombre_Equipo_A.Text = (string)type.GetProperty("nombre").GetValue(equipo);
                pbEscudo_Equipo_A.Image = (Image)type.GetProperty("escudo").GetValue(equipo);
                
            }

            resultado = clsEquipo.BuscarPorID(equipo_b);
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;

            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                //this.marcador_partido = (int)type.GetProperty("id_equipo").GetValue(equipo);
                lbNombre_Equipo_B.Text = (string)type.GetProperty("nombre").GetValue(equipo);
                pbEscudo_Equipo_B.Image = (Image)type.GetProperty("escudo").GetValue(equipo);

            }

            resultado = clsMarcador.BuscarPorID(marcador_partido);
            lst_marcador = resultado.Item1;
            //registros = resultado.Item2;

            foreach (var marcador in lst_marcador) {
                System.Type type = marcador.GetType();
                int id_marcador = (int)type.GetProperty("id_marcador").GetValue(marcador);
                lbMarcador_Equipo_A.Text = ((ushort)type.GetProperty("goleaequipoa").GetValue(marcador)).ToString();
                lbMarcador_Equipo_B.Text = ((ushort)type.GetProperty("golesequipob").GetValue(marcador)).ToString();
            }

            resultado = clsArbitro.BuscarPorID(arbitroprincipal);
            lst_arbitro = resultado.Item1;

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                psw = (string)type.GetProperty("psw").GetValue(arbitro);
                puesto = (string)type.GetProperty("puesto").GetValue(arbitro);
                id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                nombres = (string)type.GetProperty("nombres").GetValue(arbitro);
                apellidos = (string)type.GetProperty("apellidos").GetValue(arbitro);
                cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(arbitro);
                telefono = (string)type.GetProperty("telefono").GetValue(arbitro);
                nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(arbitro);
                foto = (Image)type.GetProperty("foto").GetValue(arbitro);
                licencia = (string)type.GetProperty("licencia").GetValue(arbitro);
            }

            lbArbitroPrincipal.Text = nombres + " " + apellidos;
        }

        //equipo_a
        protected int id_equipo_a;
        protected string nombre_equipo_a;
        protected Image escudo_equipo_a;

        //equipo_b
        protected int id_equipo_b;
        protected string nombre_equipo_b;
        protected Image escudo_equipo_b;

        //marcador_partido
        protected int id_marcador;
        protected ushort goleaequipoa;
        protected ushort golesequipob;

        //arbitroprincipal
        protected int id_persona;
        protected string nombres;
        protected string apellidos;
        protected string cedula;
        protected DateTime fechanacimiento;
        protected string telefono;
        protected string nacionalidad;
        protected Image foto;
        protected string usuario;
        protected string psw;
        protected string puesto;
        protected string licencia;

    }
}
