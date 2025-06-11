using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public DateTime birthDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
