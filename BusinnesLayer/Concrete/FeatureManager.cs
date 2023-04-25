using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
