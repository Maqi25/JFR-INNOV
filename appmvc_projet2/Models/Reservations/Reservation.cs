using appmvc_projet2.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appmvc_projet2.Models.Reservations
{
    public class Reservation
    {
        public int Id { get; set; }
        public virtual PersonneInscrite PersonneInscrite { get; set; }
        public virtual Service Service { get; set; }
    }
}
