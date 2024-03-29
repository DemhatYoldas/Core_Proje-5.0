﻿using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
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
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal) 
        {
            _experienceDal = experienceDal;
        }

        public Experience GetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> GetList()
        {
           return _experienceDal.GetList();
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
           _experienceDal.Delete(t);
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
