using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    //T class olmalı ve new() anahtar sözcüğünü barındırmalı
    public class GenericRepository<T> where T : class,new() 
    {

        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public void TDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }
        public void TUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }
        public T GetT(int id)
        {
            return c.Set<T>().Find(id);
        }
        public List<T> TList(string p)//String bir değere göre sadece listeleme yapıyo
        {
            return c.Set<T>().Include(p).ToList();
        }
        //İstediğim herhangi bir sütuna göre arama işlemi
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
