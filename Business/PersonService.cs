using DataAccess.Models;
using DataAccess.Repositories;

namespace Business
{
   public class PersonService
    {
        private readonly PersonRepository _repo = new PersonRepository();
        public string ProcessPersonImage(string oldPath, string newSourcePath)
        {
            // 1. If the path hasn't changed, do nothing
            if (oldPath == newSourcePath) return oldPath;

            // 2. Delete the old image if it exists
            if (!string.IsNullOrEmpty(oldPath) && File.Exists(oldPath))
            {
                try { File.Delete(oldPath); } catch { /* Log error */ }
            }

            // 3. If there is no new image, return empty
            if (string.IsNullOrEmpty(newSourcePath)) return "";

            // 4. Copy new image to project folder with a unique name (GUID)
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PeopleImages");
            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            string extension = Path.GetExtension(newSourcePath);
            string newFileName = Guid.NewGuid().ToString() + extension;
            string destinationPath = Path.Combine(folderPath, newFileName);

            File.Copy(newSourcePath, destinationPath, true);

            return destinationPath; // Return the NEW path to save in DB
        }

        public List<Person> GetPeople()
        {
            return _repo.GetAll();
        }

        public void AddPerson(Person person)
        {
            // Business Validation
            if (string.IsNullOrWhiteSpace(person.FirstName))
                throw new Exception("First Name is required.");

            if (person.DateOfBirth > DateTime.Now)
                throw new Exception("Date of Birth cannot be in the future.");

            // The BLL can still handle the "Save Image to Folder" logic here if needed

            _repo.Add(person);
        }

        public void UpdatePerson(Person person)
        {
            // Validate string input
            if (string.IsNullOrWhiteSpace(person.FirstName))
                throw new Exception("First Name is required.");

        

            _repo.Update(person);
        }
        public Person GetPersonDetails(int id)
        {
            var person = _repo.GetByID(id);

            if (person == null)
            {
                 
                throw new Exception("No person found with that ID.");
            }

            return person;
        }


    }
}
