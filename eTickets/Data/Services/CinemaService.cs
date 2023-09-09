using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace eTickets.Data.Services
{
	public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
	{
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
