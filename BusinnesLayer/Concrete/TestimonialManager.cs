using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class TestimonialManager : IGenericService<Testimonial>
    {
        public Testimonial GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
