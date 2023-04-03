using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }
        int ActorId { get; set; }
        int ProducerId { get; set; }
        int CinemaId { get; set; }
    }
}
