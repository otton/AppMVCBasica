using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVCBasica.Models
{
    public abstract class Entity
    {
        protected Entity() //Protected - pois esta classe somente podera ser herdada
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
    
}
