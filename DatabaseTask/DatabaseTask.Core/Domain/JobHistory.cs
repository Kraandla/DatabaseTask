using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class JobHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
