using SecoundExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.service
{
    public class RoomService:IRoomService
    {
        private  ClincContext context;

        public RoomService(ClincContext _context)
        {
            context = _context;
        }
        public List<Room> Load()
        {
            List<Room> li = context.roomContext.ToList();
            return li;
        }

        public List<Room> LoadByName(int No)
        {
            List<Room> li = context.roomContext.Where(x => x.RoomNo == No).ToList();
            return li;
        }
    }
}
