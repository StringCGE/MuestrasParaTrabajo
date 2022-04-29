using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaAccesoaDatos
{
    public class Validaciones
    {
        //Validaciones a usar en los formularios, por usar
        public bool EsEntero(string valor)
        {
            bool bandera = true;
            double x = 0;
            try
            {
                x = Convert.ToInt32(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error, se esperaba número Entero");
            }
            return bandera;
        }
        public bool EsReal(string valor)
        {
            bool bandera = true;
            double x = 0.0;
            try
            {
                x = Convert.ToDouble(valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error, se esperaba número decimal");
            }
            return bandera;
        }
        internal bool LeerCorreo(string msj)
        {
            bool bandera = false;
            string x = "";
            try
            {
                x = Convert.ToString(msj);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("error se esperaba un @ o un punto");

            }

            return bandera;
        }
        public bool ValidarCampoEntero(TextBox CajadeTexto)
        {
            try
            {
                int d = Convert.ToInt32(CajadeTexto.Text);
                return true;
            }
            catch (Exception ex)
            {
                CajadeTexto.Text = "0";
                CajadeTexto.Select(0, CajadeTexto.Text.Length);
                return false;
            }
        }
        public bool ValidarCampoDecimal(TextBox CajadeTexto)
        {
            try
            {
                double d = Convert.ToDouble(CajadeTexto.Text);
                return true;
            }
            catch (Exception ex)
            {
                CajadeTexto.Text = "0";
                CajadeTexto.Select(0, CajadeTexto.Text.Length);
                return false;
            }
        }

        public bool VerificarEmail(String email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool esMayorFecha(DateTime d1, DateTime d2)
        {
            bool retorno = false;

            if (d1.Year < d2.Year)
            {
                retorno = true;
            }
            else if (d1.Year == d2.Year)
            {
                if (d1.Month < d2.Month)
                {
                    retorno = true;
                }
                else if (d1.Month == d2.Month)
                {
                    if (d1.Day < d2.Day)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public bool MayorEdad(DateTime f)
        {

            DateTime FechaActual = DateTime.Today;

            int edad = FechaActual.Year - f.Year;

            if (FechaActual < f.AddYears(edad)) edad--;
            {
                if (edad > 18)
                {
                    MessageBox.Show("El jugador tiene " + edad + " años se puede Inscribir");
                }
                else
                {
                    MessageBox.Show("El jugador tiene " + edad + " años no se puede Inscribir");
                }

                return true;
            }


        }
    }
}
