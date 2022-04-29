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
    public partial class ucActaReporte: UC_Pantalla {
        public ucActaReporte(DataSet ds) {
            InitializeComponent();
            //crActa rp = new crActa();
            //rp.SetDataSource(ds.Tables[0]);

            //crystalReportViewer1.ReportSource = rp;
            //crystalReportViewer1.Refresh();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}