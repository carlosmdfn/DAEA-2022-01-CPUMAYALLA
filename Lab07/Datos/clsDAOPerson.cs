﻿using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = "SELECT * FROM Person";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            con.Close();
            return dt;
        }

        public DataTable GetOne(string firstName)
        {
            DataTable dt = new DataTable();
            con.Open();
            string sql = string.Format("SELECT * FROM PERSON WHERE FirstName ='{0}'", firstName);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            return dt;
        }
    }
}
