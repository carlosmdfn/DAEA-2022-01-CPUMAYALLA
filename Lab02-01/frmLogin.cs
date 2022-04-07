using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn.Open();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String usuario = txtUsuario.Text;
                String pass = txtPassword.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LogeoUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@usuario";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = usuario;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@password";
                param2.SqlDbType = SqlDbType.NVarChar;
                param2.Value = pass;

                cmd.Parameters.Add(param);
                cmd.Parameters.Add(param2);

                SqlDataReader reader = cmd.ExecuteReader();
             
                if (reader.Read())
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
