using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Common.Entitis
{
    public class Base
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = new Guid();
        public Boolean IsDeleted { get; set; }
    }
}
