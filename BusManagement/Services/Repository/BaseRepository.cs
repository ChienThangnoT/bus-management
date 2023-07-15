using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected BusDBContext _context;
        protected DbSet<T> _dbSet;
        public BaseRepository()
        {
            _context = new BusDBContext();
            _dbSet = _context.Set<T>();
        }
        public virtual List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Create(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public bool Delete(T item)
        {
            try
            {
                _dbSet.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public void Update(T item)
        {
            var tracker = _context.Attach(item);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public DbSet<T> getDbset()
        {
            return _dbSet;
        }
    }
}
