using SV21T1020725.Web.AppCodes;

namespace SV21T1020725.Web.Models
{
    /// <summary>
    /// luu du cac thong tin dau vao sd cho chuc nang tim kiem va hien thi du lieu
    /// </summary>
    public class PaginationSearchInput
    {
        /// <summary>
        /// trang can hien thi
        /// </summary>
        public int Page { get; set; } = 1;
        /// <summary>
        /// so dong hien thi moi trang
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Chuoi gia tri tim kiem
        /// </summary>
        public string SearchValue { get; set; } = "";

    }
    public class ProductSearchInput : PaginationSearchInput
    {
        public int CategoryID { get; set; } = 0;
        public int SupplierID { get; set; } = 0;
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = 0;
    }
    public class OrderSearchInput : PaginationSearchInput
    {
        /// <summary>
        /// The status of the order to search
        /// </summary>
        public int Status { get; set; } = 0;

        /// <summary>
        /// The time range to search (string of 2 date values in the format dd/MM/yyyy - dd/MM/yyyy)
        /// </summary>
        public string TimeRange { get; set; } = "";

        /// <summary>
        /// Get the start time based on DateRange
        /// </summary>
        public DateTime? FromTime
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TimeRange))
                    return null;

                string[] times = TimeRange.Split('-');
                if (times.Length == 2)
                {
                    DateTime? value = times[0].Trim().ToDateTime();
                    return value;
                }

                return null;
            }
        }

        /// <summary>
        /// Get the end time based on DateRange
        /// (end time must be at the end of the day)
        /// </summary>
        public DateTime? ToTime
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TimeRange))
                    return null;

                string[] times = TimeRange.Split('-');
                if (times.Length == 2)
                {
                    DateTime? value = times[1].Trim().ToDateTime();
                    if (value.HasValue)
                        value = value.Value.AddMilliseconds(86399998); // 86399999
                    return value;
                }

                return null;
            }
        }
    }
}
