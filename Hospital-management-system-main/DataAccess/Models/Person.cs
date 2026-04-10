namespace DataAccess.Models
{
      public class Person
        {
            public int Id { get; set; }
            public string? FirstName { get; set; }
            public string? SecondName { get; set; }
            public string? ThirdName { get; set; }
            public string? LastName { get; set; }
        //public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}";
        public string FullName =>
    string.Join(" ", new[] { FirstName, SecondName, ThirdName, LastName }
        .Where(x => !string.IsNullOrWhiteSpace(x)));
        public string? NationalNo { get; set; }
            public DateTime DateOfBirth { get; set; }
            public short Gender { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }
            public string ?Email { get; set; }
            public int NationalityCountryID { get; set; }
            public string? ImagePath {  get; set; }
        }
     
}
