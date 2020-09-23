using System.ComponentModel.DataAnnotations;

namespace CIS174_CoreApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Grade { get; set; }
    }
}
