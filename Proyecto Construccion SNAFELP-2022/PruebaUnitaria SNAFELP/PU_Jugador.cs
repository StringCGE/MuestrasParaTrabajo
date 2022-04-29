using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaAccesoaDatos;
using CapaLogicadeNegocio;
using CapaPresentacion;
using System.Collections.Generic;

namespace PruebaUnitaria_SNAFELP {
    [TestClass]
    public class PU_Jugador {
        /// <summary>
        /// Se registra un jugador con los datos correctos desde la capa Logica de negocio
        /// </summary>
        [TestMethod]
        public void CP_ClsJugador_Rec_000_Caso_000_Correcto() {
            ClsJugador clsJugador = new ClsJugador();
            clsJugador.Nombres = "adc";
            clsJugador.Apellidos = "adc";
            clsJugador.Cedula = "0912345678";
            clsJugador.Fechanacimiento = DateTime.Now;
            clsJugador.Telefono = "042123456";
            clsJugador.Nacionalidad = "Ecuatoriana";
            clsJugador.Numero = 10;
            string valor = clsJugador.registrar();
            Assert.AreEqual("Insertado correctamente", valor);
        }
        /// <summary>
        /// Se registra un jugador con los datos incorrectos desde la capa Logica de negocio
        /// </summary>
        [TestMethod]
        public void CP_ClsJugador_Rec_000_Caso_000_Error() {
            ClsJugador clsJugador = new ClsJugador();
            clsJugador.Nombres = "adc";
            clsJugador.Apellidos = "adc";
            clsJugador.Cedula = "0912";
            clsJugador.Fechanacimiento = DateTime.Now;
            clsJugador.Telefono = "adc";
            clsJugador.Nacionalidad = "Ecuatoriana";
            clsJugador.Numero = 1000;
            string valor = clsJugador.registrar();
            Assert.AreEqual("Error al insertar los datos", valor);
        }
        /// <summary>
        /// Se registra un jugador con los datos correctos desde la capa Acceso a Datos
        /// </summary>
        [TestMethod]
        public void CAD_ClsManejador_Jugador_Rec_000_Caso_000_Correcto() {
            ClsManejador clsManejador = new ClsManejador();
            ClsParametros clsParametros = new ClsParametros();
            clsParametros.Nombres = "adc";
            clsParametros.Apellidos = "adc";
            clsParametros.Cedula = "0912345678";
            clsParametros.Fechanacimiento = DateTime.Now;
            clsParametros.Telefono = "adc";
            clsParametros.Nacionalidad = "Ecuatoriana";
            clsParametros.Numero = 10;
            
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(clsParametros);
            
            string valor = clsManejador.db_insertar_sobre_jugador(lst);
            Assert.AreEqual("Ejecucion correcta", valor);
        }
        /// <summary>
        /// /// Se registra un jugador con los datos incorrectos desde la capa Acceso a Datos
        /// Aqui queriendo probar que pasa con una excepcion
        /// </summary>
        [TestMethod]
        public void CAD_ClsManejador_Jugador_Rec_000_Caso_000_Error() {
            ClsManejador clsManejador = new ClsManejador();
            ClsParametros clsParametros = new ClsParametros();
            clsParametros.Nombres = "adc";
            clsParametros.Apellidos = "adc";
            clsParametros.Cedula = "0912345678";
            clsParametros.Fechanacimiento = DateTime.Now;
            clsParametros.Telefono = "adc";
            clsParametros.Nacionalidad = "Ecuatoriana";
            clsParametros.Numero = 10;

            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(clsParametros);

            string valor = clsManejador.db_insertar_sobre_jugador(lst);
            Assert.AreEqual("Ejecucion incorrecta", valor);
        }
    }
}



