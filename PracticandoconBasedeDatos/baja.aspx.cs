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
    public partial class baja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from usuarios where nombre='" + this.txtNombre.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label2.Text = "Se borró el usuario";
            else
                this.Label2.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }
    }
}