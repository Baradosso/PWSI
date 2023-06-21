using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHWWebAplication.EFModels
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DisplayName("Id studenta")]
        public int StudentId { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Imiê")]
        public string FirstName { get; set; }

        [DisplayName("Wiek")]
        public int Age { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [DisplayName("Id grupy")]
        public int GroupId { get; set; }
    }
}