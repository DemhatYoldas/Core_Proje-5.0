using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class ServiceManager : IGenericService<Service>
    {
        public Service GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
