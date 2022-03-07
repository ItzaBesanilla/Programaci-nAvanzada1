using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Formulario2.Scripts
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntCapturar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Correo  = txtEmail.Text;
            string Contraseña = txtPassword.Text;

            SqlConnection connection = new SqlConnection("Server=ITZA-PC;Database=Formulario2;Trusted_Connection=True;");
            connection.Open();


            SqlCommand command = new SqlCommand("INSERT INTO Usuarios VALUES(@Usuario, @Correo, @Contraseña)", connection);

            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@Correo", Correo);
            command.Parameters.AddWithValue("@Contraseña", Contraseña);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}