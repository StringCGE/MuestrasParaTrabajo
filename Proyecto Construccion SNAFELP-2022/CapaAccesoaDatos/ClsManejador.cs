using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
//using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;

namespace CapaAccesoaDatos{
    /// <summary>
    /// Aqui esta la manipulacion de la base de datos pero aun esta mezclado
    /// </summary>
    public class ClsManejador{
        SqlServer db;

        public ClsManejador() {
            db = new SqlServer();
        }
        
        //Abrir conexion a BD
        SqlConnection abrir_conexion() {
            db.Abrir_conexion();
            return db.Conexion;
        }

        //Cerrar conexion a BD
        void cerrar_conexion() {
            db.Cerrar_conexion();
        }
        public int DB_Suma(int a, int b) {
            int retorna= 0;
            try {
                SqlConnection conexion = abrir_conexion();

                String cadena = "EXECUTE probando @valorA, @valorB";   

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@valorA", 50);
                comando.Parameters.AddWithValue("@valorB", 20);
                retorna = (int)comando.ExecuteScalar();
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return retorna;
        }
        /*----------------------------------------------*//*----------------------------------------------*/
        /*--------------------------------------------INSERTAR--------------------------------------------*/
        #region "insertar"
        //Procedure or function 'SP_Jugador_Insertar' expects parameter '@numero', which was not supplied. realmemnte falta un párametro
        public String persona_insertar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_persona_Insertar @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @Foto";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombres", Nombres);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@cedula", Cedula);
                    comando.Parameters.AddWithValue("@fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String administrador_insertar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Usuario, string Psw, string Puesto) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_administrador_Insertar @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @Foto, @usuario, @psw, @puesto";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombres", Nombres);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@cedula", Cedula);
                    comando.Parameters.AddWithValue("@fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@usuario", Usuario);
                    comando.Parameters.AddWithValue("@psw", Psw);
                    comando.Parameters.AddWithValue("@puesto", Puesto);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String jugador_insertar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, int Id_equipo, int Numero) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_jugador_Insertar @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @Foto, @id_equipo, @numero";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombres", Nombres);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@cedula", Cedula);
                    comando.Parameters.AddWithValue("@fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@id_equipo", Id_equipo);
                    comando.Parameters.AddWithValue("@numero", Numero);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String arbitro_insertar(string Usuario, string Psw, string Puesto, int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Licencia) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_arbitro_Insertar @usuario, @psw, @puesto, @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @Foto, @licencia";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@usuario", Usuario);
                    comando.Parameters.AddWithValue("@psw", Psw);
                    comando.Parameters.AddWithValue("@puesto", Puesto);
                    comando.Parameters.AddWithValue("@nombres", Nombres);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@cedula", Cedula);
                    comando.Parameters.AddWithValue("@fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@telefono", Telefono);
                    comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@licencia", Licencia);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String campeonato_insertar(int Id_campeonato, string Nombre_campeonado) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_campeonato_Insertar @nombre_campeonado";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre_campeonado", Nombre_campeonado);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String acta_insertar(int Id_acta, string Nombre, int Fecha, int Partido, int Marcador_acta, int Equipoa_acta, int Equipob_acta) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_acta_Insertar @nombre, @fecha, @partido, @marcador_acta, @equipoa_acta, @equipob_acta";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@fecha", Fecha);
                    comando.Parameters.AddWithValue("@partido", Partido);
                    comando.Parameters.AddWithValue("@marcador_acta", Marcador_acta);
                    comando.Parameters.AddWithValue("@equipoa_acta", Equipoa_acta);
                    comando.Parameters.AddWithValue("@equipob_acta", Equipob_acta);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String fecha_insertar(int Id_fecha, int Id_campeonato, string Nombre, int Partidos, int Numero_fecha, DateTime Fechainicio, DateTime Fechafin) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_fecha_Insertar @id_campeonato, @nombre, @numero_fecha, @fechainicio, @fechafin";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_campeonato", Id_campeonato);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@numero_fecha", Numero_fecha);
                    comando.Parameters.AddWithValue("@fechainicio", Fechainicio);
                    comando.Parameters.AddWithValue("@fechafin", Fechafin);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String equipo_insertar(int Id_equipo, string Nombre, Image Escudo) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_equipo_Insertar @nombre, @escudo";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@escudo", Image_To_Byte(Escudo));

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String marcador_insertar(int Id_marcador, ushort Goleaequipoa, ushort Golesequipob) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_marcador_Insertar @goleaequipoa, @golesequipob";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@goleaequipoa", Goleaequipoa);
                    comando.Parameters.AddWithValue("@golesequipob", Golesequipob);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String partido_insertar(int Id_partido, int Id_fecha, string Nombre, int Equipo_a, int Equipo_b, int Marcador_partido, int Arbitroprincipal) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_partido_Insertar @id_fecha, @nombre, @equipo_A, @equipo_B, @marcador_partido, @arbitroprincipal";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_fecha", Id_fecha);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@equipo_A", Equipo_a);
                    comando.Parameters.AddWithValue("@equipo_B", Equipo_b);
                    comando.Parameters.AddWithValue("@marcador_partido", Marcador_partido);
                    comando.Parameters.AddWithValue("@arbitroprincipal", Arbitroprincipal);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        #endregion
        /*----------------------------------------------*//*----------------------------------------------*/
        /*-------------------------------------------LISTARTODO-------------------------------------------*/
        #region "ListarTodo"
        public Tuple<List<Object>, SqlDataAdapter> persona_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_persona_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> administrador_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_administrador_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> jugador_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_jugador_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        id_equipo = Convert.ToInt32(dr["id_equipo"]),
                        numero = Convert.ToInt32(dr["numero"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> arbitro_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_arbitro_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString(),
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        licencia = dr["licencia"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> campeonato_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_campeonato_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_campeonato = Convert.ToInt32(dr["id_campeonato"]),
                        nombre_campeonado = dr["nombre_campeonado"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> acta_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_acta_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_acta = Convert.ToInt32(dr["id_acta"]),
                        nombre = dr["nombre"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> fecha_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_fecha_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        nombre = dr["nombre"].ToString(),
                        numero_fecha = Convert.ToInt32(dr["numero_fecha"]),
                        fechainicio = DateTime.Parse(dr["fechainicio"].ToString()),
                        fechafin = DateTime.Parse(dr["fechafin"].ToString())
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }

        public Tuple<List<Object>, SqlDataAdapter> equipo_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_equipo_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_equipo = Convert.ToInt32(dr["id_equipo"]),
                        nombre = dr["nombre"].ToString(),
                        escudo = Byte_To_Image((byte[])dr["escudo"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }

        public Tuple<List<Object>, SqlDataAdapter> marcador_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_marcador_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_marcador = Convert.ToInt32(dr["id_marcador"]),
                        goleaequipoa = Convert.ToUInt16(dr["goleaequipoa"]),
                        golesequipob = Convert.ToUInt16(dr["golesequipob"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> partido_ListarTodo() {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_partido_ListarTodo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_partido = Convert.ToInt32(dr["id_partido"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        #endregion
        /*----------------------------------------------*//*----------------------------------------------*/
        /*------------------------------------------BUSCARPOR ID------------------------------------------*/
        #region "BuscarPorID"
        public Tuple<List<Object>, SqlDataAdapter> persona_BuscarPorID(int Id_persona) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_persona_BuscarPorID @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> administrador_BuscarPorID(int Id_persona) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_administrador_BuscarPorID @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> administrador_psw(int Id_persona, string psw) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_administrador_BuscarPorID @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> jugador_BuscarPorID_Equipo(int Id_equipo) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_jugador_BuscarPorID_Equipo @Id_equipo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        numero = Convert.ToInt32(dr["numero"]),
                        id_equipo = Convert.ToInt32(dr["id_equipo"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> jugador_BuscarPorID(int Id_persona) 
            {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_jugador_BuscarPorID @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        numero = Convert.ToInt32(dr["numero"]),
                        id_equipo = Convert.ToInt32(dr["id_equipo"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> arbitro_BuscarPorID(int Id_persona) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_arbitro_BuscarPorID @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString(),
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        licencia = dr["licencia"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> arbitro_psw_ByUser(string usuario, string psw) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_Arbitro_Psw_By_User @usuario, @psw";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@psw", psw);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString(),
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        licencia = dr["licencia"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> arbitro_BuscarPorUsuario(string usuario) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_Arbitro_BuscarPorUsuario @usuario";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        puesto = dr["puesto"].ToString(),
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        foto = Byte_To_Image((byte[])dr["foto"]),
                        licencia = dr["licencia"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public bool arbitro_psw(int Id_persona, string psw) {
            //lreturn.Clear();
            bool retorna = false;
            int aux = -1;
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_Arbitro_Psw @Id_persona, @psw";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.Parameters.AddWithValue("@psw", psw);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    aux = Convert.ToInt32(dr["RET"]);
                }
                retorna = (aux == 1);
            } catch (Exception ex) {
                retorna = false;
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return retorna;
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> campeonato_BuscarPorID(int Id_campeonato) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_campeonato_BuscarPorID @Id_campeonato";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_campeonato", Id_campeonato);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_campeonato = Convert.ToInt32(dr["id_campeonato"]),
                        nombre_campeonado = dr["nombre_campeonado"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> acta_BuscarPorID(int Id_acta) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_acta_BuscarPorID @Id_acta";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_acta", Id_acta);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_acta = Convert.ToInt32(dr["id_acta"]),
                        nombre = dr["nombre"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> fecha_BuscarPorID_Campeonato(int Id_fecha) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_fecha_BuscarPorID_Campeonato @Id_fecha";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        nombre = dr["nombre"].ToString(),
                        numero_fecha = Convert.ToInt32(dr["numero_fecha"]),
                        fechainicio = DateTime.Parse(dr["fechainicio"].ToString()),
                        fechafin = DateTime.Parse(dr["fechafin"].ToString())
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }

        public Tuple<List<Object>, SqlDataAdapter> fecha_BuscarPorID(int Id_fecha) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_fecha_BuscarPorID @Id_fecha";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        id_campeonato = Convert.ToInt32(dr["id_campeonato"]),
                        nombre = dr["nombre"].ToString(),
                        numero_fecha = Convert.ToInt32(dr["numero_fecha"]),
                        fechainicio = DateTime.Parse(dr["fechainicio"].ToString()),
                        fechafin = DateTime.Parse(dr["fechafin"].ToString())
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> equipo_BuscarPorID(int Id_equipo) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_equipo_BuscarPorID @Id_equipo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_equipo = Convert.ToInt32(dr["id_equipo"]),
                        nombre = dr["nombre"].ToString(),
                        escudo = Byte_To_Image((byte[])dr["escudo"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> marcador_BuscarPorID(int Id_marcador) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_marcador_BuscarPorID @Id_marcador";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_marcador", Id_marcador);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_marcador = Convert.ToInt32(dr["id_marcador"]),
                        goleaequipoa = Convert.ToUInt16(dr["goleaequipoa"]),
                        golesequipob = Convert.ToUInt16(dr["golesequipob"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> partido_BuscarPorID_Todo(int Id_partido) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_Partido_BuscarPorID_Todo @Id_partido";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_partido", Id_partido);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_partido = Convert.ToInt32(dr["id_partido"]),
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        nombre = dr["nombre"].ToString(),
                        equipo_a = Convert.ToInt32(dr["equipo_a"]),
                        equipo_b = Convert.ToInt32(dr["equipo_b"]),
                        marcador_partido = Convert.ToInt32(dr["marcador_partido"]),
                        arbitroprincipal = Convert.ToInt32(dr["arbitroprincipal"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> partido_BuscarPorID(int Id_partido) {
            //lreturn.Clear();SP_Partido_BuscarPorID_Todo
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_partido_BuscarPorID @Id_partido";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_partido", Id_partido);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_partido = Convert.ToInt32(dr["id_partido"]),
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        nombre = dr["nombre"].ToString(),
                        equipo_a = Convert.ToInt32(dr["equipo_a"]),
                        equipo_b = Convert.ToInt32(dr["equipo_b"]),
                        marcador_partido = Convert.ToInt32(dr["marcador_partido"]),
                        arbitroprincipal = Convert.ToInt32(dr["arbitroprincipal"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> partido_BuscarPorID_Fecha(int Id_fecha) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = "EXECUTE SP_partido_BuscarPorID_Fecha @Id_fecha";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_partido = Convert.ToInt32(dr["id_partido"]),
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        nombre = dr["nombre"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        #endregion
        /*----------------------------------------------*//*----------------------------------------------*/
                                                          /*-------------------------------------------MODIFICAR--------------------------------------------*/
        #region "Modificar"
        public String persona_modificar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Persona_Modificar @Id_persona, @Nombres, @Apellidos, @Cedula, @Fechanacimiento, @Telefono, @Nacionalidad, @Foto";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                    comando.Parameters.AddWithValue("@Nombres", Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    comando.Parameters.AddWithValue("@Fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@Telefono", Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String administrador_modificar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Usuario, string Psw, string Puesto) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Administrador_Modificar @Id_persona, @Nombres, @Apellidos, @Cedula, @Fechanacimiento, @Telefono, @Nacionalidad, @Foto, @Usuario, @Psw, @Puesto";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                    comando.Parameters.AddWithValue("@Nombres", Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    comando.Parameters.AddWithValue("@Fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@Telefono", Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Psw", Psw);
                    comando.Parameters.AddWithValue("@Puesto", Puesto);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String jugador_modificar(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, int Numero, int Id_equipo) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Jugador_Modificar @Id_persona, @Nombres, @Apellidos, @Cedula, @Fechanacimiento, @Telefono, @Nacionalidad, @Foto, @Numero, @Id_equipo";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                    comando.Parameters.AddWithValue("@Nombres", Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    comando.Parameters.AddWithValue("@Fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@Telefono", Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@Numero", Numero);
                    comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String arbitro_modificar(string Usuario, string Psw, string Puesto, int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad, Image Foto, string Licencia) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Arbitro_Modificar @Usuario, @Psw, @Puesto, @Id_persona, @Nombres, @Apellidos, @Cedula, @Fechanacimiento, @Telefono, @Nacionalidad, @Foto, @Licencia";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Psw", Psw);
                    comando.Parameters.AddWithValue("@Puesto", Puesto);
                    comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                    comando.Parameters.AddWithValue("@Nombres", Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    comando.Parameters.AddWithValue("@Fechanacimiento", Fechanacimiento);
                    comando.Parameters.AddWithValue("@Telefono", Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
                    comando.Parameters.AddWithValue("@Foto", Image_To_Byte(Foto));
                    comando.Parameters.AddWithValue("@Licencia", Licencia);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String campeonato_modificar(int Id_campeonato, string Nombre_campeonado) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Campeonato_Modificar @Id_campeonato, @Nombre_campeonado";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_campeonato", Id_campeonato);
                    comando.Parameters.AddWithValue("@Nombre_campeonado", Nombre_campeonado);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String acta_modificar(int Id_acta, string Nombre, int Fecha, int Partido, int Marcador_acta, int Equipoa_acta, int Equipob_acta) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Acta_Modificar @Id_acta, @Nombre, @Fecha, @Partido, @Marcador_acta, @Equipoa_acta, @Equipob_acta";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_acta", Id_acta);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Fecha", Fecha);
                    comando.Parameters.AddWithValue("@Partido", Partido);
                    comando.Parameters.AddWithValue("@Marcador_acta", Marcador_acta);
                    comando.Parameters.AddWithValue("@Equipoa_acta", Equipoa_acta);
                    comando.Parameters.AddWithValue("@Equipob_acta", Equipob_acta);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String fecha_modificar(int Id_fecha, int Id_campeonato, string Nombre, int Numero_fecha, DateTime Fechainicio, DateTime Fechafin) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Fecha_Modificar @Id_fecha, @Id_campeonato, @Nombre, @Numero_fecha, @Fechainicio, @Fechafin";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                    comando.Parameters.AddWithValue("@Id_campeonato", Id_campeonato);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Numero_fecha", Numero_fecha);
                    comando.Parameters.AddWithValue("@Fechainicio", Fechainicio);
                    comando.Parameters.AddWithValue("@Fechafin", Fechafin);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String equipo_modificar(int Id_equipo, string Nombre, Image Escudo) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Equipo_Modificar @Id_equipo, @Nombre, @Escudo";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Escudo", Image_To_Byte(Escudo));

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String marcador_modificar(int Id_marcador, int Goleaequipoa, int Golesequipob) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Marcador_Modificar @Id_marcador, @Goleaequipoa, @Golesequipob";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_marcador", Id_marcador);
                    comando.Parameters.AddWithValue("@Goleaequipoa", Goleaequipoa);
                    comando.Parameters.AddWithValue("@Golesequipob", Golesequipob);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String partido_modificar(int Id_partido, int Id_fecha, string Nombre, int Equipo_a, int Equipo_b, int Marcador_partido, int Arbitroprincipal) {
            String mensaje = "";
            try {
                if (mensaje == "") {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Partido_Modificar @Id_partido, @Id_fecha, @Nombre, @Equipo_a, @Equipo_b, @Marcador_partido, @Arbitroprincipal";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@Id_partido", Id_partido);
                    comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Equipo_a", Equipo_a);
                    comando.Parameters.AddWithValue("@Equipo_b", Equipo_b);
                    comando.Parameters.AddWithValue("@Marcador_partido", Marcador_partido);
                    comando.Parameters.AddWithValue("@Arbitroprincipal", Arbitroprincipal);

                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        #endregion
        /*----------------------------------------------*//*----------------------------------------------*/
        /*--------------------------------------------ELIMINAR--------------------------------------------*/
        #region "Eliminar"
        public String persona_eliminar(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Persona_EliminacionLogica @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String administrador_eliminar(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Administrador_EliminacionLogica @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String jugador_eliminar(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Jugador_EliminacionLogica @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String arbitro_eliminar(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Arbitro_EliminacionLogica @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String campeonato_eliminar(int Id_campeonato) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Campeonato_EliminacionLogica @Id_campeonato";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_campeonato", Id_campeonato);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String acta_eliminar(int Id_acta) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Acta_EliminacionLogica @Id_acta";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_acta", Id_acta);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String fecha_eliminar(int Id_fecha) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Fecha_EliminacionLogica @Id_fecha";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                mensaje = ex.Message;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String equipo_eliminar(int Id_equipo) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Equipo_EliminacionLogica @Id_equipo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String marcador_eliminar(int Id_marcador) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Marcador_EliminacionLogica @Id_marcador";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_marcador", Id_marcador);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String partido_eliminar(int Id_partido) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "EXECUTE SP_Partido_EliminacionLogica @Id_partido";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_partido", Id_partido);
                comando.ExecuteNonQuery();
                mensaje = "Se elimino exitosamente el registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        #endregion
        /*----------------------------------------------*//*----------------------------------------------*/
        /*----------------------------------------------*//*----------------------------------------------*/



        public static Image Byte_To_Image(byte[] array) {
            MemoryStream ms = new MemoryStream(array);
            return System.Drawing.Image.FromStream(ms);
        }

        public static byte[] Image_To_Byte(Image imagenIn) {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, ImageFormat.Jpeg);

            return ms.ToArray();
        }




    }
}