using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity() 
        {
        }

        public virtual void Update(BaseEntity entity)
        {
            Id = entity.Id;
        }
    }
}
