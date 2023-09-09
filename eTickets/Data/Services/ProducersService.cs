using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducersService: EntityBaseRepository <Producer>,IProdcersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context)
        {           
        }
    }
}
