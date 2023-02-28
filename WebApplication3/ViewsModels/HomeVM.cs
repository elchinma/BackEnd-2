using WebApplication3.Models;

namespace WebApplication3.ViewsModels
{
    public class HomeVM
    {
        public List<Menu> Menu { get; set; }
        public List<Category> Categories { get; set; }
        public double Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
