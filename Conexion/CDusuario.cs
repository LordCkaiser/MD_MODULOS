using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MD_MODULOS.Modulos;
using System.Xml;
using System.Xml.Linq;

namespace MD_MODULOS.Conexion
{
    public class CDusuario
    {
        // LOGUEO POR USUARIO //
        public static int loguear(string usuario, string clave)
        {
            int idusuario = 0;
            using (SqlConnection cn = new SqlConnection(ConexionMaestra.con))
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_LoginUsuario", cn);

                    cmd.Parameters.AddWithValue("loguin", usuario);
                    cmd.Parameters.AddWithValue("clave", clave);
                    cmd.Parameters.Add("idusuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    idusuario = Convert.ToInt32(cmd.Parameters["idusuario"].Value);
                }
                catch (Exception e)
                {
                    idusuario = 0;
                }
            {

            }
            return idusuario;
        }
    

        // CREACION DE MENU Y SUBMENU DINAMICO DEL MD_MASTER //
        public static List<Menu> Obtener_Permisos (int p_idusuario)
        {
            List<Menu> Permisos = new List<Menu>();
            using (SqlConnection cn = new SqlConnection  (ConexionMaestra.con))
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_ObtenerPermisos", cn);
                    cmd.Parameters.AddWithValue("idussuario", p_idusuario);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                 
                    XmlReader leerXML = cmd.ExecuteXmlReader();

                    while (leerXML.Read()) {
                        XDocument doc = XDocument.Load(leerXML);

                        if (doc.Element("PERMISOS") != null) {

                            Permisos = doc.Element("PERMISOS").Element("Detalle_Menu") == null ? new List<Menu>() :
                                (from menu in doc.Element("PERMISOS").Element("Detalle_Menu").Elements("MENU")
                                 select new Menu()
                                 {
                                     nombre = menu.Element("nombre").Value,
                                     icono = menu.Element("icono").Value,
                                     ListaSubmenu = menu.Element("Detalle_Submenu") == null ? new List<Submenu>() :
                                     (from Submenu in menu.Element("Detalle_Submenu").Elements("Submenu")
                                      select new Submenu()
                                      {
                                          nombre = Submenu.Element("nombre").Value,
                                          nombre_formulario = Submenu.Element("nombre_formulario").Value
                                      }).ToList()

                                 }).ToList();

                                 }
                                  }

                    } 

                catch (Exception e)
                {
                    Permisos = new List<Menu>();
                }
            {

            }
            return Permisos;



        }
    }
}
