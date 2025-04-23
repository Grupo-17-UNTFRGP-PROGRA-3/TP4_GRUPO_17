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
        private const string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private string consultaSQLProvincias = "SELECT * FROM Provincias";
        private string consultaSQLLocalidades = "SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);

                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSQLProvincias, connection);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "TablaProvincias");

                ddlProvinciasInicio.DataTextField = "NombreProvincia";
                ddlProvinciasInicio.DataSource = dataSet.Tables["TablaProvincias"];
                ddlProvinciasInicio.DataValueField = "IdProvincia";
                ddlProvinciasInicio.DataBind();

                connection.Close();

                ActualizarLocalidadesInicio();
            }
        }

        protected void ddlProvinciasInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLocalidadesInicio();
        }

        private void ActualizarLocalidadesInicio()
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();

            SqlCommand command = new SqlCommand(consultaSQLLocalidades, connection);
            command.Parameters.Add("@IdProvincia", SqlDbType.Int);
            command.Parameters["@IdProvincia"].Value = ddlProvinciasInicio.SelectedValue;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TablaLocalidades");

            ddlLocalidadesInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadesInicio.DataSource = dataSet.Tables["TablaLocalidades"];
            ddlLocalidadesInicio.DataValueField = "IdLocalidad";
            ddlLocalidadesInicio.DataBind();

            connection.Close();
        }
    }
}