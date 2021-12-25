using SecoundExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.service
{
    public interface IRoomService
    {
        List<Room> Load();
        List<Room> LoadByName(int No);
    }
}
