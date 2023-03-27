using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();

        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

        void IActorService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
