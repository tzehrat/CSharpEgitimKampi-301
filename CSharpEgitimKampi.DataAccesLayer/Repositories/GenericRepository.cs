﻿using CSharpEgitimKampi.DataAccesLayer.Abstract ;
using CSharpEgitimKampi.DataAccesLayer.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
       private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object=context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State=EntityState.Deleted;
            context.SaveChanges();

        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int Id)
        {
            return _object.Find(Id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State=EntityState.Modified;
            context.SaveChanges();

                
                }

      
    }

}
