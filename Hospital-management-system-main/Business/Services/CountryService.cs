using DataAccess.Models;
using DataAccess.Repositories;

namespace Business.Services
{
   public class CountryService
    {
        private readonly CountryRepository _repo = new CountryRepository();

        public List<Country> GetCountries()
        {
            return _repo.GetAll();
        }

        //public void AddCountry(Country country)
        //{
        //    // Business Validation
        //    if (string.IsNullOrWhiteSpace(country.CountryName))
        //        throw new Exception("Country Name is required.");

             
        //    // The BLL can still handle the "Save Image to Folder" logic here if needed

        //    _repo.Add(country);
        //}

        //public void UpdatePerson(Country country)
        //{
           
        //    //    if (string.IsNullOrWhiteSpace(country.CountryName))
        //    //        throw new Exception("Country Name is required.");




        //    //_repo.Update(country);
        //}
        public   Country GetCountryByID(int id)
        {
            var country = _repo.GetByID(id);

            if (country == null)
            {
                 
                throw new Exception("No country found with that ID.");
            }

            return country;
        }

    }
}
