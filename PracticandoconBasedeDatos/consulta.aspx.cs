using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // Importar
using System.Data.SqlClient;

namespace PracticandoconBasedeDatos
{
    public partial class consulta2 : System.Web.UI.Page
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
                  " where nombre='" + this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                this.Label2.Text = "Clave:" + registro["clave"] + "<br>" +
                                   "Mail:" + registro["mail"];
            else
                this.Label2.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }
    }
}