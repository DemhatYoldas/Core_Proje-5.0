using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class PortfolioManager : IGenericService<Portfolio>
    {
        public Portfolio GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
