using System.ComponentModel.DataAnnotations.Schema;

namespace TEACHERAPI.DTO
{
    public class TeacherDTO
    {
        [Column("TeacherId")]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
    }
}
