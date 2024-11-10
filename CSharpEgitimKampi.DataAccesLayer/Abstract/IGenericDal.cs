﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccesLayer.Abstract
{
    public interface IGenericDal<T>where T:class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int Id);
        Lazy<T> GetAll();
        T GetById(int Id);

    }
}
