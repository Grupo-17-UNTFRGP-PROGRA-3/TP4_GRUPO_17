using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string Seleccionado = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedItem.Value.ToString();
            string consultaSQL = "SELECT * FROM Libros WHERE IdTema = ";
            consultaSQL += Seleccionado;

            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                gvListado.DataSource = sqlDataReader;
                gvListado.DataBind();

                connection.Close();
            }
        }
    }
}