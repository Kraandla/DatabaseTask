using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public DateTime lastCheckDate { get; set; }
        public DateTime nextCheckDate { get; set; }
        public bool isHealthy { get; set; }
    }
}
