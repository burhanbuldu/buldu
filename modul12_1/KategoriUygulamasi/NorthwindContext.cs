using System.Configuration;
using System.Data.Linq;

namespace KategoriUygulamasi
{
    public class NorthwindContext : DataContext
    {
        public Table<Category> Categories;

        public NorthwindContext()
            : base(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString)
        {
        }
    }
}