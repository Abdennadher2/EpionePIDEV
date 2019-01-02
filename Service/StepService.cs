using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using Domain;
using Domaine;
using ServicePattern;

namespace Service
{
    public class StepService : Service<Step>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public StepService() : base(ut)
        {

        }

        public IEnumerable<Step> GetStepsByPatient( int id)
        {
            var res = from req in ut.getRepository<Step>().GetAll()
                where (req.PathId == id)
                select req;
            return res;
        }


    }
}