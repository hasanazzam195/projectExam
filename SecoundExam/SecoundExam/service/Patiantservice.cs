using SecoundExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.service
{
    public class Patiantservice :IPatiantservice
    {
        private  ClincContext context;

        public Patiantservice(ClincContext _context)
        {
            context = _context;
        }
        public List<patiant> load()
        {
            List<patiant> li = context.patiantContext.ToList();
            return li;
        }

        public void Exit(int id)
        {
            patiant p = context.patiantContext.Find(id);
            p.Status="Exit";
        }

        public void Insert(patiant p)
        {
            context.patiantContext.Add(p);
            context.SaveChanges();
        }
    }
}
