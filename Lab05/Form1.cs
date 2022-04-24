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

namespace Lab05
{
    public partial class ManPersonas : Form
    {
        SqlConnection con;

        public ManPersonas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
#pragma warning disable CS1009 // Secuencia de escape no reconocida
            String str = "Server=DESKTOP-I9SU5QR\\LOCAL;Integrated Security=true;Database=School;";
#pragma warning restore CS1009 // Secuencia de escape no reconocida
            con = new SqlConnection(str);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sql = "SELECT * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            con.Close();        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtCodigo.Text == null)
            {
                String sp = "BuscarPersonaNombre";
                SqlCommand cmd = new SqlCommand(sp, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", txtNombre.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvListado.DataSource = dt;
                dgvListado.Refresh();

                con.Close();
            }
            else
            {
                String sp = "BuscarPersonaCodigo";
                SqlCommand cmd = new SqlCommand(sp, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PersonID", txtCodigo.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvListado.DataSource = dt;
                dgvListado.Refresh();

                con.Close();
            }
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtNombre.Text);
            cmd.Parameters.AddWithValue("@LastName", txtApellido.Text);
            cmd.Parameters.AddWithValue("@HireDate", dtContrato.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", dtInscripcion.Text);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el código: " + codigo);
            con.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtNombre.Text);
            cmd.Parameters.AddWithValue("@LastName", txtApellido.Text);
            cmd.Parameters.AddWithValue("@HireDate", dtContrato.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", dtInscripcion.Text);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtCodigo.Text);

            int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Se ha eliminado el registro correctamente");
            }
            con.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtApellido.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                dtContrato.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                dtInscripcion.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
