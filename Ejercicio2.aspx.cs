using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP4_GRUPO_17
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;";
        private string consultaSql = "select IdProducto,NombreProducto,IdCategoría,CantidadPorUnidad,PrecioUnidad from Productos";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                SqlCommand command = new SqlCommand(consultaSql, conexion);
                SqlDataReader reader = command.ExecuteReader();

                gvProductos.DataSource = reader;
                gvProductos.DataBind();

                conexion.Close();
            }
        }
    }
}