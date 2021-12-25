using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.data
{
    [Table("patiants")]
    public class patiant
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Status { get; set; }
        public int BedNo { get; set; }
        [ForeignKey("room")]
        public int Room_id { get; set; }

        public Room room { get; set; }
    }
}
