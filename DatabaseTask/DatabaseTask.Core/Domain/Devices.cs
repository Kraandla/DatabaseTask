using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Devices
    {
        [Key]
        public int Id { get; set; }

        public string manufacturer { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string serialNumber { get; set; }
        public string condition { get; set; }
    }
}
