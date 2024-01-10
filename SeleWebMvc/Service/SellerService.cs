using SeleWebMvc.Data;
using SeleWebMvc.Models;

namespace SeleWebMvc.Service
{
    public class SellerService
    {
        private readonly SeleWebMvcContext _context;

        public SellerService(SeleWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Inset(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
