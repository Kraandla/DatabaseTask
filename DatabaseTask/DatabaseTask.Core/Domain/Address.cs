using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string postalCode { get; set; }
        public int apartmentNumber { get; set; }
        public int buildingPartNumber { get; set; }
        public int buildingNumber { get; set; }
        public string routeName { get; set; }
        public string cityDistrict { get; set; }
        public string administrativeUnit { get; set; }
        public string county { get; set; }
    }
}
