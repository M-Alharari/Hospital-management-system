using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CountryRepository
    {

        public Country? GetByID(int ID)
        {
            using var db = new HospitalContext();
            
            return db.Countries.Find(ID);
        }



        public List<Country> GetAll()
        {
            using var db = new HospitalContext();
            return db.Countries.ToList();
        }

        //public void Add(Country country)
        //{
        //    using var db = new HospitalContext();
        //    db.Countries.Add(country);
        //    db.SaveChanges();
        //}
        //public void Update(Country country)
        //{
        //    using var db = new HospitalContext();
        //    db.Countries.Update(country);
        //    db.SaveChanges();
        //}
        //public void Delete(Country country)
        //{
        //    using var db = new HospitalContext();
        //    db.Countries.Remove(country);
        //    db.SaveChanges();
        //}
    }
}
