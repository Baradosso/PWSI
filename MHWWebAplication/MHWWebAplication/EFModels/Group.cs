using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHWWebAplication.EFModels
{
    [Table("Group")]
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [DisplayName("Id grupy")]
        public int GroupId { get; set; }

        [DisplayName("Nazwa grupy")]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}