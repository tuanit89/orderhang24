using System.Data;
using System.Data.SqlClient;

namespace Models
{
    public class DataHelper
    {

        public static string GetConnection()
        {
            return Config.ConnectString;
        }

        #region Execute DataSet


        public static DataSet ExecuteQueryToDataSet(string sqlQuery)
        {
            try
            {
                DataSet sqlDS = ExecuteQueryToDataSet(sqlQuery, null, CommandType.Text);
                return sqlDS;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public static DataSet ExecuteQueryToDataSet(string connection, string sqlQuery)
        {
            try
            {
                DataSet sqlDS = ExecuteQueryToDataSet(connection, sqlQuery, null, CommandType.Text);
                return sqlDS;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public static DataSet ExecuteQueryToDataSet(string sqlQuery, SqlParameter[] sqlparam, CommandType sqlCT)
        {
            try
            {
                DataSet sqlDS = new DataSet();

                //Tạo kết nối tới CSDL
                SqlConnection sqlConn = new SqlConnection(GetConnection());


                //sqlConn.Open();

                //Tạo đối tượng dbCommand với câu lệnh SQL truyền vào và thiết lập tham số
                var com = new SqlCommand
                {
                    Connection = sqlConn,
                    CommandType = sqlCT,
                    CommandText = sqlQuery
                };

                //Mở kết nối
                sqlConn.Open();

                if (sqlparam != null)
                {
                    com.Parameters.AddRange(sqlparam);
                }

                //sqlCmd.CommandTimeout = sqlConn.ConnectionTimeout;                
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = com;
                sqlDA.Fill(sqlDS);
                sqlConn.Close();

                return sqlDS;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally {                 
            }
        }

        public static DataSet ExecuteQueryToDataSet(string connection, string sqlQuery, SqlParameter[] sqlparam, CommandType sqlCT)
        {
            try
            {
                DataSet sqlDS = new DataSet();

                //Tạo kết nối tới CSDL
                SqlConnection sqlConn = new SqlConnection(connection);

                //sqlConn.Open();
                //Tạo đối tượng dbCommand với câu lệnh SQL truyền vào và thiết lập tham số
                var com = new SqlCommand
                {
                    Connection = sqlConn,
                    CommandType = sqlCT,
                    CommandText = sqlQuery
                };

                //Mở kết nối
                sqlConn.Open();

                if (sqlparam != null)
                {
                    com.Parameters.AddRange(sqlparam);
                }

                //sqlCmd.CommandTimeout = sqlConn.ConnectionTimeout;                
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = com;
                sqlDA.Fill(sqlDS);
                sqlConn.Close();

                return sqlDS;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        
        #endregion

        #region ExcuteDataReader
        /// <summary>
        /// Trả về datareader, với trường hợp CommandType=CommandType.StoreProcedure
        /// </summary>
        /// <param name="connection">connection</param>
        /// <param name="commandText"></param>
        /// <param name="sqlparam">sqlparametrer</param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(string connection, string commandText, SqlParameter[] sqlparam)
        {
            try
            {
                var con = new SqlConnection(connection);
                var com = new SqlCommand
                              {
                                  Connection = con,
                                  CommandType = CommandType.StoredProcedure,
                                  CommandText = commandText
                              };
                con.Open();
                if (sqlparam != null)
                {
                    com.Parameters.AddRange(sqlparam);
                }
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (DataException e)
            {
                //Logger.Instance.Equals(Logger.ErrConnect + e);
                return null;
            }
        }

        public static IDataReader ExecuteReader(string connection, string commandText,CommandType commandType, SqlParameter[] sqlparam)
        {
            try
            {
                var con = new SqlConnection(connection);
                var com = new SqlCommand
                {
                    Connection = con,
                    CommandType = commandType,
                    CommandText = commandText
                };
                con.Open();
                if (sqlparam != null)
                {
                    com.Parameters.AddRange(sqlparam);
                }
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (DataException e)
            {
                //Logger.Instance.Equals(Logger.ErrConnect + e);
                return null;
            }
        }

        public static IDataReader ExecuteReader(string connection, string commandText, SqlParameter[] sqlparam, out SqlCommand comx)
        {
            try
            {
                var con = new SqlConnection(connection);
                var com = new SqlCommand
                              {
                                  Connection = con,
                                  CommandType = CommandType.StoredProcedure,
                                  CommandText = commandText
                              };
                con.Open();
                if (sqlparam != null)
                {
                    com.Parameters.AddRange(sqlparam);
                }
                comx = com;
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (DataException e)
            {
                // Logger.Instance.Equals(Logger.ErrConnect + e);
                comx = null;
                return null;
            }
        }

        /// <summary>
        /// Trả về datareader với trường hợp CommandType=CommandType.Textr
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="commndText"></param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(string connection, string commndText)
        {
            try
            {
                var con = new SqlConnection(connection);
                var com = new SqlCommand
                              {
                                  CommandText = commndText,
                                  CommandType = CommandType.Text,
                                  Connection = con
                              };
                con.Open();
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (DataException e)
            {
                //Logger.Instance.Error(Logger.ErrConnect + e);
                return null;
            }
        }
        #endregion

        #region ExecuteNonQuery
        public static int ExecuteNonQuery(string commandText, SqlParameter[] sqlparam)
        {
            return ExecuteNonQuery(GetConnection(), commandText, sqlparam);
        }

        /// <summary>
        /// ExecuteNonQuery trường hợp sử dụng storeprocedure
        /// </summary>
        /// <param name="connection">Config.Connectstring</param>
        /// <param name="commandText"></param>
        /// <param name="sqlparam">nếu store không có tham số truyền vào null</param>
        /// <returns>số bản ghi ảnh hưởng</returns>
        public static int ExecuteNonQuery(string connection, string commandText, SqlParameter[] sqlparam)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                                  {
                                      CommandText = commandText,
                                      CommandType = CommandType.StoredProcedure,
                                      Connection = con
                                  };
                    con.Open();
                    if (sqlparam != null)
                    {
                        com.Parameters.AddRange(sqlparam);
                    }
                    return com.ExecuteNonQuery();
                }
            }
            catch (DataException e)
            {
               // Logger.Instance.Error(Logger.ErrConnect + e);
                return -1;
            }
        }

        public static int ExecuteNonQuery(string connection, string commandText, SqlParameter[] sqlparam, out SqlCommand comx)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                                  {
                                      CommandText = commandText,
                                      CommandType = CommandType.StoredProcedure,
                                      Connection = con
                                  };
                    con.Open();
                    if (sqlparam != null)
                    {
                        com.Parameters.AddRange(sqlparam);
                    }
                    comx = com;
                    return com.ExecuteNonQuery();
                }
            }
            catch (DataException e)
            {
                //Logger.Instance.Error(Logger.ErrConnect + e);
                comx = null;
                return -1;
            }
        }

        public static int ExecuteNonQuery(string connection, string commandText, SqlParameter[] sqlparam,CommandType commandType)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                    {
                        CommandText = commandText,
                        CommandType = commandType,
                        Connection = con
                    };
                    con.Open();
                    if (sqlparam != null)
                    {
                        com.Parameters.AddRange(sqlparam);
                    }
                    return com.ExecuteNonQuery();
                }
            }
            catch (DataException e)
            {
                //Logger.Instance.Error(Logger.ErrConnect + e);
                return -1;
            }
        }

        /// <summary>
        /// Trường hợp sử dụng commandText
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connection, string commandText)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                                  {
                                      CommandText = commandText,
                                      CommandType = CommandType.Text,
                                      Connection = con
                                  };
                    con.Open();
                    return com.ExecuteNonQuery();
                }
            }
            catch (DataException e)
            {
              //  Logger.Instance.Error(Logger.ErrConnect + e);
                return -1;
            }
        }
        #endregion

        #region ExecuteScalar
        public static object ExecuteScalar(string connection, string commandText, SqlParameter[] sqlparam)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                                  {
                                      CommandText = commandText,
                                      CommandType = CommandType.StoredProcedure,
                                      Connection = con
                                  };
                    con.Open();
                    if (sqlparam != null)
                    {
                        com.Parameters.AddRange(sqlparam);
                    }
                    return com.ExecuteScalar();
                }
            }
            catch (DataException e)
            {
                //Logger.Instance.Error(Logger.ErrConnect + e);
                return -1;
            }
        }

        public static object ExecuteScalar(string connection, string commandText)
        {
            try
            {
                var con = new SqlConnection(connection);
                using (con)
                {
                    var com = new SqlCommand
                                  {
                                      CommandText = commandText,
                                      CommandType = CommandType.Text,
                                      Connection = con
                                  };
                    con.Open();
                    return com.ExecuteScalar();
                }
            }
            catch (DataException e)
            {
                //Logger.Instance.Error(Logger.ErrConnect + e);
                return -1;
            }
        }
        #endregion
    }
}
