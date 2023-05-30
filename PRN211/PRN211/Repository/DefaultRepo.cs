using Microsoft.EntityFrameworkCore;
using PRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211.Repository
{   
    
    public class DefaultRepo<T> where T : class
    {
        BankAccountTypeContext context;
        DbSet<T> account;
        public DefaultRepo()
        {
            context = new BankAccountTypeContext();
            account = context.Set<T>(); 
        }

        public List<T> getAll()
        {
            return account.ToList();
        }

        public void add(T item)
        {
             account.Add(item);
            context.SaveChanges();
        }

        public void remove(T item) 
        { 
            account.Remove(item);
            context.SaveChanges();
        }

        public void update(T item)
        {
            var checker = context.Attach(item);
            checker.State = EntityState.Modified;   
            context.SaveChanges();
        }
    }
}
