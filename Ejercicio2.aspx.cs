using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;

namespace TP4_GRUPO_17
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        //private const string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;";
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        { 
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSql, conexion);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TablaProductos");
           switch(ddlProducto.SelectedValue)
            {
                case "==":
                    for (int i = 0; i < dataSet.Tables["TablaProductos"].Rows.Count; i++)
                    {
                        if (!(Convert.ToInt32(dataSet.Tables["TablaProductos"].Rows[i]["IdProducto"]) == Convert.ToInt32(txtProducto.Text)))
                        {
                            dataSet.Tables["TablaProductos"].Rows[i].Delete();
                        }
                    }

                    gvProductos.DataSource = dataSet;
                    gvProductos.DataBind();
                    break;
                case ">":
                    for (int i = 0; i < dataSet.Tables["TablaProductos"].Rows.Count; i++)
                    {
                        if (!(Convert.ToInt32(dataSet.Tables["TablaProductos"].Rows[i]["IdProducto"]) > Convert.ToInt32(txtProducto.Text)))
                        {
                            dataSet.Tables["TablaProductos"].Rows[i].Delete();
                        }
                    }

                    gvProductos.DataSource = dataSet;
                    gvProductos.DataBind();
                    break;
                case "<":
                    for (int i = 0; i < dataSet.Tables["TablaProductos"].Rows.Count; i++)
                    {
                        if (!(Convert.ToInt32(dataSet.Tables["TablaProductos"].Rows[i]["IdProducto"]) < Convert.ToInt32(txtProducto.Text)))
                        {
                            dataSet.Tables["TablaProductos"].Rows[i].Delete();
                        }
                    }

                    gvProductos.DataSource = dataSet;
                    gvProductos.DataBind();
                    break;
            }
            conexion.Close();
        }
    }
}