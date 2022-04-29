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
    public partial class ucAdministradorModificar: UC_Pantalla {
        ClsAdministrador clsAdministrador = new ClsAdministrador();
        //se crea objeto lista de administrador
        List<Object> lst_administrador;
        public ucAdministradorModificar(List<Object> lst_administrador) {
            InitializeComponent();
            /*
             //se pasan los datos de la lista administrador a esta lista
            this.lst_administrador = lst_administrador;
            
            foreach (var administrador in lst_administrador) {
                System.Type type = administrador.GetType();

                txtId_persona.Text = ((int)type.GetProperty("id_persona").GetValue(administrador)).ToString();
                txtNombre_persona.Text = (string)type.GetProperty("nombre_persona").GetValue(administrador);
                txtApellido.Text = (string)type.GetProperty("apellido").GetValue(administrador);
                txtCedula.Text = (string)type.GetProperty("cedula").GetValue(administrador);
                txtUsuario.Text = (string)type.GetProperty("usuario").GetValue(administrador);
                txtPsw.Text = (string)type.GetProperty("psw").GetValue(administrador);

            }
            */
            MessageBox.Show("No soportado por cambios");
        }
        //Funcion modificar para suscribir los datos modificados
        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            String msj = "";
            try {
                clsAdministrador.Id_persona = Convert.ToInt32(txtId_persona.Text);
                clsAdministrador.Nombre_persona = txtNombre_persona.Text.ToString();
                clsAdministrador.Apellido = txtApellido.Text.ToString();
                clsAdministrador.Cedula = txtCedula.Text.ToString();
                clsAdministrador.Usuario = txtUsuario.Text.ToString();
                clsAdministrador.Psw = txtPsw.Text.ToString();


                msj = clsAdministrador.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            */
            MessageBox.Show("No soportado por cambios");
        }


        
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}