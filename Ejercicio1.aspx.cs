using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP4_GRUPO_17
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=DESKTOP-7N6K8KD\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private string consultaSQLProvincias = "SELECT * FROM Provincias";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);

                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSQLProvincias, connection);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "TablaProvincias");

                ddlProvincias.DataSource = dataSet.Tables["TablaProvincias"];
                ddlProvincias.DataTextField = "NombreProvincia";
                ddlProvincias.DataValueField = "IdProvincia";
                ddlProvincias.DataBind();

                connection.Close();
            }
        }
    }
}