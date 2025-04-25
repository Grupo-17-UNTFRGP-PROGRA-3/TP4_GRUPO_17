using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_17
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=False";
        private string consultaSQL = "SELECT * FROM Temas";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);

                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                ddlTemas.DataSource = sqlDataReader;
                ddlTemas.DataTextField = "Tema";
                ddlTemas.DataValueField = "IdTema";
                ddlTemas.DataBind();

                connection.Close();
            }
        }
    }
}