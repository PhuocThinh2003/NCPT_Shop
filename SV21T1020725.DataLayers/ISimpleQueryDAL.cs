namespace SV21T1020725.DataLayers
{
    /// <summary>
    ///  Định nghĩa chức năng truy vấn dữ liệu đơn giản
    /// </summary>
    public interface ISimpleQueryDAL<T> where T : class
    {
        /// <summary>
        /// Truy vấn và lấy toàn bộ dữ liệu của bảng
        /// </summary>
        /// <returns></returns>
        List<T> List();
    }
}
