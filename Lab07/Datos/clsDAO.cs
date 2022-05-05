using System.Data.SqlClient;

namespace Datos
{
    public class clsDAO
    {
        public SqlConnection con;

        public clsDAO()
        {
            string str = "Server=DESKTOP-I9SU5QR\\LOCAL;Integrated Security=true;Database=School;";
            con = new SqlConnection(str);
        }
    }
}
