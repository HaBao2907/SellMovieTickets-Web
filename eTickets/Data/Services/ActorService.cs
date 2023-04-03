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
   public class ActorService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        //Add Actor/Method
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }
        //Showlist/ Actor Method
        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }
        //Get Id Actor Method
        public async Task<Actor> GetByIdAsync (int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result;
        }
        //Update Actor Method
        public async Task<Actor> UpdateAsync (Actor actor)
        {
            _context.Entry(actor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return actor;
        }
        //Deleta Actor Method 
        public async Task DeleteAsync (int id )
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

    }
}
