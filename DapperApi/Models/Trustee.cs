using System;

namespace DapperApi.Models
{
    public class Trustee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Relationship { get; set; }

    }
}