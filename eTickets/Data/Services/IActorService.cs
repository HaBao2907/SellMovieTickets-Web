using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();

        //Method
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);  
        void Delete(int id);

    }
}
