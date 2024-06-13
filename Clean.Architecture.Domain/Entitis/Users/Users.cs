using Clean.Architecture.Domain.Common.Entitis;
using Clean.Architecture.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Entitis.Users
{



    public  class Users:BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }


    }
}
