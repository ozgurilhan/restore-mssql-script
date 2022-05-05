using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreMicrosoftSQLScript
{
    public static class Extensions
    {
        public static int ExecNonQuery(this SqlCommand cmd)
        {
            int resVal = 0;

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            try
            {

                resVal = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }


            return resVal;
        }
    }
}
