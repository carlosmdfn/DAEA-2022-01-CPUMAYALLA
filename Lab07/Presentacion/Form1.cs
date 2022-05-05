using System.Windows.Forms;
using System.Data;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            string data = txtNombre.Text;
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetOne(data);
            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }
    }
}
