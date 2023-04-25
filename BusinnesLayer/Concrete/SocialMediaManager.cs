using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class SocialMediaManager : IGenericService<SocialMedia>
    {
        public SocialMedia GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SocialMedia> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            throw new NotImplementedException();
        }
    }
}
