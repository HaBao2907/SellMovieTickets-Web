using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
   public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context) : base(context) { }     
    }
}
