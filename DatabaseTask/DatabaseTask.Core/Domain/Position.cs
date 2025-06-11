using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        public string description { get; set; }
        public DateTime positionCreatedDate { get; set; }
        public DateTime positionDisabledDate { get; set; }

        [ForeignKey("AccessId")]
        public Access Access { get; set; }
    }
}
