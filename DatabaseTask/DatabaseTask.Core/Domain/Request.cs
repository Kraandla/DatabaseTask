using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("workTopicId")]
        public WorkTopic WorkTopic { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime reviewedDate { get; set; }
        public string status { get; set; }
        public string description { get; set; }
    }
}
