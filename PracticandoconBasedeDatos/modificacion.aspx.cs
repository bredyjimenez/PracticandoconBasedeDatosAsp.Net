using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // importar
using System.Data.SqlClient;

namespace PracticandoconBasedeDatos
{
    public partial class modificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre,clave,mail from usuarios " +
                  " where nombre='" + this.txtNombre.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.txtClave.Text = registro["clave"].ToString();
                this.txtMail.Text = registro["mail"].ToString();
            }
            else
                this.Label2.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update usuarios set " +
                     "clave='" + this.txtClave.Text +
                     "',mail='" + this.txtMail.Text +
                     "' where nombre='" + this.txtNombre.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label5.Text = "Datos Modificados";
            else
                this.Label5.Text = "No existe el usuario";
            conexion.Close();
        }
    }
}