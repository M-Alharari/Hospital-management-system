using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PersonRepository
    {

        public Person? GetByID(int ID)
        {
            using var db = new HospitalContext();
            // Find is optimized for looking up primary keys
            return db.People.Find(ID);
        }



        public List<Person> GetAll()
        {
            using var db = new HospitalContext();
            return db.People.ToList();
        }

        public void Add(Person person)
        {
            using var db = new HospitalContext();
            db.People.Add(person);
            db.SaveChanges();
        }
        public void Update(Person person)
        {
            using var db = new HospitalContext();
            db.People.Update(person);
            db.SaveChanges();
        }
        public void Delete(Person person)
        {
            using var db = new HospitalContext();
            db.People.Remove(person);
            db.SaveChanges();
        }
    }
}
