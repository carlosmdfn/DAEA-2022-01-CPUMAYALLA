using System.Data;
using Datos;

namespace Negocio
{
    public class clsNegPerson
    {
        clsDAOPerson daoPerson = new clsDAOPerson();

        public DataTable GetAll()
        {
            return daoPerson.GetAll();
        }

        public DataTable GetOne(string firstname)
        {
            return daoPerson.GetOne(firstname);
        }
    }
}
