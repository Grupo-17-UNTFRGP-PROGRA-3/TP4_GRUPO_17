using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services.Description;

namespace TP4_GRUPO_17
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        //private const string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
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

                ddlProvinciasInicio.DataSource = dataSet.Tables["TablaProvincias"];
                ddlProvinciasInicio.DataTextField = "NombreProvincia";
                ddlProvinciasInicio.DataValueField = "IdProvincia";
                ddlProvinciasInicio.DataBind();

                connection.Close();

                ActualizarLocalidadesInicio();
                ActualizarProvinciasDestino();
                ActualizarLocalidadesDestino();
               

            }
        }

        protected void ddlProvinciasInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLocalidadesInicio();
            ActualizarProvinciasDestino();
           

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

            ddlLocalidadesInicio.DataSource = dataSet.Tables["TablaLocalidades"];
            ddlLocalidadesInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadesInicio.DataValueField = "IdLocalidad";
            ddlLocalidadesInicio.DataBind();

            connection.Close();
        }
        private void ActualizarProvinciasDestino()
        {
            ddlProvinciasDestino.Items.Clear();
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consultaSQLProvincias, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TablaProvincias");

            foreach (DataRow row in dataSet.Tables["TablaProvincias"].Rows)
            {
                if (row["IdProvincia"].ToString() != ddlProvinciasInicio.SelectedValue)
                {
                    ddlProvinciasDestino.Items.Add(row["NombreProvincia"].ToString());
                    ddlProvinciasDestino.Items[ddlProvinciasDestino.Items.Count - 1].Value = row["IdProvincia"].ToString();
                }
            }
            ActualizarLocalidadesDestino();
            connection.Close();
        }
        private void ActualizarLocalidadesDestino()
        {
            ddlLocalidadesDestino.Items.Clear();
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();

            SqlCommand command = new SqlCommand(consultaSQLLocalidades, connection);
            command.Parameters.Add("@IdProvincia", SqlDbType.Int);
            command.Parameters["@IdProvincia"].Value = ddlProvinciasDestino.SelectedValue;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TablaLocalidades");

            ddlLocalidadesDestino.DataSource = dataSet.Tables["TablaLocalidades"];
            ddlLocalidadesDestino.DataTextField = "NombreLocalidad";
            ddlLocalidadesDestino.DataValueField = "IdLocalidad";
            ddlLocalidadesDestino.DataBind();

            connection.Close();
        }

        protected void ddlProvinciasDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLocalidadesDestino();
        }
    }
}