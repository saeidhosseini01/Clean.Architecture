using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Common.BaseDto
{
    public class BaseDto
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public Boolean IsDeleted { get; set; }
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
    }
}
