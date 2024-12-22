using Microsoft.Data.SqlClient;

namespace SV21T1020725.DataLayers.SQLServer
{
    /// <summary>
    /// Lớp cơ sở của các lớp cài đặt các phép xử lý trên CSDL
    /// </summary>
    public abstract class BaseDAL
    {
        /// <summary>
        /// chuỗi tham số kết nối đến CSDL
        /// </summary>
        protected string connectionString = "";

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Tạo và mở một kết nối đến CSDL
        /// </summary>
        /// <returns></returns>
        protected SqlConnection OpenConnection() 
        {
            SqlConnection connection = new SqlConnection(connectionString); 
            connection.Open();
            return connection;
        }
    }
}
