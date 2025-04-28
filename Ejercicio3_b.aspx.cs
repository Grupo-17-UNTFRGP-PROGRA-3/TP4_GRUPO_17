using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string cadenaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PreviousPage == null || PreviousPage.FindControl("ddlTemas") == null)
                {
                    Response.Redirect("Ejercicio3.aspx");
                    return;
                }

                string Seleccionado = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedItem.Value.ToString();
                ViewState["IdTema"] = Seleccionado;
                string consultaSQL = "SELECT * FROM Libros WHERE IdTema = " + Seleccionado;

                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                gvListado.DataSource = sqlDataReader;
                gvListado.DataBind();

                connection.Close();
            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            if (ViewState["IdTema"] == null)
            {
                Response.Redirect("Ejercicio3.aspx");
                return;
            }
            string Seleccionado = ViewState["IdTema"].ToString();
            string consultaSQL = "SELECT * FROM Libros WHERE IdTema = " + Seleccionado;
         

            if (!string.IsNullOrEmpty(txtAutor.Text))
            {
                consultaSQL += " AND Autor LIKE '%" + txtAutor.Text + "%'";
            }

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

