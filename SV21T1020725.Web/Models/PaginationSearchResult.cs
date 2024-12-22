using SV21T1020725.DomainModels;

namespace SV21T1020725.Web.Models
{
    public class PaginationSearchResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; } = "";
        public int RowCount { get; set; }
        public int PageCount
        {
            get
            {
                if (PageSize == 0) 
                    return 1;
                int c = RowCount / PageSize;
                if (RowCount % PageSize > 0) 
                    c += 1;
                return c;
            }
        }
    }
    public class CustomerSearchResult : PaginationSearchResult
    {
        public List<Customer> Data { get; set; }
    }

    public class EmployeeSearchResult : PaginationSearchResult 
    {
        public List<Employee> Data { get; set; }
    }

    public class CategorySearchResult : PaginationSearchResult
    {
        public List<Category> Data { get; set; }
    }

    public class ShipperSearchResult : PaginationSearchResult
    {
        public List<Shipper> Data { get; set; }
    }
    public class SupplierSearchResult : PaginationSearchResult
    {
        public List<Supplier> Data { get; set; }
    }
    public class ProductSearchResult : PaginationSearchResult
    {
        public int categoryID { get; set; } = 0;
        public int supplierID { get; set; } = 0;
        public decimal minPrice { get; set; } = 0;
        public decimal maxPrice { get; set; } = 0;

        public List<Product> Data { get; set; }
    }
    public class OrderSearchResult : PaginationSearchResult
    {
        public int Status { get; set; } = 0;
        public string TimeRange { get; set; } = "";
        public List<Order> Data { get; set; } = new List<Order>();
    }

}
