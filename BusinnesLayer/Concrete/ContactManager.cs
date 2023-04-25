using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class ContactManager : IGenericService<Contact>
    {
        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
