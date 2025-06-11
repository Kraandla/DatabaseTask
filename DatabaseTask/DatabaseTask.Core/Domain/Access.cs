using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Access
    {
        [Key]
        public int Id { get; set; }
        public string description { get; set; }
    }
}
