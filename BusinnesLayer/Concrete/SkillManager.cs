using BusinnesLayer.Abstract;
using DataAccessLayer.EntityFramework;
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
        private EfSkillDal _efSkillDal;

        public SkillManager(EfSkillDal efSkillDal)
        {
            _efSkillDal = efSkillDal;
        }

        public Skill GetByID(int id)
        {
            return _efSkillDal.GetByID(id);
        }

        public List<Skill> GetList()
        {
            return _efSkillDal.GetList();
        }

        public void TAdd(Skill t)
        {
            _efSkillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _efSkillDal.Delete(t);
        }

        public void TUpdate(Skill t)
        {
            _efSkillDal.Update(t);
        }
    }
}
