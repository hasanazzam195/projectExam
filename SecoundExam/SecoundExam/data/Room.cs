using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SecoundExam.data
{
    [Table("Rooms")]
    public class Room
    {
        public int ID { get; set; }
       
        public string Name { get; set; }

        public int RoomNo { get; set; }
        

        public List<patiant> lipatiant { get; set; }
    }
}
