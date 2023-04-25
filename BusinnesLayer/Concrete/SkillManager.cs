using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class SkillManager : IGenericService<Skill>
    {
        public Skill GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
