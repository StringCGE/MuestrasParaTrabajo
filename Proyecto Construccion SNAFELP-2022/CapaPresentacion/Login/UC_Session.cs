using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicadeNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion.Login {
    public partial class UC_Session : UserControl {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto de lista arbitro
        List<Object> lst_arbitro;
        SqlDataAdapter registros;

        public UC_Session() {
            InitializeComponent();
        }

        public void Asignar(int id_persona) {
            var resultado = clsArbitro.BuscarPorID(id_persona);
            lst_arbitro = resultado.Item1;
            registros = resultado.Item2;
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();
                
                lbUsuario.Text = (string)type.GetProperty("usuario").GetValue(arbitro);
                lbPuesto.Text = (string)type.GetProperty("puesto").GetValue(arbitro);
                pbUsuario.Image = (Image)type.GetProperty("foto").GetValue(arbitro);
            }
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            if (ParentForm is Inicio) {
                ((Inicio)ParentForm).Salir();
            }
        }
    }
}
