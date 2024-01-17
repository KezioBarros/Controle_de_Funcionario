using SeleWebMvc.Data;
using SeleWebMvc.Models;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace SeleWebMvc.Service
{
    public class SalesRecordService
    {
        private readonly SeleWebMvcContext _context;

        public SalesRecordService(SeleWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date < minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where( x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.DepartmentId)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
