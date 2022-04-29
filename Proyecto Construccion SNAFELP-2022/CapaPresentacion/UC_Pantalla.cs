using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion {
    public partial class UC_Pantalla: UserControl {

        public Inicio Inicio { get => inicio; set => inicio = value; }
        private Inicio inicio;

        public UC_Pantalla() {
            InitializeComponent();
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
        }
    }
}
