using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProgramming2_report2 {

    public static class Helper {
        /// <summary>
        ///     The connection string
        /// </summary>
        private const string connString = "Server=MPX; Database=DatabaseProgramming2;Trusted_Connection=True;";

        public static void UpdateFirstRow(int number) {
            using (var con = new SqlConnection(connString)) {
                con.Open();
                var updateCommand = new SqlCommand("spdUpdateTearchesFirstRecord", con);
                updateCommand.CommandType = CommandType.StoredProcedure;
                var pInput = new SqlParameter("@valueToEnter", SqlDbType.NVarChar);
                pInput.Direction = ParameterDirection.Input;
                pInput.Value = string.Format("test{0}", number);
                updateCommand.Parameters.Add(pInput);

                updateCommand.ExecuteNonQuery();
                Console.WriteLine(pInput.Value);
            }
        }
    }

}