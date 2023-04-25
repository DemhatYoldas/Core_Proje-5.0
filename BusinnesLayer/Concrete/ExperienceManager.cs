using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class ExperienceManager : IGenericService<Experience>
    {
        public Experience GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
