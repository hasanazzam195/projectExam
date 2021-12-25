using SecoundExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.service
{
    public interface IPatiantservice
    {
        List<patiant> load();
        void Exit(int id);

        void Insert(patiant p);
    }
}
